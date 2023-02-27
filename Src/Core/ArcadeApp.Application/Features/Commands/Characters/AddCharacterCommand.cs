using System;
using ArcadeApp.Application.Dto;
using MediatR;

namespace ArcadeApp.Application.Features.Commands.Characters
{
	public class AddCharacterCommand:IRequest<CharacterDTO>
	{
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Intelligence { get; set; }
    }
}

