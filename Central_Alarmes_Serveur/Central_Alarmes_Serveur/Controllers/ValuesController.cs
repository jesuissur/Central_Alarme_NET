using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Central_Alarmes_Serveur.Controllers
{
    public class ValuesController : ApiController
    {

        private Dictionary<int, string> _values = new Dictionary<int, string>() {{1, "value111"}, {2, "value222"}}; 

        // GET api/values
        public IEnumerable<string> Get()
        {
            return _values.Values.ToList();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        //public void Post([FromBody]string value)
        //{
        //    _values.Add(_values.Keys.Max() + 1, value);
        //}

        public HttpResponseMessage Post(UnCertainType certainType)
        {
            var reponse = Request.CreateResponse(HttpStatusCode.Created, certainType);

            //string uri = Url.Link("DefaultApi", new { id = certainType.Valeur1 });
            //reponse.Headers.Location = new Uri(uri);
            return reponse;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            _values[id] = value;
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _values.Remove(id);
        }
    }

   
    public class UnCertainType
    {
        public int Valeur1  { get; set; }
        public string Valeur2 { get; set; }
    }
}