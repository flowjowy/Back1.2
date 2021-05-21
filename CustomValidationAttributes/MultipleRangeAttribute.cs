using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.CustomValidationAttributes
{
    public class MultipleRangeAttribute : ValidationAttribute
    {
        int[] _start, _end;

        public MultipleRangeAttribute(int[] start, int[] end)
        {
            _start = start;
            _end = end;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var valToCheck = (int)value;

            for(int i=0; i < _start.Length; i++)
            {
                if(valToCheck >= _start[i] && valToCheck <= _end[i])
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult(string.IsNullOrWhiteSpace(ErrorMessage) ? "Value is out of range" : ErrorMessage);
        }
    }
}
