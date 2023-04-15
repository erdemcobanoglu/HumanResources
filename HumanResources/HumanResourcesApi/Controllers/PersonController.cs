using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HumanResourcesApi.Models;
using HumanResourcesApi.Repositories;

namespace HumanResourcesApi.Controllers
{
    // https://localhost:44341/api/persons
    [Route("api/persons")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonController(IPersonRepository personRepository,
            IMapper mapper)
        {
            _personRepository = personRepository ??
                                throw new ArgumentNullException(nameof(personRepository));
            _mapper = mapper ??
                      throw new ArgumentNullException(nameof(mapper));
        }

        // GET api/values
        [HttpGet]
        public IActionResult GetPersons()
        {
            var cityEntities = _personRepository.GetPersons();

            return Ok(_mapper.Map<IEnumerable<PersonWithoutSkillsDto>>(cityEntities));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
