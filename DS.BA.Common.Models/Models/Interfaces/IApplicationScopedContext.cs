namespace DS.BA.Common.Models

/// <summary>
///     Various projects within this solution need to be able to pass around common
///     but agnostic information for standard operation.
///     For example: User - This is persisted with some datbase operations for tracabaility.
/// </summary>
public interface IApplicationScopedContext
{
    /// <summary>
    ///     Gets or sets the user or system running this context.
    /// </summary>
    string? User { get; set; }
}