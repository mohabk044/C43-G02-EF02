using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data.Models
{
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }


        [Column(TypeName ="varchar")]
        //[StringLength(50,MinimumLength = 10)]
        [MinLength(50)]
        [Length(10,50)]
        public string? Name { get; set; }


        [Column(TypeName ="decimal(12,2)")]
        public double Salary { get; set; }


        [Range(22,60)]
        [AllowedValues(20, 21, 22, 23)]
        [DeniedValues(10,15)]
        public int? Age { get; set; }

        //[DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
