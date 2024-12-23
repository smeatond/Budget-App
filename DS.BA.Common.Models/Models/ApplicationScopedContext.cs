namespace DS.BA.Common.Models.Models;

public class ApplicationScopedContext : IApplicationScopedContext
{
    public string? User { get; set; }

    public string? Auth0Id { get; set; }
}