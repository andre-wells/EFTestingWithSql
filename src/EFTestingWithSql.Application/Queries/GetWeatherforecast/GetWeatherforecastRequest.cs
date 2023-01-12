using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestingWithSql.Application.Queries.GetWeatherforecast
{
    public class GetWeatherforecastRequest : IRequest<GetWeatherforecastResponse>
    {
    }
}
