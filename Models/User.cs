using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string f_name { get; set; }
        [MaxLength(50, ErrorMessage = "Password must be no longer than 50 characters")]

        [Required]
        public string l_name { get; set; }
        [MaxLength(50, ErrorMessage = "Password must be no longer than 50 characters")]

        public string patronymic { get; set; }

        [Required]
        public DateTime birthday { get; set; }

        public enum Gender { male, female }

        public Gender  gender { get; set; } 

        [Range(70, 250, ErrorMessage = "Please, enter the truth value")]
        public int? height { get; set; }


        [Range(35, 250, ErrorMessage = "Please, enter the truth value")]
        public int? weight { get; set; }

        
        //body mass index
        public double index { get {
                if (height != 0& weight!=0&height!=null&weight!=0)
                {
                    var res = weight / (height * height / 10000);
                    return (double)res;
                }
                else
                {
                    return 0;
                }
               
            } }

        public bool isStudent { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        public string country { get; set; }


    }
}
