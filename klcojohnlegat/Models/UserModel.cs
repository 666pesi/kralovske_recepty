using klcojohnlegat.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace klcojohnlegat.Models
{
    public class UserModel
    {
        [Key]
        public Guid UserID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string? Desctiption { get; set; }
        public UserRole Role { get; set; }
    }
}
