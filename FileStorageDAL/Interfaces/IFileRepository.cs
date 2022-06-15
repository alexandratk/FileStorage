using FileStorageDAL.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Interfaces
{
    public interface IFileRepository : IRepository<File>
    {
        Task<IEnumerable<File>> GetAllWithDetailsAsync();

        Task<File> GetByIdWithDetailsAsync(int id);
    }
}
