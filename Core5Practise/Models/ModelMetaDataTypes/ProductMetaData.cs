using System.ComponentModel.DataAnnotations;

namespace Core5Practise.Models.ModelMetaDataTypes
{
    public class ProductMetaData
    {
        [Required(ErrorMessage = "Please enter product name ")]
        [StringLength(55, ErrorMessage = " please enter 55 character> Name ")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        [EmailAddress(ErrorMessage = "please insert valid email addres")]
        public string Email { get; set; }

    }
}