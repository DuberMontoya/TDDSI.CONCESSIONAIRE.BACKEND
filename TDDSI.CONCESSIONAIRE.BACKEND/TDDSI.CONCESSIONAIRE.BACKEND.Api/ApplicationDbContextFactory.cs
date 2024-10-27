﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TDDSI.CONCESSIONAIRE.BACKEND.Infrastructure.PostgreSql.Persistence;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Api;
public class PersistenceContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext> {
    public ApplicationDbContext CreateDbContext( string[] args ) {
        IConfigurationRoot Config = new ConfigurationBuilder()
           .SetBasePath( Directory.GetCurrentDirectory() )
           .AddJsonFile( "appsettings.json" )
           .Build();

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        string database = Config.GetConnectionString( "ConnectionString" ) ?? string.Empty;
        optionsBuilder.UseNpgsql( database, sqlopts => {
            sqlopts.MigrationsHistoryTable( "_MigrationHistory" );
        } );

        return new ApplicationDbContext( optionsBuilder.Options, Config );
    }
}
