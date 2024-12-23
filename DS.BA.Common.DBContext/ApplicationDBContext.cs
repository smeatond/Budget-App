using DS.BA.Common.DbContext;
using DS.BA.Common.Models.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace DS.BA.Common.DBContext;

public class ApplicationDbContext(
    DbContextOptions<ApplicationDbContext> options,
    IApplicationScopedContext scopedContext)
    : Microsoft.EntityFrameworkCore.DbContext(options), IDbContext
{
    public DbSet<IncomeEntity> Incomes { get; set; }
    public DbSet<ExpenditureEntity> Expenditures { get; set; }
    public DbSet<BudgetEntity> Budgets { get; set; }
    public DbSet<ExpenditureTypesEntity> ExpenditureTypes { get; set; }
    public DbSet<MemberEntity> Members { get; set; }
    public DbSet<FamilyEntity> Families { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BudgetEntity>()
            .HasMany(b => b.Incomes)
            .WithMany(i => i.Budgets).UsingEntity<Dictionary<string, object>>("BudgetIncome",
            b => b.HasOne<IncomeEntity>().WithMany().HasForeignKey("IncomeId"),
            i => i.HasOne<BudgetEntity>().WithMany().HasForeignKey("BudgetId"));
        modelBuilder.Entity<BudgetEntity>()
            .HasMany(b => b.Expenditures)
            .WithMany(e => e.Budgets).UsingEntity<Dictionary<string, object>>("BudgetExpenditure",
                b => b.HasOne<ExpenditureEntity>().WithMany().HasForeignKey("ExpenditureId"),
                e => e.HasOne<BudgetEntity>().WithMany().HasForeignKey("BudgetId"));
        modelBuilder.Entity<ExpenditureEntity>()
            .HasMany(e => e.ExpenditureTypes)
            .WithMany(et => et.Expenditures).UsingEntity<Dictionary<string, object>>("ExpenditureExpenditureType",
                e => e.HasOne<ExpenditureTypesEntity>().WithMany().HasForeignKey("ExpenditureId"),
                et => et.HasOne<ExpenditureEntity>().WithMany().HasForeignKey("ExpenditureTypeId"));
    }
}