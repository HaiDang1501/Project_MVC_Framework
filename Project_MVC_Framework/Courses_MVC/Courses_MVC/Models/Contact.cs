using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Contact
    {
        public int contactId { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public string HoTen { get; set; }

        [Display(Name ="Email")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        [EmailAddress(ErrorMessage = "Mail phải đúng định dạng")]
        public string  email { get; set; }

        [Display(Name = "Số điện thoại")]
        [Phone]
        [Required(ErrorMessage ="Phải nhập số điện thoại")]
        public string  SDT { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Tiêu đề")]
        public string title { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Nội dung")]
        public string content { get; set; }
    }
}
