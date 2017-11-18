using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class TypeControl : UserControl
    {
        private VehicleType _type;
        public TypeControl()
        {
            InitializeComponent();
            this._type = VehicleType.Car;
        }

        public Color typeLabel_BackColour
        {
            get { return this.typeLabel.BackColor; }
            set { this.typeLabel.BackColor = value; }
        }

        [Category("Type control")]
        public VehicleType vehicle_type
        {
            get { return this._type; }
            set { 
                this._type = value;
                this.typeLabel.Text = this._type.ToString();
                this.set_image(this._type);
                }
        }



        private void TypeBtn_Click(object sender, EventArgs e)
        {
            if (_type == VehicleType.Motorcycle)
            {
                _type = VehicleType.Car;
                typeBtn.Image = Properties.Resources.car;
                typeLabel.Text = _type.ToString();
            }
            else if (_type == VehicleType.Car)
            {
                _type = VehicleType.Truck;
                typeBtn.Image = Properties.Resources.truck;
                typeLabel.Text = _type.ToString();
            }
            else
            {
                _type = VehicleType.Motorcycle;
                typeBtn.Image = Properties.Resources.motorcycle;
                typeLabel.Text = _type.ToString();
            }
        }

        private void set_image(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.Car:
                    this.typeBtn.Image = Properties.Resources.car;
                    break;
                case VehicleType.Motorcycle:
                    this.typeBtn.Image = Properties.Resources.motorcycle;
                    break;
                case VehicleType.Truck:
                    this.typeBtn.Image = Properties.Resources.truck;
                    break;
            }

        }
    }
}
