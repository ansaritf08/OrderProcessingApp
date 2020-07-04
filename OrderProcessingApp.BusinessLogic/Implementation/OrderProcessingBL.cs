using DataProcessingApp.Domain;
using OrderProcessingApp.BusinessLogic.Interface;
using OrderProcessingApp.DataLogic.Interface;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace OrderProcessingApp.BusinessLogic.Implementation
{
    public class OrderProcessingBL : IOrderProcessingBL
    {

        private readonly IOrderProcessingDL _orderProcessingDL;
        private readonly ILogger<OrderProcessingBL> _logger;
        public OrderProcessingBL(IOrderProcessingDL orderProcessingDL, ILogger<OrderProcessingBL> logger)
        {
            _orderProcessingDL = orderProcessingDL;
            _logger = logger;
        }

        public async Task<bool> ActivateMemebership()
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
             var result = await _orderProcessingDL.ActivateMemebership();
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> AddFreeFirstAid(Product product)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
             var result = await _orderProcessingDL.AddFreeFirstAid(product);
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> CommissonPaymentToAgent(Agent agent)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
             var result = await _orderProcessingDL.CommissonPaymentToAgent(agent);
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> Email(Bill bill, Customer customer)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
             var result = await _orderProcessingDL.Email(bill,customer);
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> GenerateDuplicateReceipt(Bill bill)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
             var result = await _orderProcessingDL.GenerateDuplicateReceipt(bill);
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> GenerateReceipt(Bill bill, Customer customer)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
              var result = await _orderProcessingDL.GenerateReceipt(bill,customer);
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> InformUpgradation()
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
              var result = await _orderProcessingDL.InformUpgradation();
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> UpgradeMembershipMemebership(Bill bill, Customer customer)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = await _orderProcessingDL.UpgradeMembershipMemebership(bill,customer);
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }
    }
}
