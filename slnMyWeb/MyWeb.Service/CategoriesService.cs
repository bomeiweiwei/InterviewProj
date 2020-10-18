using AutoMapper;
using AutoMapper.EquivalencyExpression;
using MyWeb.Dao;
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

        public bool CreateCategories(vw_Categories model)
        {
            int count = 0;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<vw_Categories, Categories>();
            });
            IMapper mapper = config.CreateMapper();
            Categories saveModel = mapper.Map<vw_Categories, Categories>(model);
            try
            {
                count = Create(saveModel);
            }
            catch (Exception)
            { }
            if (count == 1)
                return true;
            else
                return false;
        }

        public bool UpdateCategories(int id, Categories model)
        {
            int count = 0;
            NorthwindEntities entity = (NorthwindEntities)GetCurrentContext();
            CategoriesDao dao = new CategoriesDao();

            List<int> idList = new List<int> { id };
            List<Categories> updateList = new List<Categories> { model };
            List<Categories> taregtList = entity.Categories.Where(m => idList.Contains(m.CategoryID)).ToList();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Categories, Categories>().EqualityComparison((odto, o) => odto.CategoryID == o.CategoryID);
            });
            IMapper mapper = config.CreateMapper();

            mapper.Map(updateList, taregtList).ToList();

            try
            {
                foreach (var item in taregtList)
                {
                    count = dao.UpdateData(item, entity);
                }
            }
            catch (Exception)
            { }
            if (count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool DeleteCategories(int id)
        {
            Categories oriCategory = FindOne(m => m.CategoryID == id);
            int count = Delete(oriCategory);
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
