using BookHarbor.Models.Models;
using E_Commerce.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models.Models
{
    public class Book : BaseEntity
    {

        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }       
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        [ValidateNever]
        public Genre Genre { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public int TotalPageCount { get; set; }
        public string BookContent { get; set; }

    }
}
