using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApp.API
{
    public class OrderProcessingResponseObject
    {
        public string Success { get; set; }
        public string Failure { get; set; }

        public string SuceessMsg { get; set; }
        public string FailureMsg { get; set; }
    }
}
