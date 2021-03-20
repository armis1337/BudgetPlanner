using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using BudgetPlanner2Web.Services;

namespace BudgetPlanner2Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ExpensesController : ControllerBase
    {
        
        private readonly IExpenseRepository _expenseRepository;

        public ExpensesController(IExpenseRepository expRepo)
        {
            _expenseRepository = expRepo;
        }

        // GET: api/Expenses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses()
        {
            return (await _expenseRepository.GetAll()).ToList();
        }

        // GET: api/Expenses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {
            var expense = await _expenseRepository.GetById(id);
            if (expense == null)
            {
                return NotFound();
            }

            return expense;
        }

        // PUT: api/Expenses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(int id, [Bind("Id,Amount,Date,Comment,CategoryId")] Expense expense)
        {

            var test = expense;
            if (id != expense.Id)
            {
                return BadRequest();
            }

            if(await _expenseRepository.Update(expense))
            {
                await _expenseRepository.Save();
                return Ok();
            }

            return BadRequest();
        }

        // POST: api/Expenses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Expense>> PostExpense(Expense expense)
        {
            if (_expenseRepository.Add(expense))
            {
                await _expenseRepository.Save();
                return CreatedAtAction("GetExpense", new { id = expense.Id }, expense);
            }
            return BadRequest();
        }

        // DELETE: api/Expenses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpense(int id)
        {
            if(await _expenseRepository.Delete(id))
            {
                await _expenseRepository.Save();
                return Ok("Expense deleted");
            }
            return BadRequest();
        }
    }
}
