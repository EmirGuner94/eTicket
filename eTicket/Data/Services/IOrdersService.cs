using eTicket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTicket.Data.Services
{
    
    
    public interface IOrdersService
    {

        //add order to the database
        Task StoreOrderAsync(List<ShoppingCartItem>items,string userId,string userEmailAddress);


        //get all orders from the database
        Task<List<Order>> GetOrdersByUserIdAndRoleAsync(string userId,string userRole);
    }
}
