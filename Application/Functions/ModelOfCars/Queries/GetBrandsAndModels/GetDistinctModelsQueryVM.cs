using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Functions.ModelOfCars.Queries.GetBrandsAndModels
{
    public class GetDistinctModelsQueryVM
    {
        public string BrandName { get; set; }
        public List<string> Models { get; set; }
    }
}
