using System;
using ArcadeApp.Application.Dto;
using MediatR;

namespace ArcadeApp.Application.Features.Queries.Characters
{
	public class GetAllCharactersQuery:IRequest<List<CharacterDTO>>
	{
		
	}
}

