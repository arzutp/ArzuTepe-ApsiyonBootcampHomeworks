
using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using ETicaret.Application.Interfaces;
using ETicaret.Application.Profiles;
using ETicaret.Application.Services;
using ETicaret.Domain.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure;
using ETicaret.Infrastructure.Context;
using ETicaret.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application
{
    public static class DependencyContainer
    {
        public static IServiceCollection RegisterETicaret(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<ETicaretDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("Default"))
            .UseLazyLoadingProxies());

            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
           .AddEntityFrameworkStores<ETicaretDbContext>();

            services.AddScoped<IUnitofWork, UnitofWork>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ICategoryRespository, CategoryRepository>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IBasketRepository, BasketRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddHttpClient<ICreditCardService, CreditCardService>(options => {
                options.BaseAddress = new Uri(configuration["CreditCard:Url"]);
            });


            var mappingConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.AddProfile(new BasketProfile());
                cfg.AddProfile(new CategoryProfile());
                cfg.AddProfile(new ProductProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
