using JobSeekerRecord.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSeekerRecord.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options) { }


        public DbSet<JobSeekerModel> JobSeekerTable { get; set; }
       
    }
}
