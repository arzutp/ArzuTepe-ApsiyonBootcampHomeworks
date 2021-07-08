using AutoMapper;
using ETicaret.Application.Dto;
using ETicaret.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Profiles
{
    public class BasketProfile : Profile
    {
        public BasketProfile()
        {
            CreateMap<BasketAddDto, Basket>().ReverseMap();
            CreateMap<BasketUpdateDto, Basket>().ReverseMap();
            CreateMap<BasketViewDto, Basket>().ReverseMap();

            CreateMap<BasketItemAddDto, BasketItem>().ReverseMap();
            CreateMap<BasketItemUpdateDto, BasketItem>().ReverseMap();
            CreateMap<BasketItemViewDto, BasketItem>().ReverseMap();
        }
    }
}
