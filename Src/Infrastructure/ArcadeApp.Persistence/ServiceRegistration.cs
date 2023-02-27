using System;
using ArcadeApp.Application.Contracts.Repository;
using ArcadeApp.Persistence.Context;
using ArcadeApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ArcadeApp.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceRegistration(this IServiceCollection services)
		{
			services.AddDbContext<ApplicationDbContext>(opt => { opt.UseInMemoryDatabase("InMemoryDb"); });
			services.AddTransient<ICharacterRepository,CharacterRepository>();

        }
	}
}

