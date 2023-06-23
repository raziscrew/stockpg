using System;
using System.ComponentModel.DataAnnotations;

namespace JPGStockServer.Models.Fan
{
    public class FanUpdateQuantityModels
    {

        [Required]
        public Int32 STOCK_ID { get; set; }

        [Required]
        public Int64? QUANTITY { get; set; }

    }
}
