using DependentBenefits.Commands.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DependentBenefits.Commands.Data
{
    public class DependentWriteContext : DbContext
    {
        private IConfigurationRoot _config;

        public DependentWriteContext(IConfigurationRoot config, DbContextOptions options) : base(options)
        {
            _config = config;
        }

        public DbSet<Dependent> Employee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:DefaultConnection"]);
        }
    }
}
