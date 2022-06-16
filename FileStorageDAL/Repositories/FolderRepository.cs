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
    public class FolderRepository : IFolderRepository
    {
        private FileStorageDbContext _context;

        public FolderRepository(FileStorageDbContext context)
        {
            _context = context;
        }

        public  async Task AddAsync(Folder entity)
        {
            _context.Folders.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async void Delete(Folder entity)
        {
            _context.Folders.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            if (_context.Folders.Where(r => r.Id == id).ToList().Count() > 0)
            {
                var deleteItem = _context.Folders.Where(r => r.Id == id).ToList()[0];
                Delete(deleteItem);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<IEnumerable<Folder>> GetAllAsync()
        {
            IEnumerable<Folder> resIEnum = _context.Folders;
            return Task.FromResult(resIEnum);
        }

        public Task<IEnumerable<Folder>> GetAllWithDetailsAsync()
        {
            IEnumerable<Folder> resIEnum = _context.Folders.Include("FolderParent").Include("Files").ToList();
            return Task.FromResult(resIEnum);
        }

        public Task<Folder> GetByIdAsync(int id)
        {
            Folder folder = new Folder();
            if (_context.Folders.Where(r => r.Id == id).ToList().Count > 0)
            {
                folder = _context.Folders.Where(r => r.Id == id).ToList()[0];
            }
            return Task.FromResult(folder);
        }

        public Task<Folder> GetByIdWithDetailsAsync(int id)
        {
            Folder folder = new Folder();
            if (_context.Folders.Where(r => r.Id == id).ToList().Count > 0)
            {
                folder = _context.Folders.Where(r => r.Id == id).Include("FolderParent")
                    .Include("Files").ToList()[0];
            }
            return Task.FromResult(folder);
        }

        public void Update(Folder entity)
        {
            _context.Update(entity);
        }
    }
}
