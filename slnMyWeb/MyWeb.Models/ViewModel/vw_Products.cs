using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Models.ViewModel
{
    public class vw_Products : Products
    {
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
    }
}
