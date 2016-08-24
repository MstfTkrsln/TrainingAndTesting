using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CitysApp.Controllers
{
    public class ValuesController : ApiController
    {
        public class Sehir
        {
            public int Id { get; set; }
            public string SehirAd { get; set; }
        }

        static List<Sehir> _sehirler = InitSehirler();

        private static List<Sehir> InitSehirler()
        {
            var returnList = new List<Sehir>();
            returnList.Add(new Sehir { Id = 0, SehirAd = "Afyonkarahisar" });
            returnList.Add(new Sehir { Id = 1, SehirAd = "Isparta" });
            returnList.Add(new Sehir { Id = 2, SehirAd = "İstanbul" });
            return returnList;
        }

        // GET api/values
        public IEnumerable<Sehir> Get()
        {
            return _sehirler;
        }

        // GET api/values/5
        public Sehir Get(int id)
        {
            return _sehirler.Where(x => x.Id == id).SingleOrDefault();
        }

        // POST api/values
        public void Post(Sehir value)
        {
            value.Id = _sehirler.Count;
            _sehirler.Add(value);
        }

        // PUT api/values/5
        public void Put(int id)
        { }

        // DELETE api/values/5
        public void Delete(int id)
        { }
    }
}