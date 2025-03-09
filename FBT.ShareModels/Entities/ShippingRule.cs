using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    [Table("ShippingRules")]
    public class ShippingRule 
    {
        [Key]
        public int Id { get; set; }

        public string CountryCode { get; set; }

        public string StateCode { get; set; }

        public int? Weight { get; set; }

        public string Courier { get; set; }
    }
}