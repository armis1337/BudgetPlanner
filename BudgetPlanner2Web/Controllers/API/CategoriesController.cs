using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BudgetPlanner2Web.Models;
using BudgetPlanner2Web.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using BudgetPlanner2Web.Models.DTO;
using Microsoft.AspNetCore.Http;

namespace BudgetPlanner2Web.Controllers.API
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoriesController(ICategoryRepository catRepo)
        {
            _categoryRepository = catRepo;
        }

        /// <summary>
        /// Gets all categories
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET: /api/Categories
        ///     
        /// </remarks>
        /// <returns>IEnumerable&lt;Category&gt;</returns>
        /// <response code="200">Returns the list of expenses</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return (await _categoryRepository.GetAllAsync()).ToList();
        }

        /// <summary>
        /// Gets a specific category
        /// </summary>
        /// <param name="id">id of category</param>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET: /api/Categories/5
        ///     
        /// </remarks>
        /// <returns>Category</returns>
        /// <response code="200">Returns the category</response>
        /// <response code="404">If the category is not found</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        /// <summary>
        /// Updates specific category
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     PUT: /api/Categories/5
        ///     {
        ///         "id": 5,
        ///         "name": "shopping",
        ///         "description": "shopping expenses",
        ///         "budget": 2000
        ///     }
        ///     
        /// `id` field is required, others are optional
        /// </remarks>
        /// <response code="200">If the category has been updated succesfully</response>
        /// <Response code="400">If invalid data has been passed</Response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, UpdateCategoryDTO category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            if (await _categoryRepository.UpdateAsync(BaseEntity.CreateFrom<Category>(category)))
            {
                await _categoryRepository.SaveAsync();
                return Ok();
            }

            return BadRequest();
        }

        /// <summary>
        /// Creates a category
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     
        ///     POST: /api/Categories
        ///     {
        ///         "name": "shopping",
        ///         "description": "shopping expenses",
        ///         "budget": 750
        ///     }
        /// 
        /// `name` field is required, otgers are optional
        /// </remarks>
        /// <response code="201">If category has been created</response>
        /// <response code="400">Invalid data has been passed</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(CategoryDTO category)
        {
            var item = _categoryRepository.AddAsync(BaseEntity.CreateFrom<Category>(category));
            if (item != null)
            {
                await _categoryRepository.SaveAsync();
                return CreatedAtAction("GetCategory", new { id = item.Id }, item);
            }
            return BadRequest();
        }

        // DELETE: api/Categories/5
        /// <summary>
        /// Deletes a category
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     
        ///     DELETE: /api/Categories/5
        ///     
        /// </remarks>
        /// <response code="200">If category has been succesfully deleted</response>
        /// <response code="400">Bad request</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            if (await _categoryRepository.DeleteAsync(id))
            {
                await _categoryRepository.SaveAsync();
                return Ok("Category deleted");
            }
            return BadRequest();
        }
    }
}
