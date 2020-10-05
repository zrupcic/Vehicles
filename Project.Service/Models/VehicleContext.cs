using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public partial class VehicleContext : DbContext
    {
        public VehicleContext() : base("ProjectContext")
        { }
        public virtual DbSet<VehicleModel> VehicleModels { get; set; }
        public virtual DbSet<VehicleMake> VehicleMakes { get; set; }

    }
}
