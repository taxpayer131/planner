using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using weddingplanner.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace weddingplanner.Models
{

    public class WeddingplannerContext : DbContext
    {
        public WeddingplannerContext(DbContextOptions<WeddingplannerContext> options)
           : base(options) { }


    public DbSet<User> users { get; set; }
    public DbSet<wedding> weddings { get; set; }
    public DbSet<RSVP> rsvps { get; set; }
}
}