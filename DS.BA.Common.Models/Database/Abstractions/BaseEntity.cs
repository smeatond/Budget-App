using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Interfaces;

namespace DS.BA.Common.Models.Database.Abstractions;

public abstract class BaseEntity : IBaseEntity
{
    /// <inheritdoc />
    [Key]
    public Guid Id { get; set; }

    /// <inheritdoc />
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTimeOffset CreatedDate { get; set; }

    /// <inheritdoc />
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTimeOffset LastUpdatedDate { get; set; }

    /// <inheritdoc />
    public string? CreatedBy { get; set; }

    /// <inheritdoc />
    public string? LastUpdatedBy { get; set; }
}