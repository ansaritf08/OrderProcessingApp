using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DataProcessingApp.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OrderProcessingApp.API;
using OrderProcessingApp.API.Controllers;
using OrderProcessingApp.BusinessLogic.Interface;
using OrderProcessingApp.DataLogic.Interface;

namespace OrderProcessingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderProcessingController : ControllerBase
    {

        private readonly IOrderProcessingBL _orderProcessingBL;
        private readonly ILogger<OrderProcessingController> _logger;

        public OrderProcessingController(ILogger<OrderProcessingController> logger, IOrderProcessingBL orderProcessingBL)
        {
            _logger = logger;
            _orderProcessingBL = orderProcessingBL;
        }

        [HttpGet]
        public async Task<Object> Get()
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("APi call start" + methodName, DateTime.UtcNow.ToString()) + "\n");

            OrderProcessingResponseObject orderProcessingResponseObject = new OrderProcessingResponseObject();
            List<Medicine> listMedicine = new List<Medicine>();
            if (!ModelState.IsValid)
            {
                orderProcessingResponseObject.Failure = "Fail";
                orderProcessingResponseObject.FailureMsg = "Invalid Request Model";
                return orderProcessingResponseObject;
            }
            try
            {
                listMedicine =  Store.getMedicineList();
            }
            catch (Exception ex)
            {
                orderProcessingResponseObject.Failure = "Failed with exception";
                orderProcessingResponseObject.FailureMsg = "DataBase called failed";
                _logger?.LogInformation(ex.Message);
            }
            orderProcessingResponseObject.Failure = "Success";
            orderProcessingResponseObject.FailureMsg = "Successfully completed";
            _logger?.LogInformation(string.Format("Api call end", methodName, DateTime.Now.ToString()) + "\n");
            return listMedicine;
        }


        [HttpGet]
        public async Task<Object> Get(int Id)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("APi call start" + methodName, DateTime.UtcNow.ToString()) + "\n");

            OrderProcessingResponseObject orderProcessingResponseObject = new OrderProcessingResponseObject();
            List<Medicine> listMedicine = new List<Medicine>();
            if (!ModelState.IsValid)
            {
                orderProcessingResponseObject.Failure = "Fail";
                orderProcessingResponseObject.FailureMsg = "Invalid Request Model";
                return orderProcessingResponseObject;
            }
            try
            {
                var lst  = Store.getMedicineList();
                listMedicine = lst.Where(x=>x.Id==Id).ToList();

            }
            catch (Exception ex)
            {
                orderProcessingResponseObject.Failure = "Failed with exception";
                orderProcessingResponseObject.FailureMsg = "DataBase called failed";
                _logger?.LogInformation(ex.Message);
            }
            orderProcessingResponseObject.Failure = "Success";
            orderProcessingResponseObject.FailureMsg = "Successfully completed";
            _logger?.LogInformation(string.Format("Api call end", methodName, DateTime.Now.ToString()) + "\n");
            return listMedicine;
        }


        //[HttpPost]
        //public async Task<OrderProcessingResponseObject> Post(OrderProcessingRequestObject oPRRequestObject)
        //{
        //    var methodName = MethodBase.GetCurrentMethod().Name;
        //    _logger?.LogInformation(string.Format("APi call start" + methodName, DateTime.UtcNow.ToString()) + "\n");

        //    OrderProcessingResponseObject orderProcessingResponseObject = new OrderProcessingResponseObject();
        //    if (!ModelState.IsValid)
        //    {
        //        orderProcessingResponseObject.Failure = "Fail";
        //        orderProcessingResponseObject.FailureMsg = "Invalid Request Model";
        //        return orderProcessingResponseObject;
        //    }

        //    try
        //    {
        //        if (PaymentType.PhysicalProduct == oPRRequestObject.payment.PaymentType)
        //        {
        //            //GenerateReceipt() //CommissonPaymentToAgent()
        //            var generateReceipt = await _orderProcessingBL.GenerateReceipt(oPRRequestObject.bill, oPRRequestObject.customer);
        //            var commissonPaymentToAgent = await _orderProcessingBL.CommissonPaymentToAgent(oPRRequestObject.agent);

        //        }
        //        else if (PaymentType.Book == oPRRequestObject.payment.PaymentType)
        //        {
        //            //GenerateDuplicateReceipt()
        //            var generateDuplicateReceipt = await _orderProcessingBL.GenerateDuplicateReceipt(oPRRequestObject.bill);
        //        }
        //        else if (PaymentType.AtivateMembership == oPRRequestObject.payment.PaymentType)
        //        {
        //            //ActivateMemebership()//Email() //Inform Activation
        //            var activateMemeberShip = await _orderProcessingBL.ActivateMemebership();
        //            var activationEmail = await _orderProcessingBL.Email(oPRRequestObject.bill, oPRRequestObject.customer);
        //        }
        //        else if (PaymentType.UpgradeMembership == oPRRequestObject.payment.PaymentType)
        //        {
        //            //UpgradeMembershipMemebership()// Email() //InformUpgradation()
        //            var upgradeMemeberShip = await _orderProcessingBL.UpgradeMembershipMemebership(oPRRequestObject.bill, oPRRequestObject.customer);
        //            var upgradationEmail = await _orderProcessingBL.Email(oPRRequestObject.bill, oPRRequestObject.customer);

        //        }
        //        else if (PaymentType.Video == oPRRequestObject.payment.PaymentType)
        //        {
        //            //AddFreeFirstAid()
        //            var addFreeFirstAid = await _orderProcessingBL.AddFreeFirstAid(oPRRequestObject.product);
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        orderProcessingResponseObject.Failure = "Failed with exception";
        //        orderProcessingResponseObject.FailureMsg = "DataBase called failed";
        //        _logger?.LogInformation(ex.Message);
        //    }
        //    orderProcessingResponseObject.Failure = "Success";
        //    orderProcessingResponseObject.FailureMsg = "Successfully completed";
        //    _logger?.LogInformation(string.Format("Api call end", methodName, DateTime.Now.ToString()) +"\n");
        //    return orderProcessingResponseObject;
        //}




    }
}
