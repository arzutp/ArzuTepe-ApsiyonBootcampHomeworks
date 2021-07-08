using AutoMapper;
using Blog.Business.ViewModel;
using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}
