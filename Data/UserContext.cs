using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Data
{
    public class UserContext : DbContext
    {
        public UserContext()
        : base("DbConnection")
        { Database.SetInitializer(new CreateDatabaseIfNotExists<UserContext>()); }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

    }
}
