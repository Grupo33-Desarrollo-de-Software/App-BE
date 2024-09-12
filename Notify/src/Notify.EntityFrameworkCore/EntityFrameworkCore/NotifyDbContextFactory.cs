using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Notify.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NotifyDbContextFactory : IDesignTimeDbContextFactory<NotifyDbContext>
{
    public NotifyDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        NotifyEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<NotifyDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new NotifyDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Notify.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
