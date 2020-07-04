using DataProcessingApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingApp.BusinessLogic.Interface
{
    public interface IOrderProcessingBL
    {
        public Task<bool> GenerateReceipt(Bill bill, Customer customer);

        public Task<bool> CommissonPaymentToAgent(Agent agent);

        public Task<bool> GenerateDuplicateReceipt(Bill bill);

        public Task<bool> ActivateMemebership();

        public Task<bool> Email(Bill biil, Customer customer);

        public Task<bool> UpgradeMembershipMemebership(Bill bill, Customer customer);

        public Task<bool> InformUpgradation();

        public Task<bool> AddFreeFirstAid(Product product);
    }
}
