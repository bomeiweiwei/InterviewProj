using AutoMapper;
using MyWeb.Models;
using MyWeb.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Service
{
    public class CategoriesService : BaseService<Categories>
    {
        public List<vw_Categories> GetViewList()
        {
            List<vw_Categories> result = new List<vw_Categories>();
            List<Categories> categories = GetAll().ToList();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categories, vw_Categories>()
                .ForMember(dest => dest.Src, opts => opts.MapFrom(s => "data:image/png;base64," + Convert.ToBase64String(s.Picture)))
                ;
            });
            IMapper mapper = config.CreateMapper();
            result = mapper.Map<List<Categories>, List<vw_Categories>>(categories).ToList();
            return result;
        }
    }
}
