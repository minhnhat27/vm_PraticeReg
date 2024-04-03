using System.ComponentModel.DataAnnotations;

namespace MyWebAPI.Data.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Vui lòng nhập MSCB hoặc Email")]
        public string MSCB { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập mật khẩu")]
        public string Password { get; set; }
    }
}
