using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;

namespace DS.BA.Common.Models.Database.Entities;

/// <summary>
///     A way to categories expenditures
/// </summary>
[Table("Expenditure Types")]
public class ExpenditureTypesEntity : BaseEntity
{
    /// <summary>
    ///     The Name of the type
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    ///     Related expenditures
    /// </summary>
    public ICollection<ExpenditureEntity> Expenditures { get; set; } = [];

    /// <summary>
    ///     Connected family
    /// </summary>
    [Required]
    public Guid FamilyId { get; set; }

    /// <summary>
    ///     The connected family entity
    /// </summary>
    [ForeignKey("FamilyId")]
    public FamilyEntity Family {get;set;}
}