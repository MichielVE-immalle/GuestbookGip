using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GuestbookGip.Models
{
    public class GuestbookGipContext : DbContext
    {
        public GuestbookGipContext (DbContextOptions<GuestbookGipContext> options)
            : base(options)
        {
        }

        public DbSet<GuestbookGip.Models.Comment> Comment { get; set; }
    }
}
