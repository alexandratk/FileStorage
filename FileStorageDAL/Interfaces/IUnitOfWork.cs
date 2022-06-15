using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Interfaces
{
    public interface IUnitOfWork
    {
        IFileRepository FileRepository { get; }

        IFileCategoryRepository FileCategoryRepository { get; }

        IUserRepository UserRepository { get; }

        IUserRoleRepository UserRoleRepository { get; }

        Task SaveAsync();
    }
}
