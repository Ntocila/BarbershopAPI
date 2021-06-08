using Deus_DataAccessLayer.Data;
using Deus_DataAccessLayer.IRepositories;
using Deus_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deus_DataAccessLayer.Services
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ApplicationDbContext _db;

        public ServiceRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IList<Service>> GetAll()
        {
            List<Service> services = await _db.Services.ToListAsync();
            return services;
        }

        public async Task<Service> GetById(int id)
        {
            var service = await _db.Services.FindAsync(id);
            return service;
        }
        public async Task<Service> CreateUpdate(Service entity)
        {
            if (entity.Id < 1)
            {
                try
                {
                    await _db.Services.AddAsync(entity);
                    if (!await SaveChanges())
                    {
                        return null;
                    }
                    return entity;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                _db.Services.Update(entity);
                if (!await SaveChanges())
                {
                    return null;
                }
                return entity;
            }
        }

        public async Task<bool> Delete(Service entity)
        {
            _db.Services.Remove(entity);
            return await SaveChanges();
        }
        public async Task<bool> SaveChanges()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
        public async Task<bool> IsExists(int id)
        {
            var isExists = await _db.Services.AnyAsync(p => p.Id == id);
            return isExists;
        }


    }
}
