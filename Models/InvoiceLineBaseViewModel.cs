using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A2THH.Models
{
    public class InvoiceLineBaseViewModel
    {
        [Key]
        [Display(Name = "Line ID")]
        public int InvoiceLineId { get; set; }

        [Display(Name = "Unit Price")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "Line Total")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal LinePrice
        {
            get
            {
                return Quantity * UnitPrice;
            }
        }
    }
}