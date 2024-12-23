using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using DS.BA.Common.Models.Database.Abstractions;

namespace DS.BA.Common.Models.Database.Entities;

/// <summary>
///     Represents the family entity
/// </summary>
[Table("Families")]
public class FamilyEntity : BaseEntity
{
    /// <summary>
    ///     The family budgets
    /// </summary>
    public ICollection<BudgetEntity> Budgets { get; set; }

    /// <summary>
    ///     The family members
    /// </summary>
    public ICollection<MemberEntity> Members { get; set; }

    /// <summary>
    ///     The family expenditures
    /// </summary>
    public ICollection<ExpenditureEntity> Expenditures { get; set; }

    /// <summary>
    ///     The famly incomes
    /// </summary>
    public ICollection<IncomeEntity> Incomes { get; set; }

    /// <summary>
    ///     The family expenditure types
    /// </summary>
    public ICollection<ExpenditureTypesEntity> ExpenditureTypes { get; set; }
}