using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResourcesApi.Contexts;
using HumanResourcesApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace HumanResourcesApi.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly HumanResourcesContext _context;

        public PersonRepository(HumanResourcesContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }


        public IEnumerable<Person> GetPersons()
        {
            return _context.Persons.OrderBy(c => c.Name).ToList();
        }

        public Person GetPerson(int personId, bool includeSkills)
        {
            if (includeSkills)
            {
                return _context.Persons.Include(c => c.Skills)
                    .Where(c => c.Id == personId).FirstOrDefault();
            }

            return _context.Persons
                .Where(c => c.Id == personId).FirstOrDefault();
        }

        public IEnumerable<Skill> GetSkills(int personId)
        {
            return _context.Skills
                .Where(p => p.PersonId == personId).ToList();
        }

        public Skill GetSkills(int personId, int skillId)
        {
            return _context.Skills
                .Where(p => p.PersonId == personId && p.Id == skillId).FirstOrDefault();
        }

        public bool PersonExists(int personId)
        {
            return _context.Persons.Any(c => c.Id == personId);
        }

        public void AddSkills(int personId, Skill skill)
        {
            throw new NotImplementedException();
        }

        public void UpdateSkill(int personId, Skill skill)
        {
            throw new NotImplementedException();
        }

        public void DeleteSkill(Skill pointOfInterest)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
