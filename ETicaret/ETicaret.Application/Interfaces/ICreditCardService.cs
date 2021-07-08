
using ETicaret.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces
{
    public interface ICreditCardService
    {
        Task<bool> WithdrawMoney(CreditCardDto creditCard);
    }
}
