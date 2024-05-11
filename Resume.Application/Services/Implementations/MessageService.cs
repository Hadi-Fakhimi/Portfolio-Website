using Microsoft.EntityFrameworkCore;
using Resume.Application.Security;
using Resume.Application.Services.Interfaces;
using Resume.Domain.Models;
using Resume.Domain.ViewModels.Message;
using Resume.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.Services.Implementations
{
    public class MessageService : IMessageService
    {
        private readonly AppDbContext _dbContext;
        public MessageService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> CreateMessage(CreateMessageViewModel message)
        {
           Message newMessage = new Message()
           {
               Email = message.Email.SanitizeText(),
               MessageContact = message.MessageContact.SanitizeText(),
               Name = message.Name.SanitizeText()
           };

                await _dbContext.AddAsync(newMessage);
                await _dbContext.SaveChangesAsync();
                return true;
                 
        }

        public async Task<bool> DeleteMessage(long id)
        {
            var message = await _dbContext.Messages.FirstOrDefaultAsync(m => m.Id == id);

            if(message == null)
            {
                return false;
            }

            _dbContext.Messages.Remove(message);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<List<MessageViewModel>> GetAllMessages()
        {
            List<MessageViewModel> messages = await _dbContext.Messages.Select(m => new MessageViewModel() 
            {
                Id = m.Id,
                Email =  m.Email,
                MessageContact = m.MessageContact,
                Name = m.Name
            
            }).ToListAsync();


            return messages;
        }
    }
}
