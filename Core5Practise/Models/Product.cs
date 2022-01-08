using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;
using Core5Practise.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;

namespace Core5Practise.Models
{
    
    
    [ModelMetadataType(typeof(ProductMetaData))]
    public class Product
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public string Email { get; set; }

    }
}