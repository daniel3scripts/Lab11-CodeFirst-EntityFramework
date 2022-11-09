using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class Customer

    {
        public int CustomerID { get; set; } 
        public string CustomerName { get; set; }   
        
        public string CustomerLastName { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }   
        public string PhoneNumber { get; set; } 
        public DateTime CreatedDate { get; set; }

        
    }
}