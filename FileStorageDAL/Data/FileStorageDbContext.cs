using FileStorageDAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileStorageDAL.Data
{
    public class FileStorageDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<UserRole> UserRoles { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<File> Files { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Folder> Folders { get; set; }

        public FileStorageDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-JIAU65U;Database=FileStorage;Trusted_Connection=True;");
        }

        public FileStorageDbContext(DbContextOptions<FileStorageDbContext> options) : base(options)
        {

        }
    }
}
