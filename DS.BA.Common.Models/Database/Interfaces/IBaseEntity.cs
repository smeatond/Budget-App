namespace DS.BA.Common.Models.Database.Interfaces;

public interface IBaseEntity
{
    /// <summary>
    ///  The primary identification of the entity
    /// </summary>
     Guid Id { get; set; }

    /// <summary>
    ///     Gets or sets the Date time offset the entity was created
    ///     including timezone information.
    ///     This is a required property and must be populated with the
    ///     date time of the created
    /// </summary>
     DateTimeOffset CreatedDate { get; set; }

    /// <summary>
    ///     Gets or sets the entity last updated date as a date time offset
    ///     including timezone information.
    /// </summary>
     DateTimeOffset LastUpdatedDate { get; set; }

    /// <summary>
    ///     Gets or sets the entity created by
    /// </summary>
     string? CreatedBy { get; set; }

    /// <summary>
    ///     Gets or sets the last updated by for the entity
    /// </summary>
     string? LastUpdatedBy { get; set; }
}