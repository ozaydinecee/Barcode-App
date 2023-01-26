using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Business.Abstract;
using WebApplication3.Models;

namespace WebApplication3.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        public OrderModel getRMADataByRMACode(string cargoBarcode)
        {
            CargoService kargoservis = new CargoService();
            eTicaretService eticaretservis = new eTicaretService();
            var rmacode=kargoservis.getRmaCode(cargoBarcode);
            var result = eticaretservis.getOrderDetail(rmacode);

            return result;
        }
    }
}
