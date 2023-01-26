using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3
{
    public class CargoService
    {
        List<OrderModel> orderModels = new List<OrderModel>();
        public CargoService()
        {
            OrderModel orderModel = new OrderModel { Id = 1, UserId = 1, RmaCode = "rma123", UserNameAndSurname = "ECE ÖZAYDIN", PhoneNumber = "5555555555", Barcode = "12345", Description = "kargo açıklama" };
            orderModels.Add(orderModel);
            orderModel = new OrderModel { Id = 2, UserId = 2, RmaCode = "deneme2", UserNameAndSurname = "ELİF ÖZAYDIN", PhoneNumber = "66666666", Barcode = "barcode2", Description = "asda2" };
            orderModels.Add(orderModel);
        }
        public string getRmaCode(string cargoBarcode)
        {
            string rmaCode = "" ;
            var result = orderModels.Find(c => c.Barcode == cargoBarcode);
            rmaCode = result == null ? "" : result.RmaCode;
            return rmaCode;
        }
        
    }
}
