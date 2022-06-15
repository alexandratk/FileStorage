using FileStorageDAL.Entity;
using FileStorageDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Repositories
{
    public class FileCategoryRepository : IFileCategoryRepository
    {
        public Task AddAsync(FileCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(FileCategory entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FileCategory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<FileCategory> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(FileCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
