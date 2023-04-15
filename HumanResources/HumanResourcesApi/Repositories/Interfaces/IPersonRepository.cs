using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HumanResourcesApi.Entities;

namespace HumanResourcesApi.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();

        Person GetPerson(int personId, bool includeSkills);

        IEnumerable<Skill> GetSkills(int personId);

        Skill GetSkills(int personId, int skillId);

        bool PersonExists(int personId);

        void AddSkills(int personId, Skill skill);

        void UpdateSkill(int personId, Skill skill);

        void DeleteSkill(Skill pointOfInterest);

        bool Save();
    }
}
