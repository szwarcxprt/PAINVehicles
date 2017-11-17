using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Model: List<Vehicle>
    {

        public List<Vehicle> FilterVehicles(FilterType filter_type) {
            List<Vehicle> filtered = new List<Vehicle>();

            switch (filter_type)
            {   
                case FilterType.None:
                    return this;

                case FilterType.Below:
                    foreach (var vehicle in this)
                    {
                        if (vehicle.getMaxSpeed() < Consts.SPEED_BORDER)
                            filtered.Add(vehicle);
                    }
                    return filtered;
                case FilterType.Above:
                    foreach (var vehicle in this)
                    {
                        if (vehicle.getMaxSpeed() > Consts.SPEED_BORDER)
                            filtered.Add(vehicle);
                    }
                    return filtered;
            }
            return null;
        }
    
    }
}
