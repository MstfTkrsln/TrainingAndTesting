using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVCSample.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [DisplayName("Öğrenci Adı")]
        [Required]
        public string StudentName { get; set; }

        public int Age { get; set; }
        [DisplayName("Mezun mu?")]
        public bool isGraduated { get; set; }

        [DisplayName("Cinsiyet")]
        [Required]
        public Gender Gender { get; set; }

        public string GenderStr { get; set; }

        public string Password { get; set; }
    }


    public enum Gender
    {
        Male,
        Female
    }
}