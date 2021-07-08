using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Dto
{
    public class BasketUpdateDto
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public List<BasketItemUpdateDto> Items { get; set; }
    }
}
