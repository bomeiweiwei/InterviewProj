using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Models.ViewModel
{
    public class ProductsCategoriesViewModel
    {
        public IEnumerable<Categories> CategoriesList { get; set; }
        public IEnumerable<Products> ProductsList { get; set; }
        public PagedList.IPagedList<Products> ProductsPageList { get; set; }
    }
}
