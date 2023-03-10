using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.ModelOfCars.Queries.GetBrandsAndModels
{
    public class GetDistinctModelsQuery : IRequest<BaseResponse<List<GetDistinctModelsQueryVM>>>
    {

    }
}
