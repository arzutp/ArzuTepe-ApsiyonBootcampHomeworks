using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.CreditCardService.Configuration
{
    public class MongoDbConfiguration
    {
        public string ConnectionString { get; set; }
        public string Database { get; set; }
    }
}
