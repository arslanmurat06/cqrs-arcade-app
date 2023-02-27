using System;
using ArcadeApp.Application.Contracts.Repository;
using ArcadeApp.Domain.Entities;
using ArcadeApp.Persistence.Context;

namespace ArcadeApp.Persistence.Repositories
{
	public class CharacterRepository: GenericRepository<Character>,ICharacterRepository
	{
		
		public CharacterRepository(ApplicationDbContext context) : base(context)
		{

		}
	}
}

