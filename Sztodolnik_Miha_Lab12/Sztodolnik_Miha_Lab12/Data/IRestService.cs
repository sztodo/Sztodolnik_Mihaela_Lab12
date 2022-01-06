using System;
using System.Collections.Generic;
using System.Text;
using Sztodolnik_Miha_Lab12.Models;
using System.Threading.Tasks;

namespace Sztodolnik_Miha_Lab12.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
