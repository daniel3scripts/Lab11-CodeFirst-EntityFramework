using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class Seller
    {

        public int SellerId { get; set; }
        public string SellerName { get; set; }

        public string SellerLastName { get; set; }
        public string Dni { get; set; } 
        public string Email { get; set; }
        public string Ruc { get; set; } 
        public DateTime SellerDate { get; set; }
       

       


    }
}