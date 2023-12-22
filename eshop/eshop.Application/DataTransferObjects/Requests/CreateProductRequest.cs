using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eshop.Application.DataTransferObjects.Requests
{
    public class CreateProductRequest
    {
        [Required(ErrorMessage = "Ürün adı boş olamaz!")]
        [MinLength(2, ErrorMessage = "Ürün adı en az 2 karakterden oluşmalı!")]
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
