using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using weddingplanner.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace weddingplanner.Models
{
    public class RSVP
    {
        [Key]
        public int rsvp_id { get; set; }
        [ForeignKey("user_id")]
        public User Guest { get; set; }
        public int user_id { get; set; }
        public int wedding_id { get; set; }
    }
}