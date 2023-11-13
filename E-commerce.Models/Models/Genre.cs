using BookHarbor.Models.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Genre : BaseEntity
    {
        [Required]
        [DisplayName("Genre Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
