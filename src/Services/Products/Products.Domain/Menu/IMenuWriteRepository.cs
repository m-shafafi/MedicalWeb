using Products.Domain.Menu;
using Products.Domain.Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Menu
{
    public interface IMenuWriteRepository
    {
        Task<Menu_Category> AddMenuCategoriesAsync(Menu_Category menu_Category);
        Task<Menu_Category> UpdateMenuCategoriesAsync(Menu_Category menu_Category);
        Task DeleteMenuCategoriesAsync(Menu_Category menu_Category);
        #region 
        Task<Menu_MainMenu> AddMainMenuAsync(Menu_MainMenu menu_Main);
        Task<Menu_MainMenu> UpdateMainMenuAsync(Menu_MainMenu menu_Main);
        Task DeleteMainMenuAsync(Menu_MainMenu menu_Main);
        #endregion
    }
}
