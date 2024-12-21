using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DS.BA.Common.DbContext;

/// <summary>
///     Primary application DBContext interface that should be injected via IDBContext to ensure testability and
///     maintainability.
///     <remarks>
///         The following guidelines should be followed when using this database context to ensure maintainability,
///         extensibility, flexibility and testability<br />
///         1. Inject this db context via the interface <seealso cref="IDbContext" /> to allow us to abstract away from the
///         concrete implementation.<br />
///         2. Use repository pattern where possible to allow us to separate the logic that retrieves the data from the
///         database from the data query structures
///     </remarks>
/// </summary>
public interface IDbContext : IDisposable, IAsyncDisposable
{

    /// <inheritdoc cref="DbContext.SaveChanges()" />
    /// <summary>
    ///     Additionally, checks entity interface and updates audit properties.
    /// </summary>
    int SaveChanges();

    /// <inheritdoc cref="DbContext.SaveChanges(bool)" />
    /// <summary>
    ///     Additionally, checks entity interface and updates audit properties.
    /// </summary>
    int SaveChanges(bool acceptAllChangesOnSuccess);

    /// <inheritdoc cref="DbContext.SaveChangesAsync(CancellationToken)" />
    /// <summary>
    ///     Additionally, checks entity interface and updates audit properties.
    /// </summary>
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    /// <inheritdoc cref="DbContext.SaveChangesAsync(bool, CancellationToken)" />
    /// <summary>
    ///     Additionally, checks entity interface and updates audit properties.
    /// </summary>
    Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default);

}