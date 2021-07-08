using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Web.Models
{
    public class PagingViewModel
    {
        public int TotalPageCount { get; set; }
        public int CurrentPage { get; set; }
        public int PerPage { get; set; }
    }
}
