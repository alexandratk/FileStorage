using FileStorageDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IFileRepository FileRepository { get; set; }

        public IFileCategoryRepository FileCategoryRepository { get; set; }

        public IUserRepository UserRepository { get; set; }

        public IUserRoleRepository UserRoleRepository { get; set; }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
