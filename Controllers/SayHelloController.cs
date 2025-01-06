
using Microsoft.AspNetCore.Mvc;
namespace  BatresA.MC_1SayHello_Endpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
         public List<string> sayHello = new();
        string Hello = "Hello, ";

    // The constructor runs first when the api is called
    // Web API version of void start
        public SayHelloController()
        {
           
        }


        [HttpGet] //Use HttpPost for adding Information to the backend
        [Route("AddName/{name}")] //To pass data through our routes we add /{parameter
        public string GreetPerson(string name)
        {
        return Hello + name;
        }
    }
}
    
