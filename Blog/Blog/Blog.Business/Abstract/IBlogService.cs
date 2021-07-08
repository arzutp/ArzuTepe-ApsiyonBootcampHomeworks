using Blog.Business.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{//bu servisi yazma amacımız direkt database'e erişim olmasını istemememiz
    //içerde blogwievmodel ile işlemler yapıyoruz
    public interface IBlogService : IService<BlogViewModel>
    {
        List<BlogViewModel> GetAllByCategory(int categoryId);
        Task AddWithCategories(BlogViewModel blog);
        //Arayüzün ilgilindeiği tek şey işlemin başarılı olup olmaması
    }
}
