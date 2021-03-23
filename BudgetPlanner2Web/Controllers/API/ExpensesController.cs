using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgetPlanner2Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using BudgetPlanner2Web.Services;
using BudgetPlanner2Web.Models.DTO;
using Microsoft.AspNetCore.Http;

namespace BudgetPlanner2Web.Controllers.API
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ExpensesController : ControllerBase
    {
        
        private readonly IExpenseRepository _expenseRepository;

        public ExpensesController(IExpenseRepository expRepo)
        {
            _expenseRepository = expRepo;
        }

        /// <summary>
        /// Gets all expenses
        /// </summary>
        /// <param name="CategoryId">Category ID to filter results</param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET: /api/Expenses
        ///     GET: /api/Expenses?CategoryId=5
        ///     
        /// </remarks>
        /// <response code="200">Returns the list of expenses</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses([FromQuery]int? CategoryId = null)
        {
            if (CategoryId != null)
            {
                var expenses = await _expenseRepository.GetByCategoryIdAsync(CategoryId.Value);
                return expenses.ToList();
            }
            return (await _expenseRepository.GetAllAsync()).ToList();
        }

        /// <summary>
        /// Gets a specific expense
        /// </summary>
        /// /// <remarks>
        /// Sample request:
        /// 
        ///     GET: /api/Expenses/5
        ///     
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        /// <response code="200">Returns the expense item</response>
        /// <response code="404">If the expense is not found</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {
            var expense = await _expenseRepository.GetByIdAsync(id);
            if (expense == null)
            {
                return NotFound();
            }

            return expense;
        }

        /// <summary>
        /// Updates specific expense
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     
        ///     PUT: /api/Expenses/5
        ///     {
        ///         "id": 5,
        ///         "comment": "new comment",
        ///         "date": "2021-03-21T16:37:15.384Z",
        ///         "categoryid": 10,
        ///         "amount": 200
        ///     }
        /// 
        /// `id` and `CategoryId` fields are required, others are optional
        /// </remarks>
        /// <response code="400">If invalid data has been sent</response>
        /// <response code="200">If the expense has been updated</response>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(int id, UpdateExpenseDTO expense)
        {
            if (id != expense.Id)
            {
                return BadRequest();
            }

            if(await _expenseRepository.UpdateAsync(BaseEntity.CreateFrom<Expense>(expense)))
            {
                await _expenseRepository.SaveAsync();
                return Ok();
            }

            return BadRequest();
        }

        /// <summary>
        /// Creates an expense
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     POST: /api/Expenses
        ///     {
        ///         "amount": 20,
        ///         "date": "2021-03-21T16:37:15.384Z",
        ///         "comment": "hello world",
        ///         "categoryid": 21
        ///     }
        ///     
        /// `All` fields are required
        /// </remarks>
        /// <response code="201">If the expense has been created succesfully</response>
        /// <response code="400">If invalid data has been passed</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Expense>> PostExpense(ExpenseDTO expense)
        {
            var item = await _expenseRepository.AddAsync(BaseEntity.CreateFrom<Expense>(expense));
            if (item != null)
            {
                await _expenseRepository.SaveAsync();
                return CreatedAtAction("GetExpense", new { id = item.Id }, item);
            }
            return BadRequest();
        }

        /// <summary>
        /// Deletes a specific expense
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     
        ///     DELETE: /api/Expenses/5
        ///     
        /// </remarks>
        /// <response code="200">If the expense has been deleted</response>
        /// <response code="400">Bad request</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> DeleteExpense(int id)
        {
            if(await _expenseRepository.DeleteAsync(id))
            {
                await _expenseRepository.SaveAsync();
                return Ok("Expense deleted");
            }
            return BadRequest();
        }
    }
}
