public class CreditCardExpense
{
    public int Id { get; set; }

    public required string CardName { get; set; }

    public DateTime DueDate { get; set; } 

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal Amount { get; set; }
}
