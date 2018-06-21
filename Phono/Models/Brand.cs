using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Phono.Models
{
    public class Brand
    {
        public int ID { get; set; }

        [Display(Name = "Brand")]
        public string BrandName { get; set; }

        [Display(Name = "Country Of Origin")]
        public string CountryOfOrigin { get; set; }
    }
}