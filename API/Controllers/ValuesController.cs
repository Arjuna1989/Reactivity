
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;
using MediatR;
using Application.Activities;

namespace API.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {
        private readonly DataContext _context;
        private readonly IMediator _mediator;
        public ValuesController (DataContext context, IMediator mediator) {
            _mediator = mediator;
            _context = context;

        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<Activity>>> Get () {
            // var values = await _context.Values.ToListAsync ();
            // return Ok (values);

              return await _mediator.Send(new List.Query());
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public async Task<ActionResult<Value>> Get (int id) {
            var value = await _context.Values.FindAsync (id);
            return Ok (value);
        }

        // POST api/values
        [HttpPost]
        public void Post ([FromBody] string value) { }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}