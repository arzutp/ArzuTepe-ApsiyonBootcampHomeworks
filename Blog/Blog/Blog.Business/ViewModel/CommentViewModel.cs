using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.ViewModel
{
    public class CommentViewModel
    {
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; }
        public string BlogTitle { get; set; }
    }
}
