using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tenant.Profiles
{
    public class CustomerProfiles : AutoMapper.Profile
    {
        public CustomerProfiles()
        {
            CreateMap<Db.Customer, Model.Customer>();
        }
    }
}
