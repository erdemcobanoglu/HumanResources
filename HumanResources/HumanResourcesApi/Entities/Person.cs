using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResourcesApi.Entities
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string EMail { get; set; }
        [MaxLength(50)]
        public string PhoneNumber { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
         
        // Is Arıyor mu 
        public bool OpenToWork { get; set; }

        [MaxLength(50)] // buraya mülakat statüsü gelecek
        public string Status { get; set; }

        [MaxLength(50)] // buraya mülakat statüsü gelecek
        public string FirmName { get; set; }


        public ICollection<Skill> Skills { get; set; }
            = new List<Skill>();
    }
}
