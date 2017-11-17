using System;
using System.Collections.Generic;


namespace Vehicles
{
    public interface IRefreshable
    {
        void refreshModel(Vehicle vehicle);
        //void addVehicle(Vehicle vehicle);
        void vehicleRemoved(Vehicle vehicle);
        void setControlBox(bool controlBox);
    }
}
