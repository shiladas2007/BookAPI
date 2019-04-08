using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public class Payment
    {
        public int UserId { get; set; }
        public string CardHolderName { get; set; }
        public string CardHolderAddress { get; set; }
        public string CreditCardNumber { get; set; }
        public string CardSecurityCode { get; set; }
        public string CardBrand { get; set; }
        public string CardType { get; set; }
        public double PaymentAmount { get; set; }

    }
}
