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
    public class AudienciaController : Controller
    {
        private AudienciaService audienciaService;
        private EmissoraService emissoraService;

        public AudienciaController(AudienciaService emAudiencia, EmissoraService emEmissora)
        {
            audienciaService = emAudiencia;
            emissoraService = emEmissora;
        }

        // GET: Audiencia
        public Task<IEnumerable<Audiencia>> Index()
        {
            return (Task<IEnumerable<Audiencia>>)audienciaService.GetAll();
        }

        [HttpGet("{emissora_Id}/{data_exibicao}")]
        public IActionResult GetAudienciasPorSomatorio(int emissora_Id, DateTime data_exibicao)
        {
            List<Audiencia> list = new List<Audiencia>();
            var emissora = emissoraService.GetById(emissora_Id);
            if (emissora == null)
            {
                return BadRequest("Emissora inexistete.");
            }

            long somatorio = 0;
            foreach (Audiencia audi in emissora.Audiencias)
            {
                int atual = audi.Id;
                while (audi.Id == atual)
                {
                    somatorio += audi.PtsAudiencia;
                }
                audi.PtsAudiencia = somatorio;
                list.Add(audi);
                somatorio = 0;
            }
            return (IActionResult)list;
        }

        [HttpGet("{emissora_Id}/{data_exibicao}")]
        public IActionResult GetAudienciasPorMédia(int emissora_Id, DateTime data_exibicao)
        {
            List<Audiencia> list = new List<Audiencia>();
            var emissora = emissoraService.GetById(emissora_Id);
            if (emissora == null)
            {
                return BadRequest("Emissora inexistete.");
            }

            long somatorio = 0; int contador = 0;
            foreach (Audiencia audi in emissora.Audiencias)
            {
                int atual = audi.Id;
                while (audi.Id == atual)
                {
                    somatorio += audi.PtsAudiencia;
                    contador += contador + 1;
                }
                audi.PtsAudiencia = somatorio / contador;
                list.Add(audi);
                somatorio = 0; contador = 0;
            }
            return (IActionResult)list;
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


        [HttpPost]
        public async Task<ActionResult<Audiencia>> PostAudiencia(Audiencia Audiencia)
        {
            Audiencia audi = (Audiencia)audienciaService.Get(x => x.Id == Audiencia.Id);
            if (audi != null)
            {
                var emissoras = emissoraService.GetAll();
                foreach (Emissora emis in emissoras)
                {
                    foreach (Audiencia audiEmis in emis.Audiencias)
                    {
                        if (audi.EmissoraId == audiEmis.Id)
                        {
                            if (audi.DtHrAudiencia == audiEmis.DtHrAudiencia)
                            {
                                return BadRequest("Audiencia já existente para a emissora " + emis.Nome + ".");
                            }
                        }
                    }
                }
            }

            audienciaService.Add(Audiencia);
            await audienciaService.Addasync(Audiencia);
            return CreatedAtAction(nameof(Get), new { id = Audiencia.Id }, Audiencia);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAudiencia(int id)
        {
            var Audiencia = audienciaService.GetById(id);
            if (Audiencia == null)
            {
                return BadRequest();
            }
            try
            {
                await audienciaService.Addasync(Audiencia);
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

            Audiencia audiencia = audienciaService.GetById(id);
            if (audiencia != null)
            {
                audienciaService.Delete(audiencia);
                return Ok();
            };
            return new NoContentResult();
        }

        [HttpGet]
        public IActionResult Get(Expression<Func<Audiencia, bool>> predicate)
        {
            return (IActionResult)audienciaService.Get(predicate);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0)
                return NotFound();

            return (IActionResult)audienciaService.GetById(id);
        }
    }
}