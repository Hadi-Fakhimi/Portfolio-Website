using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Domain.Models;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class MessageService : IMessage
    {
        #region Constructor
        private readonly AppDbContext _context;
        public MessageService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<bool> CreateMessage(MessageViewModel message)
        {
            Message newMessage = new Message()
            {
                Email = message.Email,
                MessageContact = message.MessageContact,
                Name = message.Name,
                Title = message.Title,
            };
            await _context.AddAsync(newMessage);
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
