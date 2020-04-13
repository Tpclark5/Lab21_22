using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21_22.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Invalid Entry, Please Enter A Valid Name", MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Invalid Entry, Please Enter A Valid Name", MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Invalid Entry, Please Enter A Valid UserName", MinimumLength = 8)]
        public string Username { get; set; }

        [Required(ErrorMessage = "You must provide an email address")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
        ErrorMessage = "Please enter a valid email address")]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }

        public string ErrorMessage { get; set; }

    }
}
