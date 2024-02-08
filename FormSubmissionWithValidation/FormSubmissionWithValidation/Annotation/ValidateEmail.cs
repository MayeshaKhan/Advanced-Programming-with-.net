using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace FormSubmissionWithValidation.Annotation
{
    public class ValidateEmail : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = (string)value;

            if (email != null)
            {
                string pattern = @"\d{2}-\d{5}-[1-3]@student.aiub.edu$";

                if( Regex.IsMatch(email, pattern))
                {
                    return ValidationResult.Success;
                }
                return new ValidationResult("As per the AIUB Email convention");
            }
            return new ValidationResult("Email is required");
        }
    }
}