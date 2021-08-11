using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Vaccines;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccineController : ControllerBase
    {
        private readonly IMediator mediator;

        public VaccineController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]

        public async Task<ActionResult<List<Vaccine>>> List()
        {
            return await this.mediator.Send(new List.Query());
        }

        [HttpPost]

        public async Task<ActionResult<Unit>> Create(Create.Command command){
            
            return await mediator.Send(command);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Unit>> Edit(int id,Edit.Command command){
            command.VaccineId=id;
            return await mediator.Send(command);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Unit>> Delete(int id){
            
            return await mediator.Send(new Delete.Command{VaccineId=id});
        }
    }
}