using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Reseller.Models
{
    public class ResellerItem
    {
        [Key]
        public int ResellerId { get; set; }
        public string ResellerName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public int PhoneNumber { get; set; }
    }
}