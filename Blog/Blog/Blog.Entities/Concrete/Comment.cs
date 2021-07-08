using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public virtual User User { get; set; }
        public virtual BlogArticle BlogArticle { get; set; }

    }

}
