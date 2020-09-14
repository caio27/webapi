using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{

    // decorate the class
    // gives out of the box behaviors to your class
    //[ApiController]
    
    // gives us a kind of base route
    // if class name is changed, the placeholder gets updated automatically
    // api/commands
    //[Route("api/[controller]")]

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {

        // use a MockRepository class to return data back to your application
        // create an instance of MockCommanderRepo 
        private readonly MockCommanderRepo _repository = new MockCommanderRepo();

        // lets create our first action result endpoint
        // GET resources
        // example: api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            // create var to hold results
            // use the repository
            var commandItems = _repository.GetAppCommands();
            
            // return list of commands back and status 200 OK
            return Ok(commandItems);
        }

        // return a single result
        // example: GET api/command/5
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}