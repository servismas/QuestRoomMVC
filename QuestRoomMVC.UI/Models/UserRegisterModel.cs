using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuestRoomMVC.UI.Models
{
    public class UserRegisterModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Будь ласка введіть емейл")]
        [EmailAddress(ErrorMessage = "Введіть валідний емейл")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Будь ласка введіть пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Будь ласка повторіть")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Паролі повинні співпадати")]
        public string ConfirmPassword { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Будь ласка введіть місто")]
        [StringLength(50, ErrorMessage = "Too long")]
        public string City { get; set; }
    }
}