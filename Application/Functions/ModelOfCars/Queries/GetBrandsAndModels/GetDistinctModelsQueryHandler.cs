using Application.Contracts.Persistence;
using Application.Responses;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.ModelOfCars.Queries.GetBrandsAndModels
{
    public class GetDistinctModelsQueryHandler : IRequestHandler<GetDistinctModelsQuery, BaseResponse<List<GetDistinctModelsQueryVM>>>
    {
        private readonly IMapper _mapper;
        private readonly IModelOfCarsRepository _modelOfCarsRepository;

        public GetDistinctModelsQueryHandler(IMapper mapper, IModelOfCarsRepository modelOfCarsRepository)
        {
            _mapper = mapper;
            _modelOfCarsRepository = modelOfCarsRepository;
        }

        public async Task<BaseResponse<List<GetDistinctModelsQueryVM>>> Handle(GetDistinctModelsQuery request, CancellationToken cancellationToken)
        {
            var modelsOfCars = await _modelOfCarsRepository.GetAllAsync();

            if (!modelsOfCars.Any())
                return new BaseResponse<List<GetDistinctModelsQueryVM>>("Brak modeli samochodów", false);

            var responseData = new List<GetDistinctModelsQueryVM>();

            List<string> brands = modelsOfCars.Select(m => m.BrandName).Distinct().ToList();

            foreach (var brand in brands)
            {
                responseData.Add(new GetDistinctModelsQueryVM()
                {
                    BrandName = brand,
                    Models = modelsOfCars.Where(m => m.BrandName == brand).Select(m => m.ModelName).Distinct().ToList()
                });
            }

            return new BaseResponse<List<GetDistinctModelsQueryVM>>(responseData);
        }
    }
}
