using Resume.Domain.Models;
using Resume.Domain.ViewModels.Portfolio;
using Resume.Domain.ViewModels.PortfolioCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Domain.ViewModels.Page
{
    public class PortfolioPageViewModel
    {
        public List<PortfolioViewModel> Portfolio { get; set; }
        public List<PortfolioCategoryViewModel> PortfolioCategory { get; set; }

    }
}
