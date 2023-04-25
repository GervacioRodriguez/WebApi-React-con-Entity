using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tecnica.Models;
using tecnica.Data;

namespace tecnica.Controllers
{
    public class EstudiantesController : ApiController
    {
        // GET api/<controller>
        public List<Estudiante> Get()
        {
            return Estudiantecs.Listar();
        }

        // GET api/<controller>/5
        public Estudiante Get(int id)
        {
            return Estudiantecs.Obtener(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Estudiante Oestudiante)
        {
            return Estudiantecs.Registrar(Oestudiante);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Estudiante Oestudiante)
        {
            return Estudiantecs.Modificar(Oestudiante);

        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}