using System;
using System.Collections.Generic;
using System.Text;

namespace FileStorageDAL.Entity
{
    public class File : BaseEntity
    {
        public int FolderId { get; set; }

        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public byte[] Data { get; set; }

        public Folder Folder { get; set; }
    }
}
