using System;
using ArcadeApp.Application.Contracts.Repository;
using ArcadeApp.Application.Dto;
using AutoMapper;
using MediatR;

namespace ArcadeApp.Application.Features.Queries.Characters
{
	public class GetAllCharactersQueryHandler:IRequestHandler<GetAllCharactersQuery, List<CharacterDTO>>
	{
        ICharacterRepository _characterRepository;
        IMapper _mapper;

        public GetAllCharactersQueryHandler(ICharacterRepository characterRepository, IMapper mapper)
        {
            _characterRepository = characterRepository;
            _mapper = mapper;
        }

        public async Task<List<CharacterDTO>> Handle(GetAllCharactersQuery request, CancellationToken cancellationToken)
        {
           var result = await _characterRepository.GetAll();
            var dtos = _mapper.Map<List<CharacterDTO>>(result);

            return dtos;
        }
    }
}

