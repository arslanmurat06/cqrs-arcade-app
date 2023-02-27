using System;
using ArcadeApp.Application.Dto;
using ArcadeApp.Application.Features.Commands.Characters;
using ArcadeApp.Domain.Entities;
using AutoMapper;

namespace ArcadeApp.Application.Mapping
{
	public class MappingProfile:Profile
	{

		public MappingProfile()
		{
			CreateMap<Character, CharacterDTO>().ReverseMap();
			CreateMap<Character, AddCharacterCommand>().ReverseMap();
        }
	}
}

