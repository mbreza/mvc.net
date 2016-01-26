using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarRent.Validators
{
    public class Pesel : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string errorMessage;
            string pesel;

            if (validationContext.DisplayName == null)
                errorMessage = "Zly pesel.";
            else
                errorMessage = FormatErrorMessage(validationContext.DisplayName);

            if (value == null)
                return ValidationResult.Success;

            if (value is string)
                pesel = value.ToString();
            else
                return new ValidationResult("Pesel sklada sie tylko z cyfr.");

            if (pesel.Length != 11)
                return new ValidationResult(errorMessage);

            int[] weight = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int k = 0;

            for (int i = 0; i < pesel.Length; i++)
            {
                int temp;
                if (!Int32.TryParse(pesel[i].ToString(), out temp))
                    return new ValidationResult(errorMessage);
                if (i + 1 == pesel.Length)
                {
                    if ((10 - k % 10) % 10 != temp)
                        return new ValidationResult(errorMessage);
                }
                else
                    k += temp * weight[i];
            }                                   
            
            return ValidationResult.Success;
        }

    }
}