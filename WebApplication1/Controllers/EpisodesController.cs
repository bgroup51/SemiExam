using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Models
{
    public class EpisodesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<String> Get()
        {
            Episode ep = new Episode();
            List<Episode> epList = ep.Get();
            List<String> serList = new List<String>();
            if (epList != null) {
                foreach (Episode e in epList)
                {
                    if (!serList.Contains(e.SerName)) serList.Add(e.SerName);
                }
            }
            return serList;
        }
        
        // GET api/<controller>/5
        public IEnumerable<Episode> Get(string serName)
        {
            Episode ep = new Episode();
            List<Episode> epList = ep.Get(serName);
            return epList;
        }

        // POST api/<controller>
        public int Post([FromBody] Episode ep)
        {
            ep.Insert();
            return 1;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}