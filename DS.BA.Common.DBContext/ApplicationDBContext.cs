using DS.BA.Common.DbContext;
using Microsoft.EntityFrameworkCore;

namespace DS.BA.Common.DBContext;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options,
    IApplicationScopedContext scopedContext)
    : Microsoft.EntityFrameworkCore.DbContext(options), IDbContext
{
}