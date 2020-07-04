using System;
using System.Collections.Generic;
using System.Text;

namespace DataProcessingApp.Domain
{
    public class Payment
    {
       
        public string CardNumber { get; set; }
        public string Name { get; set; }
        public int CVV { get; set; }
        public string DateofExp { get; set; }
        public string PaymentType { get; set; }
    }
}
