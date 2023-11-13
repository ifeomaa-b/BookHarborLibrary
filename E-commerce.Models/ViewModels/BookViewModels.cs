using E_commerce.Models.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace E_commerce.Models.ViewModels
{
    public class BookViewModels
    {
        public Book Book { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GenreList { get; set; }
    }
}
