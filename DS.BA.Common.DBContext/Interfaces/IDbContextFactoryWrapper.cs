using DS.BA.Common.DbContext;

namespace DS.BA.Common.DBContext.Interfaces;

/// <summary>
///     Primary application DBContextFactoryWrapper interface that should be injected via IDBContextWrapper to ensure testability and
///     maintainability. And used to created scoped instances of <seealso cref="IDbContext"/> to avoid concurrency and threading issues.
///     <remarks>We could look at creating a more generic version if we end up having multiple contexts. However, at this stage this is all that is required.</remarks>
/// </summary>
public interface IDbContextFactoryWrapper
{
    /// <summary>
    ///     Creates an instance of <seealso cref="IDbContext"/>.
    /// </summary>
    /// <returns>The IDbContext</returns>
    IDbContext CreateDbContext();
}