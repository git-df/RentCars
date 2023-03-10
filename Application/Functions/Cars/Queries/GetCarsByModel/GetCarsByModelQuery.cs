using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Cars.Queries.GetCarsByModel
{
    public class GetCarsByModelQuery : IRequest<BaseResponse<List<GetCarsByModelQueryVM>>>
    {
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}
