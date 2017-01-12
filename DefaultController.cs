using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pr2.Controllers
{
    using System.Threading.Tasks;

    public class DefaultController : ApiController
    {
        private readonly IFoo foo;

        public DefaultController(IFoo foo)
        {
            this.foo = foo;
        }

        // GET: api/Default
        public async Task<string[]> Get()
        {
            await Task.Delay(10);

            return new string[] { "value1", "value2" };
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Default
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
        }
    }
}
