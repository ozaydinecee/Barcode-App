using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserNameAndSurname { get; set; }
        public string PhoneNumber { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string RmaCode { get; set; }
    }
}
