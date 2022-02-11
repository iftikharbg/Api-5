using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace FlowerStore.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        public bool IsBlocked { get; set; } = false;


    }
}
