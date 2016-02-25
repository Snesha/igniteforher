using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IgniteForHer.Models
{
    public class InstructionContext : DbContext
    {
        public DbSet<Instruction> Instructions { get; set; }

    }
}