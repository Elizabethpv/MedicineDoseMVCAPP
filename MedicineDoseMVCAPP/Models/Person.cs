using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MedicineDoseMVCAPP.Models
{
    public class Person
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter name"), MaxLength(30)]
        [Display(Name = "Student Name")]
        public String Name { get; set; }


        [Required]
        [Range(18, 50, ErrorMessage = "Enter the minimum age between 18 to 50 !")]
        public int Age { get; set; }


        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public String Email { get; set; }

        public String ChainSmoker { get; set; }


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter MedicineDose"), MaxLength(30)]
        [Display(Name = "Student MedicineDose")]
        public string MedicineDose{ get; set; }

    }
}