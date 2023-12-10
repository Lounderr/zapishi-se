using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZapishiSe.Data.Models.Validators
{
    public class ServiceMaxPriceRange : ValidationAttribute
    {
        private string basePricePropertyName;
        private decimal maxPrice;

        public ServiceMaxPriceRange(string basePricePropertyName, double maxPrice)
        {
            this.basePricePropertyName = basePricePropertyName;
            this.maxPrice = (decimal)maxPrice;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var basePriceProperty = validationContext.ObjectType.GetProperty(this.basePricePropertyName);

            if (basePriceProperty == null)
            {
                return new ValidationResult($"Unknown property - {this.basePricePropertyName} is null.");
            }

            var basePriceValueObj = basePriceProperty.GetValue(validationContext.ObjectInstance, null);

            if (value is decimal price && basePriceValueObj is decimal basePrice)
            {
                if (price > basePrice && price < this.maxPrice)
                {
                    return ValidationResult.Success;
                }

                return new ValidationResult("Max price should be larger than Min price.");
            }

            return new ValidationResult("Value and/or BasePriceValue must be of type decimal");
        }
    }

}
