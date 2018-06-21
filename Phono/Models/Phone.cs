using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Phono.Models
{
    public class Phone
    {
        public int ID { get; set; }

        [Display(Name = "Phone Name")]
        public string PhoneName { get; set; }

        [Display(Name = "Date Released")]
        
        public DateTime DateReleased { get; set; }

        [Display(Name = "Screen Size")]
        public double ScreenSize { get; set; }

        public Brand brand { get; set; }

        [Display(Name = "Brand")]
        public int BrandID { get; set; }

        public PhoneType phoneType { get; set; }

        [Display(Name = "Phone Type")]
        public int PhoneTypeId { get; set; }

    }
}