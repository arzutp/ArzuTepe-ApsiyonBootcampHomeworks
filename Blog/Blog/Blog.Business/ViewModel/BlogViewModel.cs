using Blog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ViewModel
{
    public class BlogViewModel
    {
        //Entity işlemlerini bu katmanda yapmalıyız
        public string Title { get; set; }      
        public virtual List<CategoryViewModel> Categories { get; set; } //sadece adları
        public virtual List<TagViewModel> Tags { get; set; }
        public List<int> SelectedTags { get; set; }
        public List<int> SelectedCategories { get; set; }
        public string Article { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public List<CommentViewModel> Comments { get; set; }
    }
}
