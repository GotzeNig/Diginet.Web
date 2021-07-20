﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackofficeWireframV2.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}