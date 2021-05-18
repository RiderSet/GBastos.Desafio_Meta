using GBastos.Desafio_Meta.ApplicationCore.Models;
using GBastos.Desafio_Meta.ApplicationCore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Layer.Architecture.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmissoraController : Controller
    {
        private EmissoraService emissoraService;

        public EmissoraController(EmissoraService emService)
        {
            emissoraService = emService;
        }

        // GET: Emissora
        public Task<IEnumerable<Emissora>> Index()
        {
            return (Task<IEnumerable<Emissora>>)emissoraService.GetAll();
        }

        [HttpPost]
        public async Task<ActionResult<Emissora>> PostEmissora(Emissora emissora)
        {
            var emis = emissoraService.Get(x => x.Id == emissora.Id);
            if (emis != null)
            {
                return BadRequest("Emissora já existente.");
            }

            if (VerifyInput(emissora.Nome) == true)
            {
                throw new InvalidOperationException("Caracteres especiais detectados no nome da Emissora.");
            }

            emissoraService.Add(emissora);
            await emissoraService.Addasync(emissora);

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(Get), new { id = emissora.Id }, emissora);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmissora(int id)
        {

            var emissora = emissoraService.GetById(id);
            if (emissora == null)
            {
                return BadRequest();
            }
            try
            {
                await emissoraService.Addasync(emissora);
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return NotFound();

            Emissora emissora = emissoraService.GetById(id);
            Execute(() =>
            {
                emissoraService.Delete(emissora);
                return true;
            });

            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get(Expression<Func<Emissora, bool>> predicate)
        {
            return Execute(() => emissoraService.Get(predicate));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return Execute(() => emissoraService.GetById(id));
        }

        private IActionResult Execute(Func<object> func)
        {
            try
            {
                var result = func();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        private static bool VerifyInput(string strIn)
        {
            bool retorno = false;
            string pattern = @"(?i)[^0-9a-záéíóúàèìòùâêîôûãõç\s]";
            string[] input = strIn.Split();
            string []especiais = pattern.Split();

            foreach (var a in input)
            {
                foreach (var b in especiais)
                { 
                    if(a == b)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
    }
}