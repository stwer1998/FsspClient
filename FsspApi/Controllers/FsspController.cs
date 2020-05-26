using FsspLibrary;
using Microsoft.AspNetCore.Mvc;

namespace FsspApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FsspController : ControllerBase
    {
        private FsspClient client;
        public FsspController(FsspClient client)
        {
            this.client = client;
        }

        [HttpGet]
        public FsspLibrary.Result[] Index(int code,string name,string lastname,string secondname)
        {
            var person = new PhysicalPerson() 
            {
                Region=code,
                Firsname=name,
                Lastname=lastname,
                Secondname=secondname
            };
            return client.GetInfoPhysical(person);
        }
    }
}
