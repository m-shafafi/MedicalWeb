using Products.Domain.Menu;
using Products.Domain.Menu.Models;
using Products.Domain.News.Article;
using Products.Domain.Products;
using Products.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Infrastructure.Products
{
    public class MenuWriteRepository : IMenuWriteRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public MenuWriteRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region
        public async  Task<Menu_Category> AddMenuCategoriesAsync(Menu_Category menu_Category) {
            var result = await _dbContext.AddAsync(menu_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Menu_Category> UpdateMenuCategoriesAsync(Menu_Category menu_Category) {
            var result = _dbContext.Update(menu_Category);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteMenuCategoriesAsync(Menu_Category menu_Category) {
            _dbContext.categoryMenus.Remove(menu_Category);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
        #region 
        public async Task<Menu_MainMenu> AddMainMenuAsync(Menu_MainMenu menu_Main) {
            var result = await _dbContext.AddAsync(menu_Main);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Menu_MainMenu> UpdateMainMenuAsync(Menu_MainMenu menu_Main) {
            var result = _dbContext.Update(menu_Main);
            await _dbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task DeleteMainMenuAsync(Menu_MainMenu menu_Main) {
            _dbContext.mainMenus.Remove(menu_Main);
            await _dbContext.SaveChangesAsync();
        }
        #endregion
    }
}
