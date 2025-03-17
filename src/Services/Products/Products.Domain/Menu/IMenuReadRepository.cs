using Products.Domain.Menu;
using Products.Domain.Menu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Domain.Menu
{
    public interface IMenuReadRepository
    {
        Task<List<Menu_Category>> FetchAllMenuCategoriesAsync();
        Task<Menu_Category> FetchMenuCategoriesAsync();
        Task<List<Menu_MainMenu>> FetchAllMenuAsync();
        Task<Menu_MainMenu> FetchMenuAsync();
    }
}
