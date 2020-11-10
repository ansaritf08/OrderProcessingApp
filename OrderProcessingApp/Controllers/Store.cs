using DataProcessingApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApp.API.Controllers
{
    public class Store
    {
        public static List<Product> productList = new List<Product>();
        public static List<Medicine> medicineList = new List<Medicine>();
        public static List<Product> getProductList()
        {
            productList.Add(new Product { ProductDesc = "", ProductName = "", ProductNum = "", ProductType = "" });
            productList.Add(new Product { ProductDesc = "", ProductName = "", ProductNum = "", ProductType = "" });
            productList.Add(new Product { ProductDesc = "", ProductName = "", ProductNum = "", ProductType = "" });
            return productList;
        }

        public static List<Medicine> getMedicineList()
        {
            medicineList.Add(new Medicine { Id =10001, Name = "MedicineA", Brand = "BrandA", Price = 1000, Notes = "", Quantity = 10, ExpiryDate = DateTime.Now });
            medicineList.Add(new Medicine { Id = 10002, Name = "MedicineB", Brand = "BrandB", Price = 2000, Notes = "", Quantity = 20, ExpiryDate = DateTime.Now });
            medicineList.Add(new Medicine { Id = 10003,  Name = "MedicineC", Brand = "BrandC", Price = 3000, Notes = "", Quantity = 30, ExpiryDate = DateTime.Now });
            return medicineList;
        }
    }
}
