﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Homework1.Models
{
    public class DeleteStudentDto
    {
        [Required]
        public int Id { get; set; }
    }
}
