using DataProcessingApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApp.API
{
    public class OrderProcessingRequestObject
    {
        public OrderProcessingRequestObject()
        {
            agent = new Agent();
            bill = new Bill();
            customer = new Customer();
            payment = new Payment();
            product = new Product();
        }
        public  Agent agent { get;set;}
        public Bill bill { get; set; }
        public Customer customer { get; set; }
        public Payment payment { get; set; }
        public Product product { get; set; }

    }
}
