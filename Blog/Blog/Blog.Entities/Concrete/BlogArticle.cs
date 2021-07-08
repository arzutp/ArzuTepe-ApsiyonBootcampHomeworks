using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    public class BlogArticle : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }

        // [ForeignKey("CategoryId")]
        public virtual List<Category> Categories { get; set; }
        public virtual List<Tag> Tags { get; set; }
        public string Article { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
       
    }
}
