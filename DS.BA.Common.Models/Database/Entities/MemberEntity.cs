using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;
using DS.BA.Common.Models.Models.Enums;

namespace DS.BA.Common.Models.Database.Entities;

/// <summary>
///     Represents member entity
/// </summary>
[Table("Members")]
public class MemberEntity : BaseEntity
{
    /// <summary>
    ///     Members first name
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    ///     Memebers Last name
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    ///     Members email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    ///     Auth0 Id
    /// </summary>
    [Required]
    public string? Auth0Id { get; set; }

    /// <summary>
    ///     The Role of the member
    /// </summary>
    [Required]
    public RoleType Role { get; set; }

    /// <summary>
    ///     Connected family
    /// </summary>
    public Guid FamilyId { get; set; }

    /// <summary>
    ///     The connected family entity
    /// </summary>
    [ForeignKey("FamilyId")]
    public FamilyEntity Family {get;set;}

    /// <summary>
    ///     The date the member joined
    /// </summary>
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTimeOffset JoinedDate { get; set; }

}