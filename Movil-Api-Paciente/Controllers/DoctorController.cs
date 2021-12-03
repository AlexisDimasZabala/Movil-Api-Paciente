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
    public class DoctorController : Controller
    {
        private PacienARMovilContext db = new PacienARMovilContext();

        [HttpGet]
        public IActionResult ListarTodos()
        {

            List<Doctor> lista = db.Doctors.ToList();

            if (lista.Count == 0)
            {
                return NotFound();
            }

            return Ok(lista);
        }

        [HttpPost]
        public IActionResult AgregarDoctor([FromBody] Doctor doctor)
        {
            try
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
                return Ok(200);

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult IniciarSesion(string nombre, string contra)
        {
            try
            {
                Doctor doc = db.Doctors.FirstOrDefault(d => d.Nombre == nombre && d.Contra == contra);

                if (doc != null)
                {
                    return Ok(true);
                }
                else
                {
                    return NotFound(false);
                }

            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
