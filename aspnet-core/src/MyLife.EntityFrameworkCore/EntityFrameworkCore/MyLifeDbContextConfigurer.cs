using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyLife.EntityFrameworkCore
{
    public static class MyLifeDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyLifeDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyLifeDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
