using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Repository;

namespace Service.Models
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IMakeRepository>().To<VehicleService>();
        }
    }
}
