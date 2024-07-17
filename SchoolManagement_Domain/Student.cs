using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Domain
{
    public class Student : BaseEntity
    {
        [MaxLength(50, ErrorMessage = "FirstName should be less then 50 character.")]
        public string FirstName { get; set; }
        [MaxLength(50, ErrorMessage = "LastName should be less then 50 character.")]
        public string LastName { get; set; }

        [MaxLength(10, ErrorMessage = "LastName should be less then 50 character.")]
        public string Gender { get; set; }

        [MaxLength(50, ErrorMessage = "FatherName should be less then 50 character.")]
        public string FatherName { get; set; }

        [MaxLength(50, ErrorMessage = "MotherName should be less then 50 character.")]
        public string MotherName { get; set; }

        [MaxLength(50, ErrorMessage = "Address should be less then 50 character.")]
        public string Address { get; set; }

        [MaxLength(50, ErrorMessage = "City should be less then 50 character.")]
        public string City { get; set; }

        [MaxLength(50, ErrorMessage = "Country should be less then 50 character.")]
        public string Country { get; set; }
        public Int64 Phone { get; set; }
        public char Status { get; set; } = '1';

    }
}
