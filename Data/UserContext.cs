using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Data
{
    class UserContext : DbContext
    {
        public UserContext()
        : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserInRole> UserInRoles { get; set; }

    }
}
