using System.ComponentModel.DataAnnotations;

namespace TCF.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string UserName { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
    }
}