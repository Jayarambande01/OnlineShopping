﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

namespace OnlineShopping.WebApp.Models;
public class CategoryDto
{
    [Key]
    public int CategoryId { get; set; }
    [StringLength(50)]
    [Required]
    public string CategoryName { get; set; }
}
