﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace AcademicApplication.Models
{
    [Table("CourseCart")]
   public class CourseCart
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseCartId { get; set; }


        [Required]
        public Course course { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public CourseStatus Status { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public AppUser Appuser { get; set; }
    }
}