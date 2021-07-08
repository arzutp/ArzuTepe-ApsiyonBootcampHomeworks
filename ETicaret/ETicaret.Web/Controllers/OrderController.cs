using ETicaret.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicaret.Application.Dto;

namespace ETicaret.Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly ICreditCardService _creditCardService;
        public OrderController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }
        public IActionResult Index()
        {
            return View();
        }

  
        public async Task<IActionResult> Payment()
        {

            var currentBasket = HttpContext.Session.Get<BasketViewDto>("basket");

            return View(currentBasket);
        }

        [HttpPost]
        public async Task<IActionResult> Payment(CreditCardDto creditCard)
        {
            bool result = await _creditCardService.WithdrawMoney(creditCard);
            return View();
        }

        public IActionResult Basket()
        {
            var currentBasket = HttpContext.Session.Get<BasketViewDto>("basket");

            return View(currentBasket);
        }

        public IActionResult BasketAdd(int id)
        {
            var currentBasket = HttpContext.Session.Get<BasketViewDto>("basket");
            if (currentBasket == default)
            {
                BasketViewDto basketView = new BasketViewDto();
                basketView.Items = new List<BasketItemViewDto>();
                basketView.Items.Add(new BasketItemViewDto { ProductId = id, Piece = 1, Price=200 });

                HttpContext.Session.Set<BasketViewDto>("basket", basketView);
            }
            else
            {
                var currentItem = currentBasket.Items.FirstOrDefault(x => x.ProductId == id);
                if (currentItem == null)
                {
                    currentBasket.Items.Add(new BasketItemViewDto { ProductId = id, Piece = 1, Price=200 });

                    
                }
                else
                {
                    currentItem.Piece++;
                }

                HttpContext.Session.Set<BasketViewDto>("basket", currentBasket);
            }


            return Ok(new { status=true });
        }
    }
}
