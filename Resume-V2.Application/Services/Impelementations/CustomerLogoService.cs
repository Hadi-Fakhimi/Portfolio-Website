using Microsoft.EntityFrameworkCore;
using Resume_V2.Application.DTOs;
using Resume_V2.Application.Services.Interfaces;
using Resume_V2.Infra.Data.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume_V2.Application.Services.Impelementations
{
    public class CustomerLogoService : ICustomerLogo
    {
        #region Constructor
        private readonly AppDbContext _context;
        public CustomerLogoService(AppDbContext context)
        {
            _context = context;
        }

        #endregion
        public async Task<List<CustomerLogoViewModel>> GetAllCustomerLogo()
        {
            List<CustomerLogoViewModel> customerLogos = await _context.CustomerLogos.OrderBy(c => c.Order)
                .Select(c => new CustomerLogoViewModel()
                {
                    Order = c.Order,
                    Link = c.Link,
                    Logo = c.Logo,
                    LogoAlt = c.LogoAlt
                }).ToListAsync();

            return customerLogos;
        }
    }
}
