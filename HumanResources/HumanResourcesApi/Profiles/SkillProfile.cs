using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourcesApi.Profile
{
    public class SkillProfile :AutoMapper.Profile
    {
        public SkillProfile()
        {
            CreateMap<Entities.Person, Models.PersonDto>();
            //CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterest>();
            //CreateMap<Models.PointOfInterestForUpdateDto, Entities.PointOfInterest>()
            //    .ReverseMap();
        }
    }
}
