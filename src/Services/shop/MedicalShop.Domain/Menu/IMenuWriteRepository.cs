using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Menu
{
    public interface IMenuWriteRepository
    {
        Task<Menu_Category> AddMenuCategoriesAsync(Menu_Category Product_Category);
        Task<Menu_Category> UpdateMenuCategoriesAsync(Menu_Category Product_Category);
        Task DeleteMenuCategoriesAsync(Menu_Category Product_Category);
        #region 
        Task<Menu_MainMenu> AddMainMenuAsync(Menu_MainMenu Product_Category);
        Task<Menu_MainMenu> UpdateMainMenuAsync(Menu_MainMenu Product_Category);
        Task DeleteMainMenuAsync(Menu_MainMenu Product_Category);
        #endregion
    }
}
