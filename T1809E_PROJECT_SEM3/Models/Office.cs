﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace T1809E_PROJECT_SEM3.Models
{
    public class Office
    {
        [Key]
        public string ID { get; set; }
        [Required]
        public string PinCode { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Not a valid email.")]
        public string Email { get; set; }
       
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }


        public int? District_id { get; set; }
        [ForeignKey("District_id")]
        public virtual District District { get; set; }

        [ForeignKey("Province_id")]
        public virtual Provinces Province { get; set; }
        public int? Province_id { get; set; }

        public StatusEnum Status { get; set; }
        public enum StatusEnum
        {
            Online = 1,
            Offline = 0,
            Delete = 2
        }
    }
}