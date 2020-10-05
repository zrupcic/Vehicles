﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class VehicleMake
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual ICollection<VehicleModel> VehicleModels { get; set; }
    }
}
