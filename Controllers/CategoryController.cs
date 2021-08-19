using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testeff.Data;
using testeff.Models;

namespace testeff.Controllers
{
    [ApiController]
    [Route("v1/categories")]

    public class CategoryController : ControllerBase
    {
      [HttpGet]
      [Route("")]
      public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
      {
        var categories = await context.Categorias.ToListAsync();
        return categories;
      }

      [HttpPost]
      [Route("")]
      public async Task<ActionResult<Category>> Post(
        [FromServices] DataContext context,
        [FromBody]Category model)
      {
        if (ModelState.IsValid)
        {
          context.Categorias.Add(model);
          await context.SaveChangesAsync();
          return model;
        }
        else
        {
          return BadRequest(ModelState);
        }
      }
      
    }
}