using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testeef.Data;
using LinxApi.Models;

namespace testeef.Controllers
{
    [ApiController]
    [Route("P1/Produtos")]

    public class ControleProduto : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<ProdutoImportado>>> Get([FromServices] DataContext context)
        {
            var produto = await context.Produtos.ToListAsync();
            return produto;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<ProdutoImportado>> Post(
            [FromServices] DataContext context,
            [FromBody] ProdutoImportado model)
            {
                if(ModelState.IsValid)
                {
                    context.Produtos.Add(model);
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