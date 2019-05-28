using System;
using System.Linq;
using lab5.Models;

namespace lab5.ViewModels
{
    public class CarsViewModel
    {
        public Car CarViewModel { get; set; }
        public IQueryable<Car> PageViewModel { get; set; }
        public int PageNumber { get; set; }     
    }

    
}
