using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class UserInitializer : CreateDatabaseIfNotExists<UserContext>
    {
        public UserInitializer(UserContext context)
        {
            base.Seed(context);
        }
    }
}
