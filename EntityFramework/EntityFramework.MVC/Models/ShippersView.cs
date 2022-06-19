using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFramework.MVC.Models
{
    public class ShippersView
    {
        [Key]
        public int ShipperID { get; set; }

        [Required]

        [StringLength(20)]
        public string ShipperName { get; set; }

        public string ShipperPhone { get; set; }

    }
}