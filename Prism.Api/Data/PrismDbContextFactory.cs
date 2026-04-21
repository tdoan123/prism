using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Prism.Api.Data;

public class PrismDbContextFactory : IDesignTimeDbContextFactory<PrismDbContext>
{
    public PrismDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddUserSecrets<PrismDbContextFactory>()
            .Build();

        var connectionString = configuration.GetConnectionString("prism");

        var optionsBuilder = new DbContextOptionsBuilder<PrismDbContext>();
        optionsBuilder.UseNpgsql(connectionString);

        return new PrismDbContext(optionsBuilder.Options);
    }
}