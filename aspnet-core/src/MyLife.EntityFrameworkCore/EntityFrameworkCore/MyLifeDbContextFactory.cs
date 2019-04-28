using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MyLife.Configuration;
using MyLife.Web;

namespace MyLife.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyLifeDbContextFactory : IDesignTimeDbContextFactory<MyLifeDbContext>
    {
        public MyLifeDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyLifeDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyLifeDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyLifeConsts.ConnectionStringName));

            return new MyLifeDbContext(builder.Options);
        }
    }
}
