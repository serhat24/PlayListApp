using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataAccess
{
    public class PlayListAppContextFactory : IDesignTimeDbContextFactory<PlayListAppContext>
    {
        public PlayListAppContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PlayListAppContext>();
            optionsBuilder.UseMySQL("server=localhost;database=PlayListApp;user=root;password=gs");

            return new PlayListAppContext(optionsBuilder.Options);
        }
    }
}