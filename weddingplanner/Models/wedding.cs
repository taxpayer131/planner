using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using weddingplanner.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace weddingplanner.Models
{
    public class wedding
    {
        [Key]
        public int wedding_id { get; set; }
        public DateTime date { get; set; }
        public string bride_name { get; set; }
        public string groom_name { get; set; }
        public string address { get; set; }
        [ForeignKey("user_id")]
        public User Planner { get; set; }
        public int user_id { get; set; }
        public List<RSVP> Guests { get; set; }
    }
}