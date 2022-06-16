using backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderSummary> SliderSummary { get; set; }
        public DbSet<WorkSummary> WorkSummary { get; set; }
        public DbSet<WorkSlider> WorkSliders { get; set; }
    }
}
