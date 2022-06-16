using System;
using System.Collections.Generic;
using System.Text;

namespace FileStorageDAL.Entity
{
    public class UserRole : BaseEntity 
    {
        public string Role { get; set; }

        public IEnumerable<User> Users { get; set; }
    }
}
