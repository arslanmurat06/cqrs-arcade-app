using System;
using ArcadeApp.Application.Contracts.Repository;
using ArcadeApp.Application.Dto;
using ArcadeApp.Domain.Entities;
using AutoMapper;
using MediatR;

namespace ArcadeApp.Application.Features.Commands.Characters
{
    public class AddCharacterCommandHandler : IRequestHandler<AddCharacterCommand, CharacterDTO>
    {
        ICharacterRepository _characterRepository;
        IMapper _mapper;

        public AddCharacterCommandHandler(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }

        public async Task<CharacterDTO> Handle(AddCharacterCommand request, CancellationToken cancellationToken)
        {
            var character = _mapper.Map<Character>(request);
            var characterEntity =  await _characterRepository.Add(character);

            return _mapper.Map<CharacterDTO>(characterEntity);
        }
    }
}

