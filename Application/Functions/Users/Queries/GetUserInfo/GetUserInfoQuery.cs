using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.Users.Queries.GetUserInfo
{
    public class GetUserInfoQuery : IRequest<BaseResponse<GetUserInfoQueryViewModel>>
    {
        public int Id { get; set; }
    }
}
