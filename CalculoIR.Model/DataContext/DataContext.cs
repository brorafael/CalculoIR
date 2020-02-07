using CalculoIR.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace CalculoIR.Model.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Contribuinte> Contribuintes { get; set; }
    }
}