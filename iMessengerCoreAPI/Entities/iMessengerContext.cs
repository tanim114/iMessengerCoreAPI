using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iMessengerCoreAPI.Models
{
    public class iMessengerContext: DbContext
    {
        public iMessengerContext(DbContextOptions<iMessengerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet <RGDialog> Dialogs { get; set; }
        public DbSet<RGClient> RGClient { get; set; }
    }
}
