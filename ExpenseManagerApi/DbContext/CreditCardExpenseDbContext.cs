using Microsoft.EntityFrameworkCore;

public class CreditCardExpenseDbContext(DbContextOptions<CreditCardExpenseDbContext> options) : DbContext(options)  
{
    public DbSet<CreditCardExpense> CreditCardExpenses { get; set; }
}