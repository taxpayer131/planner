using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace weddingplanner.Models
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string LogEmail { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string LogPassword { get; set; }
    }
}