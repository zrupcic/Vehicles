using Service.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repository
{
    public interface IMakeRepository
    {
        Task<List<VehicleMake>> GetMakes(string sortOrder, string searchString, int? pageNumber, int pageSize);

        Task<int> AddMake(VehicleMake make);

        Task<int> DeleteMake(int? makeId);

        Task<int> UpdateMake(VehicleMake make);
    }
}
