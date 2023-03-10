using Application.Contracts.Persistence;
using Application.Responses;
using AutoMapper;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Cars.Queries.GetCarsByModel
{
    public class GetCarsByModelQueryHandler : IRequestHandler<GetCarsByModelQuery, BaseResponse<List<GetCarsByModelQueryVM>>>
    {
        private readonly IMapper _mapper;
        private readonly ICarRepository _carRepository;

        public GetCarsByModelQueryHandler(IMapper mapper, ICarRepository carRepository)
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<GetCarsByModelQueryVM>>> Handle(GetCarsByModelQuery request, CancellationToken cancellationToken)
        {
            var responseData = await _carRepository.GetByModel(request.Brand, request.Model);

            if (!responseData.Any())
                return new BaseResponse<List<GetCarsByModelQueryVM>>("Brak Samochodów", false);

            return new BaseResponse<List<GetCarsByModelQueryVM>>(_mapper.Map<List<GetCarsByModelQueryVM>>(responseData));
        }
    }
}
