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
    //AutoMapper için ne neye çevrilecek onun tanımı yapılır
    public class BlogProfile : Profile
    {
        public BlogProfile()
        {
            CreateMap<BlogViewModel, BlogArticle>();
            CreateMap<BlogArticle, BlogViewModel>();
        }
    }
}
