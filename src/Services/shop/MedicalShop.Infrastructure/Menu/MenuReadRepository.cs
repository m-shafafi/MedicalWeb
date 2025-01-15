using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.News.Models;
using MedicalShop.Domain.Products.Models;
using MedicalShop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Infrastructure.Menu
{
    public class MenuReadRepository : IMenuReadRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public MenuReadRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Menu_Category>> FetchAllMenuCategoriesAsync()
        {
            var result = new List<Menu_Category>();
            return result.ToList();
        }
        public async Task<Menu_Category> FetchMenuCategoriesAsync()
        {
            var result = new Menu_Category();
            return result;
        }
        public async Task<List<Menu_MainMenu>> FetchAllMenuAsync()
        {
            var result = new List<Menu_MainMenu>();
            return result.ToList();
        }
        public async Task<Menu_MainMenu> FetchMenuAsync()
        {
            var result = new Menu_MainMenu();
            return result;
        }

    }
}
