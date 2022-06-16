using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FileStorageDAL.Entity
{
    public class Folder : BaseEntity
    {
        public int UserId { get; set; }

        public string FolderName { get; set; }


        public User User { get; set; }
        public IEnumerable<File> Files { get; set; }

        public int? FolderParentId { get; set; }
        public Folder FolderParent { get; set; }

        //public IEnumerable<Folder> ParentChildren { get; set; }
    }
}
