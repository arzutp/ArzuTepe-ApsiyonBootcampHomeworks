using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Dto
{
    public class BasketAddDto
    {
        public Guid UserId { get; set; }
        public  List<BasketItemAddDto> Items { get; set; }
    }

    public class BasketViewDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public Guid UserId { get; set; }
        public List<BasketItemViewDto> Items { get; set; }
    }
}
