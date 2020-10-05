using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public interface IModelRepository
    {
        Task<List<VehicleModel>> GetModels(string sortOrder, string searchString, int? pageNumber, int pageSize);

        Task<int> AddModel(VehicleModel model);

        Task<int> DeleteModel(int? modelId);

        Task<int> UpdateModel(VehicleModel model);
    }
}
