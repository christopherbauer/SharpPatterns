using System;
using System.Collections.Generic;
using System.Web.Http;
using SharpPatterns.ViewModels;

namespace SharpPatterns.Controllers.api
{
    public class MementoApiController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(MementoViewModel mementoViewModel)
        {
            Console.WriteLine(mementoViewModel.ToString());
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}