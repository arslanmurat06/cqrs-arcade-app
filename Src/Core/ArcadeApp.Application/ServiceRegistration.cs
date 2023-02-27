using System;
using System.Reflection;
using ArcadeApp.Application.Contracts.Repository;
using ArcadeApp.Application.Mapping;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ArcadeApp.Application
{
	public static class ServiceRegistration
	{
		public static void AddApplicationRegistration(this IServiceCollection services)
		{
			var assembly = Assembly.GetExecutingAssembly();
			services.AddAutoMapper(assembly);
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
			

        }
	}
}

