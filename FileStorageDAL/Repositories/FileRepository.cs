using FileStorageDAL.Data;
using FileStorageDAL.Entity;
using FileStorageDAL.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStorageDAL.Repositories
{
    public class FileRepository : IFileRepository
    {
        private FileStorageDbContext _context;

        public FileRepository(FileStorageDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(File entity)
        {
            _context.Files.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async void Delete(File entity)
        {
            _context.Files.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            if (_context.Files.Where(r => r.Id == id).ToList().Count() > 0)
            {
                var deleteItem = _context.Files.Where(r => r.Id == id).ToList()[0];
                Delete(deleteItem);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<IEnumerable<File>> GetAllAsync()
        {
            IEnumerable<File> resIEnum = _context.Files;
            return Task.FromResult(resIEnum);
        }

        public Task<IEnumerable<File>> GetAllWithDetailsAsync()
        {
            IEnumerable<File> resIEnum = _context.Files.Include("Category");
            return Task.FromResult(resIEnum);
        }

        public Task<File> GetByIdAsync(int id)
        {
            File file = new File();
            if (_context.Files.Where(r => r.Id == id).ToList().Count > 0)
            {
                file = _context.Files.Where(r => r.Id == id).ToList()[0];
            }
            return Task.FromResult(file);
        }

        public Task<File> GetByIdWithDetailsAsync(int id)
        {
            File file = new File();
            if (_context.Files.Where(r => r.Id == id).ToList().Count > 0)
            {
                file = _context.Files.Include("Category").Where(r => r.Id == id).ToList()[0];
            }
            return Task.FromResult(file);
        }

        public void Update(File entity)
        {
            _context.Update(entity);
        }
    }
}
