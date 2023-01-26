using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3
{
    public class eTicaretService
    {
        List<OrderModel> orderModels = new List<OrderModel>();
        public eTicaretService()
        {
            OrderModel orderModel = new OrderModel { Id = 1, UserId = 1, RmaCode = "rma123", UserNameAndSurname = "ECE ÖZAYDIN", PhoneNumber = "5555555555", Barcode = "12345", Description = "kargo açıklama" };
            orderModels.Add(orderModel);
            orderModel = new OrderModel { Id = 2, UserId = 2, RmaCode = "deneme2", UserNameAndSurname = "ELİF ÖZAYDIN", PhoneNumber = "66666666", Barcode = "barcode2", Description = "asda2" };
            orderModels.Add(orderModel);
        }

        public OrderModel getOrderDetail(string rmacode)
        {
            //LINQ(Language Integrated Query)
            var result = orderModels.Find(c => c.RmaCode == rmacode);
            return result;
            //OrderModel result = null;
            //foreach (var order in orderModels)
            //{
            //    if (order.RmaCode == rmacode)
            //    {
            //        result = order;
            //        break;
            //    }
            //}
            //if (result != null)
            //{
            //    return result;
            //}
            //else
            //{
            //    return null;
            //}
        }

    }
}
