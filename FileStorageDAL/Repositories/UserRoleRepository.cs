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
    public class UserRoleRepository : IUserRoleRepository
    {
        private FileStorageDbContext _context;

        public UserRoleRepository(FileStorageDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(UserRole entity)
        {
            _context.UserRoles.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async void Delete(UserRole entity)
        {
            _context.UserRoles.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public Task DeleteByIdAsync(int id)
        {
            if (_context.UserRoles.Where(r => r.Id == id).ToList().Count() > 0)
            {
                var deleteItem = _context.UserRoles.Where(r => r.Id == id).ToList()[0];
                Delete(deleteItem);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<IEnumerable<UserRole>> GetAllAsync()
        {
            IEnumerable<UserRole> resIEnum = _context.UserRoles;
            return Task.FromResult(resIEnum);
        }

        public Task<UserRole> GetByIdAsync(int id)
        {
            UserRole userRole = new UserRole();
            if (_context.UserRoles.Where(r => r.Id == id).ToList().Count > 0)
            {
                userRole = _context.UserRoles.Where(r => r.Id == id).ToList()[0];
            }
            return Task.FromResult(userRole);
        }

        public void Update(UserRole entity)
        {
            _context.Update(entity);
        }
    }
}
