using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectOne.Models
{
    public class FAQ
    {
        [Key]
        public int MessageID { get; set; }

        [Required (ErrorMessage = "Must submit a Question")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Question must be between 10 and 500 characters")]
        public string Question { get; set; }

        
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Answer must be between 10 and 500 characters")]
        public string Answer { get; set; }
    }
}