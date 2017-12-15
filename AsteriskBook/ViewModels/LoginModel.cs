using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AsteriskBook.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не верный логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не верный пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
