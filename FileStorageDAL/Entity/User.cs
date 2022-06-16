using System;
using System.Collections.Generic;
using System.Text;

namespace FileStorageDAL.Entity
{
    public class User : BaseEntity
    {
        public int UserRoleId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public UserRole UserRole { get; set; }
        public IEnumerable<Folder> Folders { get; set; }
    }
}
