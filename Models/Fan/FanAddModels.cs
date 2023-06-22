using System;
using System.ComponentModel.DataAnnotations;

namespace JPGStockServer.Models.Fan
{
    public class FanAddModels
    {
        [Required]
        public String PART_NUMBER { get; set; }
        [Required]
        public Double? VOLTAGE { get; set; }
        [Required]
        public Double? AMPERE { get; set; }
        [Required]
        public Double? WATT { get; set; }
        [Required]
        public String LOCATION { get; set; }
        [Required]
        public Int32? IGNORE { get; set; }
        [Required]
        public Int64? QUANTITY { get; set; }
        [Required]
        public string COMPONENTS_ID { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        [Required]
        public DateTime UpdateDate { get; set; }
        public String User { get; set; }
        public String SIZE { get; set; }
        public Int64? WIRE { get; set; }
    }
}
