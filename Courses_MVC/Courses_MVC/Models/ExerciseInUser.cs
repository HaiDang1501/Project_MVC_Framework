﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Courses_MVC.Models
{
    public class ExerciseInUser
    {
        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Bài tập")]
        public int exerciseId { get; set; }

        
        public Exercise Exercise { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Tên người dùng")]
        public string userId { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Bài làm")]
        public string content { get; set; }

        public AppUser AppUser { get; set; }

        [Required(ErrorMessage = "Phải nhập {0}")]
        [Display(Name = "Nộp bài")]
        public DateTime submit { get; set; }

        [Display(Name = "Điểm")]
        public float scores { get; set; }

    }
}
