using DataProcessingApp.Domain;
using Microsoft.Extensions.Logging;
using OrderProcessingApp.DataLogic.Interface;
using OrderProcessingApp.Repository;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.DataLogic.Implementation
{
    public class OrderProcessingDL : IOrderProcessingDL
    {
        private readonly ILogger<OrderProcessingDL> _logger;
        public OrderProcessingDL(ILogger<OrderProcessingDL> logger)
        {        
            _logger = logger;
        }

        public async Task<bool> ActivateMemebership()
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Business Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.ActivateMemebership();
            _logger?.LogInformation(string.Format("Business Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> AddFreeFirstAid(Product product)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Data Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.AddFreeFirstAid(product);
            _logger?.LogInformation(string.Format("Data Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> CommissonPaymentToAgent(Agent agent)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Data Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.CommissonPaymentToAgent(agent);
            _logger?.LogInformation(string.Format("Data Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> Email(Bill bill, Customer customer)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Data Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.Email(bill,customer);
            _logger?.LogInformation(string.Format("Data Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> GenerateDuplicateReceipt(Bill bill)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Data Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.GenerateDuplicateReceipt(bill);
            _logger?.LogInformation(string.Format("Data Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> GenerateReceipt(Bill bill, Customer customer)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Data Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.GenerateReceipt(bill,customer);
            _logger?.LogInformation(string.Format("Data Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> InformUpgradation()
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Data Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.InformUpgradation();
            _logger?.LogInformation(string.Format("Data Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }

        public async Task<bool> UpgradeMembershipMemebership(Bill bill, Customer customer)
        {
            var methodName = MethodBase.GetCurrentMethod().Name;
            _logger?.LogInformation(string.Format("Data Logic Call Starts", methodName, DateTime.UtcNow.ToString()) + "\n");
            var result = DataRepository.UpgradeMembershipMemebership(bill,customer);
            _logger?.LogInformation(string.Format("Data Logic Call Ends", methodName, DateTime.Now.ToString()) + "\n");
            return result;
        }
    }
}
