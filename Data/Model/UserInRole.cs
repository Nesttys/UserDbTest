﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class UserInRole
    {
        public int UserInRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime HireDate { get; set; }
    }
}