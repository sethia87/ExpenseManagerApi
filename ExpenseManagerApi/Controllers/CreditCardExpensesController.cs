using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExpenseManagerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardExpensesController(CreditCardExpenseDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CreditCardExpense>>> GetCreditCardExpenses()
        {
            return await context.CreditCardExpenses.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<CreditCardExpense>> PostCreditCardExpense([FromBody] List<CreditCardExpense> expenses)
        {
            if (expenses == null || expenses.Count == 0)
            {
                return BadRequest();
            }

            foreach (var expense in expenses)
            {
                if (expense.Id == 0)
                {
                    context.CreditCardExpenses.Add(expense);
                }
                else
                {
                    context.CreditCardExpenses.Update(expense);
                }
            }

            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
