using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.CustomValidationAttributes;

namespace WebApplication1.Models
{
    public class RegisterViewModel : IValidatableObject
    {
        [Required]
        [EmailAddress]
        [Remote(action: "VerifyEmail", controller: "Home")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        //[MaxLength(16, ErrorMessage = "Password must be no longer than 16 characters")]
        //[MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Password confirmation")]
        [DataType(DataType.Password)]
        //[Compare("Password", ErrorMessage = "Password and Password confirmation fields are different")]
        public string ConfirmPassword { get; set; }

        //[MultipleRange(new int[] { 1, 20 }, new int[] { 10, 30 }, ErrorMessage = "My custom message")]
        public int IntProperty { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Password != ConfirmPassword)
            {
                yield return new ValidationResult("Password and Password confirmation fields are different", new[] { nameof(Password), nameof(ConfirmPassword) });
            }

            if(IntProperty > 10 && IntProperty < 20)
            {
                yield return new ValidationResult("IntProperty is out of range");
            }
        }
    }
}

