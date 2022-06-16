using FileStorageDAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Interfaces
{
    public interface IFolderRepository : IRepository<Folder>
    {
        Task<IEnumerable<Folder>> GetAllWithDetailsAsync();

        Task<Folder> GetByIdWithDetailsAsync(int id);
    }
}
