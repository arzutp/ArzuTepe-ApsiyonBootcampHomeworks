using Blog.Business.Abstract;
using Blog.Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.DepedencyResolvers
{
    public static class DependencyContainer
    {
        //erişimlerin bulunduğu sınıf
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //AddSingletion: Tek bir obje öretilir ugulama işi bitene kadar 
            //AddScoped: request başına newleme RepositoryPattern DbContext
            //AddTransient: her atıf için bir tane örnek sürekli new leniyor tamamen özel paylaşılmayan durumlar için (Kullanıcı sepeti)j25

            //önce hangi db
            services.AddDbContext<BlogDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Default")).UseLazyLoadingProxies());        
            services.AddScoped<IBlogService, BlogService>();
            services.AddScoped<IBlogRepository, BlogRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ITagService, TagService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());  //tanımlamaların nerede olduğunu ister
            return services;
        }
    }
}
