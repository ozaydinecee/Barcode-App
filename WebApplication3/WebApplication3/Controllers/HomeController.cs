using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Business.Abstract;
using WebApplication3.Business.Concrete;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
       // public OrderManager orderManager;
        IOrderService _orderService;

        //public HomeController(ILogger<HomeController> logger)
        public HomeController(ILogger<HomeController> logger, IOrderService orderService)
        {
            _logger = logger;
            //orderManager = new OrderManager();
            _orderService = orderService;
        }
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        
        public ActionResult Index(string text)
        {
           // OrderModel model = orderManager.getRMADataByRMACode(text);
           
           var model=_orderService.getRMADataByRMACode(text);
            return View(model);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
