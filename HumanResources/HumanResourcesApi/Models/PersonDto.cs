using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourcesApi.Models
{
    public class PersonDto
    { 
        public int Id { get; set; }
        
        public string Name { get; set; }
         
        public string EMail { get; set; }
        
        public string PhoneNumber { get; set; }
         
        public string Description { get; set; }
         
        public bool OpenToWork { get; set; }
         
        public string Status { get; set; }
         
        public string FirmName { get; set; }

        public int NumberOfSkills
        {
            get
            {
                return Skills.Count;
            }
        }

        public ICollection<SkillDto> Skills { get; set; }
            = new List<SkillDto>();
    }
}
