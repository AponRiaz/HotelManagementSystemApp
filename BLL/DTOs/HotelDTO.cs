﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class HotelDTO
    {
    public int HotelID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        public string UserType { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }
        [Required]  
        public string Email { get; set; }
        [Required]
        public string Stars { get; set; }
        [Required]
        public DateTime CheckTime { get; set; }
        [Required]
        public DateTime CheckoutTime { get; set; }




    }
}
