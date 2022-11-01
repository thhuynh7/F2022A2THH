using F2022A2THH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A2THH.Models
{
    public class InvoiceWithDetailViewModel : InvoiceBaseViewModel
    {
        public IEnumerable<InvoiceLineWithDetailViewModel> InvoiceLines { get; set; }

        [Required]
        [StringLength(40)]
        public string CustomerFirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerLastName { get; set; }

        [StringLength(40)]
        public string CustomerState { get; set; }

        [StringLength(40)]
        public string CustomerCountry { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerEmployeeFirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string CustomerEmployeeLastName { get; set; }
        
    }
}