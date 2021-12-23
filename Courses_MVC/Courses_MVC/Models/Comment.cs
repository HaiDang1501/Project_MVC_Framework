using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class Comment
    {
        [Display(Name ="Tên người dùng")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        public string userId { get; set; }
        
        public AppUser AppUser { get; set; }

        [Display(Name = "Tên sinh khóa học")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        public int courseId { get; set; }

        public Course Course { get; set; }

        [Display(Name = "Nội dung")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        public string content { get; set; }

        [Display(Name = "Điểm đánh giá")]
        [Required(ErrorMessage = "Phải nhập {0}")]
        public float evaluate { get; set; }   

        
    }
}
