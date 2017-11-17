using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class AddVehicleForm : Form
    {
        private VehicleType type;
        private readonly Vehicle vehicle;

        public AddVehicleForm(Form mdi_parent)
        {
            this.MdiParent = mdi_parent;
            vehicle = null;
            type = VehicleType.Car;

            InitializeComponent();
        }

        public AddVehicleForm(Vehicle vehicle)
        {
            if (vehicle != null)
            {
                this.vehicle = vehicle;
                this.type = vehicle.getVehicleType();
            }
            InitializeComponent();

            if (vehicle != null)
            {
                this.brandTextBox.Text = vehicle.getBrand();
                this.maxSpeedTextBox.Text = vehicle.getMaxSpeed().ToString();
                this.dateTimePicker.Value = vehicle.getProductionDate();
                this.typeControl1.vehicle_type = vehicle.getVehicleType();
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            String brand = this.brandTextBox.Text;
            int max_speed = Int32.Parse(this.maxSpeedTextBox.Text);
            DateTime prod_date = this.dateTimePicker.Value;
            VehicleType type = this.typeControl1.vehicle_type;
            
            Vehicle new_vehicle = new Vehicle(brand, max_speed, prod_date, type);
            ((MainForm)this.MdiParent).addVehicle(new_vehicle);
            //((MainForm)this.MdiParent).refreshModel(new_vehicle);

            this.Close();
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
