using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsService.Data
{
    public class SmsSendModel
    {
        public string[] Phones { get; set; }
        public string Content { get; set; }
    }
}
