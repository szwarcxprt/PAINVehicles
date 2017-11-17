using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    [Serializable]
    public class Vehicle
    {
        private string brand;
        private int max_speed;
        private DateTime production_date;
        private VehicleType vehicle_type;

        public Vehicle(string brand, int max_speed, DateTime production_date, VehicleType type) {
            this.brand = brand;
            this.max_speed = max_speed;
            this.production_date = production_date;
            this.vehicle_type = type;
        }

        public DateTime getProductionDate() {
            return this.production_date;
        }

        public void setProductionDate(DateTime production_date) {
            this.production_date = production_date;
        }

        public string getBrand() {
            return this.brand;
        }

        public void setBrand(string brand) {
            this.brand = brand;
        }

        public int getMaxSpeed(){
            return this.max_speed;
        }
        public void setMaxSpeed(int max_speed){
            this.max_speed = max_speed;
        }

        public VehicleType getVehicleType(){
            return this.vehicle_type;
        }
        public void setVehicleType(VehicleType vehicle_type){
            this.vehicle_type = vehicle_type;
        }
    }
}
