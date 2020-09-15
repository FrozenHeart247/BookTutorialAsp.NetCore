using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Подключаем либу для проверки [Required]

namespace PartyInviteSite.Models
{
    public class GuesResponse
    {
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter Email")] [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Enter Valid Email")]
        public string Mail { get; set; }
        [Required(ErrorMessage ="Enter Phone")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "This is required field")]
        public bool? WillAttend { get; set; }
    }
}
