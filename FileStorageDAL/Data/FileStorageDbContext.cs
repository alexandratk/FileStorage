using FileStorageDAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileStorageDAL.Data
{
    public class FileStorageDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<FileCategory> FileCategories { get; set; }

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
