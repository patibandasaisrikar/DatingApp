using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }  //No case sensitive issue here
        
        [Required]
        [StringLength(8, MinimumLength=4)]
        public string Password { get; set; }



    }
}