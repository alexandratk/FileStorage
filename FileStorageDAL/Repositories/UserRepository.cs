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
    public class UserRepository : IUserRepository
    {
        private FileStorageDbContext _context;

        public UserRepository(FileStorageDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            _context.Users.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async void Delete(User entity)
        {
            _context.Users.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            if (_context.Users.Where(r => r.Id == id).ToList().Count() > 0)
            {
                var deleteItem = _context.Users.Where(r => r.Id == id).ToList()[0];
                Delete(deleteItem);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            IEnumerable<User> resIEnum = _context.Users;
            return Task.FromResult(resIEnum);
        }

        public Task<IEnumerable<User>> GetAllWithDetailsAsync()
        {
            IEnumerable<User> resIEnum = _context.Users.Include("UserRole").Include("Folders").ToList();
            return Task.FromResult(resIEnum);
        }

        public Task<User> GetByIdAsync(int id)
        {
            User user = new User();
            if (_context.Users.Where(r => r.Id == id).ToList().Count > 0)
            {
                user = _context.Users.Where(r => r.Id == id).ToList()[0];
            }
            return Task.FromResult(user);
        }

        public Task<User> GetByIdWithDetailsAsync(int id)
        {
            User user = new User();
            if (_context.Users.Where(r => r.Id == id).ToList().Count > 0)
            {
                user = _context.Users.Include("UserRole").Include("Folders").Where(r => r.Id == id).ToList()[0];
            }
            return Task.FromResult(user);
        }

        public void Update(User entity)
        {
            _context.Update(entity);
        }
    }
}
