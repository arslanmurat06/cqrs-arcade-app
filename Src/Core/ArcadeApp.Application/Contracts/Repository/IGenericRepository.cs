using System;
using ArcadeApp.Domain.Common;
using ArcadeApp.Domain.Entities;

namespace ArcadeApp.Application.Contracts.Repository
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
        Task<List<T>> GetAll();
        Task<T> GetById(Guid id);
        Task<T> Add(T value);
    }
}

