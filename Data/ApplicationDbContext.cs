﻿using ByeMed.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByeMed.Data
{
    public class ApplicationDbContext : DbContext
    {
      
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {}
        public DbSet<Student> Students { get; set; }
    }
}
