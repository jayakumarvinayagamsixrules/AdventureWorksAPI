﻿// See https://aka.ms/new-console-template for more information
using AdventureWorks.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

ILoggerFactory loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

IConfiguration configuration = builder.Build();

var connectionString = configuration.GetConnectionString("Sqlserver");
Console.WriteLine(connectionString);

//var options = new DbContextOptionsBuilder<AdventureWorksContext>()
//                  .UseSqlServer(connectionString)
//                  //.EnableSensitiveDataLogging()
//                  //.UseLoggerFactory(MyLoggerFactory)
//                  .UseLoggerFactory(loggerFactory) //Optional, this logs SQL generated by EF Core to the Console
//                  .Options;

AdventureWorksContextFactory adventureContext = new AdventureWorksContextFactory();
var dbContext = adventureContext.CreateDbContext(new string[] { });
var persions = await dbContext.People.ToListAsync();
Console.ReadKey(true);
public class AdventureWorksContextFactory : IDesignTimeDbContextFactory<AdventureWorks2019Context>
{
    public AdventureWorks2019Context CreateDbContext(string[] args)
    {
        var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

        IConfiguration configuration = builder.Build();

        var connectionString = configuration.GetConnectionString("Sqlserver");

        var optionsBuilder = new DbContextOptionsBuilder<AdventureWorks2019Context>();
        optionsBuilder.UseSqlServer(connectionString);

        return new AdventureWorks2019Context(optionsBuilder.Options);
    }
}