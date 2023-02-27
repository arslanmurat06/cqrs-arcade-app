using System;
using ArcadeApp.Application.Contracts.Repository;
using ArcadeApp.Domain.Entities;
using ArcadeApp.Persistence.Context;
using ArcadeApp.Domain.Common;
using Microsoft.EntityFrameworkCore;

namespace ArcadeApp.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T> Add(T value)
        {
            _context.Set<T>().Add(value);
            await _context.SaveChangesAsync();

            return value;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }
}

