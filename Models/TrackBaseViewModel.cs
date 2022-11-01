using F2022A2THH.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace F2022A2THH.Models
{
    public class TrackBaseViewModel
    {
        [Key]
        public int TrackId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Track Name")]
        public string Name { get; set; }

        [StringLength(220)]
        [Display(Name = "Composer Name(s)")]
        public string Composer { get; set; }

        [Display(Name = "Length (ms)")]
        public int Milliseconds { get; set; }

        [Display(Name = "Size (bytes)")]
        public int? Bytes { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        [Display(Name = "Price")]
        public decimal UnitPrice { get; set; }

    }
}