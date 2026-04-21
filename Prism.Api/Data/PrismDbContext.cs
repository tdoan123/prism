
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace Prism.Api.Data;

public class PrismDbContext : DbContext
{
    public PrismDbContext(DbContextOptions<PrismDbContext> options) : base(options)
    {

    }
}

