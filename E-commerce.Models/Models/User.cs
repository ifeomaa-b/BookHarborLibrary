using Microsoft.AspNetCore.Identity;

namespace E_commerce.Models.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }          
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Gender { get; set; }
    }
}
