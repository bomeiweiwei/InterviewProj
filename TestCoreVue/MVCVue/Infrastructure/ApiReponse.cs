using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCVue.Web.Infrastructure
{
    public class ApiReponse<T> : BaseReponse where T : class
    {
        public ApiReponse()
        {
        }

        public ApiReponse(T data, bool success = true)
        {
            this.Success = success;
            this.Data = data;
        }

        public ApiReponse(string meeesge, T data, bool success = true)
        {
            this.Success = success;
            this.Data = data;
            this.Message = meeesge;
        }

        public T Data { get; set; }
    }
}
