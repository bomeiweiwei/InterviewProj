using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVue.Web.Infrastructure
{
    public class BaseReponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public List<string> ValidationErrors { get; set; }
    }
}
