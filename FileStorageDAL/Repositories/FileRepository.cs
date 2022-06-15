using FileStorageDAL.Entity;
using FileStorageDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Repositories
{
    public class FileRepository : IFileRepository
    {
        public Task AddAsync(File entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(File entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<File>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<File>> GetAllWithDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<File> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<File> GetByIdWithDetailsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(File entity)
        {
            throw new NotImplementedException();
        }
    }
}
