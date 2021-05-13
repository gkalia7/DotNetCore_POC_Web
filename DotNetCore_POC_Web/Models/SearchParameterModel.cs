using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore_POC_Web.Models {
    public class SearchParameterModel {
        [Required]
        [Display(Name = "Cert Id cannot be blank")]
        public string CertId {get; set;}

        [Required]
        [Display(Name = "Start date cannot be blank")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End date cannot be blank")]
        public DateTime EndDate { get; set; }
    }
}
