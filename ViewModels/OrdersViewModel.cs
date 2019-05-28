using System.Linq;
using lab5.Models;

namespace lab5.ViewModels
{
    public class OrdersViewModel
    {
        public Order OrderViewModel { get; set; }
        public IQueryable<Order> PageViewModel { get; set; }
        public int PageNumber { get; set; }
    }
}
