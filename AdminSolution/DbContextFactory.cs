using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using AdminSolution.DataLayer;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;

namespace AdminSolution
{
    public class DbContextFactory
        //: IDesignTimeDbContextFactory<DbLayerContext>
    {
        //public DbLayerContext CreateDbContext(string[] args)
        //{
        //    IConfigurationRoot configuration = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile("appsettings.json")
        //        .Build();
        //    var builder = new DbContextOptionsBuilder<DbLayerContext>();
        //    var connectionString = configuration.GetConnectionString("DefaultConnection");
        //    builder.UseSqlServer(connectionString);
        //    return new DbLayerContext(builder.Options);
        //}
        //    public DbLayerContext Create()
        //    {
        //        var environmentName = Environment.GetEnvironmentVariable("Hosting:Environment");
        //        var basePath = AppContext.BaseDirectory;
        //        return Create(basePath, environmentName);
        //    }

        //    public DbLayerContext Create(DbContextFactoryOptions options)
        //    {
        //        return Create();
        //    }

        //    private DbLayerContext Create(string basePath, string environmentName)
        //    {
        //        var builder = new ConfigurationBuilder()
        //        .SetBasePath(basePath)
        //        .AddJsonFile("appsettings.json")
        //        .AddJsonFile($"appsettings.{environmentName}.json", true)
        //        .AddEnvironmentVariables();

        //        var config = builder.Build();
        //        var connstr = config.GetConnectionString("DefaultConnection");

        //        if (string.IsNullOrWhiteSpace(connstr) == true)
        //        {
        //            throw new InvalidOperationException(
        //            "Could not find a connection string named '(DefaultConnection)'.");
        //        }
        //        else
        //        {
        //            return Create(connstr);
        //        }
        //    }

        //    private DbLayerContext Create(string connectionString)
        //    {
        //        if (string.IsNullOrEmpty(connectionString))
        //            throw new ArgumentException(
        //            $"{nameof(connectionString)} is null or empty.",
        //            nameof(connectionString));

        //        var optionsBuilder = new DbContextOptionsBuilder();
        //        optionsBuilder.UseSqlServer(connectionString);
        //        return new DbLayerContext(optionsBuilder.Options);
        //    }
        }
    }

