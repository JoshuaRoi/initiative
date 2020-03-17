using System.Web.Http;
using System.Web.Http.Cors;

namespace initiative.sso.api.Controllers
{
  
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //[RoutePrefix("api/test")]
    public class TestController : ApiController
    {
       
        // GET: api/Test
        public string Get()
        {
            return "Success";
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return "value";
        }

    }
}
