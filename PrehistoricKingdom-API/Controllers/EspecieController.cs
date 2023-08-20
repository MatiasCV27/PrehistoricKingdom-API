using PrehistoricKingdom_API.Data;
using PrehistoricKingdom_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PrehistoricKingdom_API.Controllers
{
    public class EspecieController : ApiController
    {
        // GET api/<controller>
        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        public List<Especie> Get()
        {
            return EspecieData.Listar();
        }

        // GET api/<controller>/5
        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        public Especie Get(int id)
        {
            return EspecieData.Obtener(id);
        }

        // POST api/<controller>
        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        public bool Post([FromBody] Especie oEspecie)
        {
            return EspecieData.Registrar(oEspecie);
        }

        // PUT api/<controller>/5
        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        public bool Put([FromBody] Especie oEspecie)
        {
            return EspecieData.Editar(oEspecie);
        }

        // DELETE api/<controller>/5
        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        public bool Delete(int id)
        {
            return EspecieData.Eliminar(id);
        }
    }
}
