using MedicalShop.Domain.Menu;
using MedicalShop.Domain.Menu.Models;
using MedicalShop.Domain.Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Products
{
    public interface IProducReadRepository
    {
        #region 
        Task<List<Menu_Category>> FetchAllMenuCategoriesAsync();
        Task<Menu_Category> FetchMenuCategoriesAsync();
        Task<List<Menu_MainMenu>> FetchAllMenuAsync();
        Task<Menu_MainMenu> FetchMenuAsync();
        #endregion
    }
}
