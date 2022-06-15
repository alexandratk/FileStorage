using FileStorageDAL.Data;
using FileStorageDAL.Entity;
using FileStorageDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Repositories
{
    public class FileCategoryRepository : IFileCategoryRepository
    {
        private FileStorageDbContext _context;

        public FileCategoryRepository(FileStorageDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(FileCategory entity)
        {
            _context.FileCategories.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async void Delete(FileCategory entity)
        {
            _context.FileCategories.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            if (_context.FileCategories.Where(r => r.Id == id).ToList().Count() > 0)
            {
                var deleteItem = _context.FileCategories.Where(r => r.Id == id).ToList()[0];
                Delete(deleteItem);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<IEnumerable<FileCategory>> GetAllAsync()
        {
            IEnumerable<FileCategory> resIEnum = _context.FileCategories;
            return Task.FromResult(resIEnum);
        }

        public Task<FileCategory> GetByIdAsync(int id)
        {
            FileCategory fileCategory = new FileCategory();
            if (_context.FileCategories.Where(r => r.Id == id).ToList().Count > 0)
            {
                fileCategory = _context.FileCategories.Where(r => r.Id == id).ToList()[0];
            }
            return Task.FromResult(fileCategory);
        }

        public void Update(FileCategory entity)
        {
            _context.Update(entity);
        }
    }
}
