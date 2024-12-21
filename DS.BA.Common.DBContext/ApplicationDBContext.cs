using DS.BA.Common.DbContext;
using Microsoft.EntityFrameworkCore;

namespace DS.BA.Common.DBContext;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options,
    IApplicationScopedContext scopedContext)
    : Microsoft.EntityFrameworkCore.DbContext(options), IDbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.Use(
            @"Server=(localdb)\mssqllocaldb;Database=Test;ConnectRetryCount=0");
    }
}