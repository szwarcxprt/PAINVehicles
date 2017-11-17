using System;
using System.Collections.Generic;


namespace Vehicles
{
    public interface IRefreshable
    {
        void addVehicle(Vehicle vehicle);
        void editVehicle(Vehicle vehicle);
        void vehicleRemoved(Vehicle vehicle);
        void setControlBox(bool controlBox);
    }
}
