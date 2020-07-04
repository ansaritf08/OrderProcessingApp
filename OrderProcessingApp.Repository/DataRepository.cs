using DataProcessingApp.Domain;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderProcessingApp.Repository
{
    public static class DataRepository
    {
        public static List<Product> productList = new List<Product>();
        public static List<Membership> membershipList = new List<Membership>();
        public static List<Bill> billList = new List<Bill>();
        public static List<Agent> agentList = new List<Agent>();
        public static List<Payment> paymentList = new List<Payment>();
        public static List<Customer> customerList = new List<Customer>();
        public static void getProductList()
        {
            productList.Add(new Product { ProductDesc = "", ProductName = "", ProductNum = "", ProductType = "" });
            productList.Add(new Product { ProductDesc = "", ProductName = "", ProductNum = "", ProductType = "" });
            productList.Add(new Product { ProductDesc = "", ProductName = "", ProductNum = "", ProductType = "" });
        }


        public static bool GenerateReceipt(Bill bill, Customer customer)
        {
            try
            {
                billList.Add(bill);
                customerList.Add(customer);
                return true;
            }
            catch(Exception ex)
            {

            }
            return false;

        }

    public static bool CommissonPaymentToAgent(Agent agent)
    {
            try
            {
                agentList.Add(agent);              
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static bool GenerateDuplicateReceipt(Bill bill)
        { 
            try
            {
                billList.Add(bill);              
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }



        public static bool ActivateMemebership()
        { 
            try
            {
               
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static  bool Email(Bill bill, Customer customer)
        { 
            try
            {
                billList.Add(bill);
                customerList.Add(customer);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static  bool UpgradeMembershipMemebership(Bill bill, Customer customer)
        { 

            try
            {
                billList.Add(bill);
                customerList.Add(customer);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static  bool InformUpgradation()
        { 
            try
            {
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

        public static  bool AddFreeFirstAid(Product product)
        { 
            try
            {
                productList.Add(product);
                return true;
            }
            catch (Exception ex)
            {

            }
            return false;
        }

    }
}
