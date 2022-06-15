using System;
using System.Collections.Generic;
using System.Text;

namespace FileStorageDAL.Entity
{
    public class File : BaseEntity
    {
        public string FileName { get; set; }
        public string Extension { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int FileCategoryId { get; set; }
        public byte[] Data { get; set; }

        public FileCategory Category { get; set; }
    }
}
