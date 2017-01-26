﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PatientRecords.Models
{
    public class Human
    {
        public int ID { get; set; }
        [Required]
        [StringLength(11)]
        [Display(Name = "SSN")]
        public string SocialSecurityNumber { get; set; }
        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name ="Robot Doctor")]
        public int RobotDoctorId { get; set; }
        public RobotDoctor RobotDoctor { get; set; }
    }
}
