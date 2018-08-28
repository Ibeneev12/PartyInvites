using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста введите ваше имя")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Пожалуйста введите ваш Email")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Пожалуйста введите верный Email адрес")]
        public string Email { get; set; }
        [Required (ErrorMessage = "Пожалуйста введите ваш номер телефона")]
        public string Phone { get; set; }
        [Required (ErrorMessage = "Укажите, будете ли вы присутствовать")]
        public bool? WillAttend { get; set; }
    }
}