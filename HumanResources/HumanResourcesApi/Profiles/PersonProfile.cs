using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace HumanResourcesApi.Profiles 
{
    public class PersonProfile :  AutoMapper.Profile
    {
        public PersonProfile()
        {
            CreateMap<Entities.Person, Models.PersonWithoutSkillsDto>();
            CreateMap<Entities.Person, Models.PersonDto>();
        }
    }
}
