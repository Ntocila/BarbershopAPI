﻿using Deus_DataAccessLayer.Data;
using Deus_DataAccessLayer.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deus_Models.Models;

namespace Deus_DataAccessLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _db;

        public CustomerRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IList<Customer>> GetAll()
        {
            var customers = await _db.Customers                           
                            .ToListAsync();
            return customers;
        }

        public async Task<Customer> GetById(int id)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(c => c.Id == id);
            return customer;
        }

        public async Task<Customer> CreateUpdate(Customer entity)
        {
            if (entity.Id < 1)
            {
                try
                {
                    await _db.Customers.AddAsync(entity);
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
                _db.Customers.Update(entity);
                if (!await SaveChanges())
                {
                    return null;
                }
                return entity;
            }
        }

        public async Task<bool> Delete(Customer entity)
        {
            _db.Customers.Remove(entity);
            return await SaveChanges();
        }

        public async Task<bool> SaveChanges()
        {
            var changes = await _db.SaveChangesAsync();
            return changes > 0;
        }
        public async Task<bool> IsExists(int id)
        {
            var isExists = await _db.Customers.AnyAsync(p => p.Id == id);
            return isExists;
        }
    }
}
