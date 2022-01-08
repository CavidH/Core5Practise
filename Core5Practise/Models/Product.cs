using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;

namespace Core5Practise.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Please enter product name ")]
        [StringLength(55, ErrorMessage = " please enter 55 character> Name ")]
        public string name { get; set; }
        public int quantity { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress(ErrorMessage = "please insert valid email addres")]
        public string Email { get; set; }

    }
}