using Microsoft.AspNetCore.Mvc;
using Movil_Api_Paciente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movil_Api_Paciente.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PacienteController : Controller
    {
        private PacienARMovilContext db = new PacienARMovilContext();

        [HttpGet]
        public IActionResult ListarTodos()
        {

            List<Paciente> lista = db.Pacientes.ToList();

            if (lista.Count == 0)
            {
                return NotFound();
            }

            return Ok(lista);
        }

        [HttpGet]
        public IActionResult ListarActivos()//[FromQuery] string token)
        {

            // verificamos token valido de cliente
            /*if (!this.ValidarAuthorization())
            {
                return BadRequest();
            }*/

            List<Paciente> lista = db.Pacientes.Where(p => p.Activo == 1).ToList();

            if (lista.Count == 0)
            {
                return NotFound();
            }

            return Ok(lista);
        }

        /*[HttpGet]
        public IActionResult ListarFavoritos()
        {

            // verificamos token valido de cliente
            if (!this.ValidarAuthorization())
            {
                return BadRequest();
            }

            List<Paciente> lista = db.Pacientes.Where(p => p.Activo == 1).ToList();

            if (lista.Count == 0)
            {
                return NotFound();
            }

            return Ok(lista);
        }*/

        [HttpGet("{documento}")]
        public IActionResult ListarPorDocumento([FromRoute] string documento)
        {
            Paciente paciete = new Paciente();

            paciete = db.Pacientes.FirstOrDefault(d => d.Documento == documento);//db.Pacientes.//Find(id);

            if (paciete == null)
            {
                return NotFound();
            }

            return Ok(paciete);
        }

        [HttpPost]
        public IActionResult AgregarPaciente([FromBody] Paciente paciente)
        {

            try
            {
                db.Pacientes.Add(paciente);
                db.SaveChanges();
                return Ok(200);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult EditarPaciente([FromBody] Paciente paciente)
        {
            try
            {
                db.Update(paciente);

                db.SaveChanges();
                return Ok(200);
            }
            catch (System.Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpPut("{documento}")]
        public IActionResult Desactivar([FromRoute] string documento)
        {
            Paciente pac = new Paciente();

            pac = db.Pacientes.FirstOrDefault(p => p.Documento == documento); //.Where(p => p.Activo == 1);//Find(documento);

            try
            {
                pac.Activo = 0;
                db.Update(pac);
                db.SaveChanges();

            }
            catch (System.Exception)
            {
                return BadRequest();
            }

            return Ok(200);
        }

        [HttpPut("{documento}")]
        public IActionResult Activar([FromRoute] string documento)
        {
            Paciente pac = new Paciente();

            pac = db.Pacientes.FirstOrDefault(p => p.Documento == documento);//Find(documento);

            try
            {
                pac.Activo = 1;
                db.Update(pac);
                db.SaveChanges();

            }
            catch (System.Exception)
            {
                return BadRequest();
            }

            return Ok(200);
        }
    }
}
