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
    public class TagProfile : Profile
    {
        public TagProfile()
        {            
            CreateMap<TagViewModel, Tag>();
            CreateMap<Tag, TagViewModel>();
        }
    }
}
