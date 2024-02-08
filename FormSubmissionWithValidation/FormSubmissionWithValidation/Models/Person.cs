using FormSubmissionWithValidation.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormSubmissionWithValidation.Models
{
    public class Person
    {
        [Required]
        [RegularExpression(@"^[a-zA-Z\s.\-]+$", ErrorMessage = "Name can not contain numbers and special characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Username required")]
        [StringLength(10)]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Username should be length 10 maximum and no space ")]
        public string Uname { get; set; }
        
        [Required]
        [RegularExpression(@"^2[0-9]-\d{5}-[1-3]$", ErrorMessage = "As per the AIUB ID convention")]
        public string Id { get; set; }
        [Required]
        [ValidateEmail]
        public string Email { get; set; }
    }
}