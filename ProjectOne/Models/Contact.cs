using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOne.Models
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [Display(Name ="Full Name")]
        [StringLength(30, MinimumLength = 6, ErrorMessage ="Name must be between 6 and 30 characters")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Confirm Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Compare ("Email")]
        public string CheckEmail { get; set; }

        [Required(ErrorMessage = "Subject line is required")]
        [Display(Name = "Subject Line")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "A message is required")]
        [Display(Name = "Message")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Messages must be between 10 and 1000 characters")]
        public string message { get; set; }
    }
}