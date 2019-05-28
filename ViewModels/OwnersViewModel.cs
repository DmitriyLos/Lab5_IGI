using System.Linq;
using lab5.Models;

namespace lab5.ViewModels
{
    public class OwnersViewModel
    {
        public Owner OwnerViewModel { get; set; }
        public IQueryable<Owner> PageViewModel { get; set; }
        public int PageNumber { get; set; }
        public enum SortState
        {
            No,
            FioOwnerAsc,
            FioOwnerDesc,
        }
    }
}
