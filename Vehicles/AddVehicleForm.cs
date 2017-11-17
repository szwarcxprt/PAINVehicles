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
            CausesValidation = false;
            cancelBtn.CausesValidation = false;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            TopMost = true;
        }

        public AddVehicleForm(Vehicle vehicle)
        {
            CausesValidation = false;

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
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;

                String brand = this.brandTextBox.Text;
                int max_speed = Int32.Parse(this.maxSpeedTextBox.Text);
                DateTime prod_date = this.dateTimePicker.Value;
                VehicleType type = this.typeControl1.vehicle_type;

                if (this.vehicle == null)
                {
                    Vehicle new_vehicle = new Vehicle(brand, max_speed, prod_date, type);
                    ((MainForm)this.MdiParent).addVehicle(new_vehicle);
                }
                else
                {
                    this.vehicle.setBrand(brand);
                    this.vehicle.setMaxSpeed(max_speed);
                    this.vehicle.setProductionDate(prod_date);
                    this.vehicle.setVehicleType(type);
                    ((MainForm)this.MdiParent).editVehicle(this.vehicle);

                }

                //Vehicle new_vehicle = new Vehicle(brand, max_speed, prod_date, type);
                //((MainForm)this.MdiParent).addNewVehicle(new_vehicle);
                //((MainForm)this.MdiParent).addVehicle(new_vehicle);
                //((MainForm)this.MdiParent).refreshModel(new_vehicle);

                this.Close();
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void brandTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(brandTextBox, "");
        }

        private void brandTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (brandTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(brandTextBox, "Brnad cannot be empty");
            }
        }

        private void maxSpeedTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(maxSpeedTextBox, "");
        }

        private void maxSpeedTextBox_Validating(object sender, CancelEventArgs e)
        {
            int test;
            bool isNumeric = int.TryParse(maxSpeedTextBox.Text, out test);
            if (!isNumeric)
            {
                e.Cancel = true;
                errorProvider1.SetError(maxSpeedTextBox, "Max Speed must be number");
            }

        }
    }
}
