using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KHadijaSadki_PartMVC.Models
{
    public class Visitor
    {
        [Required(ErrorMessage = "Enter your FirstName")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter your SecondName")]
        public string SecondName { get; set; }
        [EmailAddress(ErrorMessage = "Please enter valid email format")]
        public string Email { get; set; }
        [Required]
        public string Tel { get; set; }

        [Required]
        public int Age { get; set; }
        [Required(ErrorMessage = "Please enter your Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your postcode tussen 1000-1500")]
        [Range(1000, 1500)]
        public int PostalCode { get; set; }
        [Required(ErrorMessage = "Enter your City")]
        public string City { get; set; }
        [Required]
        public bool IsFamily { get; set; }
    }
}
