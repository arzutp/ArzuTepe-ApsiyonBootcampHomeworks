using ETicaret.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Web.Models
{
    public class ProductsViewModel
    {
        public List<CategoryViewDto> Categories { get; set; }
        public List<ProductViewDto> Products { get; set; }

        public PagingViewModel Paging { get; set; }
    }
}
