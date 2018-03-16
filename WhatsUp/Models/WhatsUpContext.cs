using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WhatsUp.Models;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class WhatsUpContext : DbContext
    {
        public WhatsUpContext(DbContextOptions<WhatsUpContext> options)
            : base(options)
        { }

        public DbSet<Question> Questions { get; set; } 
    }

}