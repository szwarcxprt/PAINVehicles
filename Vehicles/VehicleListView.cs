using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class VehicleListView : Form, IRefreshable
    {

        private List<Vehicle> model;
        private FilterType filter_type;

        public VehicleListView(Form mdiParent)
        {       
                this.MdiParent = mdiParent;
                model = ((MainForm)mdiParent).getModel();
                this.filter_type = FilterType.None;
                
                InitializeComponent();
                this.showAllRBtn.Select();
        }

        private void loadList()
        {
            this.vehicleList.Items.Clear();
            foreach (var vehicle in model)
                addVehicleToList(vehicle);
        }

        private void addVehicleToList(Vehicle vehicle) {
           
            ListViewItem item = new ListViewItem(vehicle.getBrand());
            item.Tag = vehicle;
            item.SubItems.Add(vehicle.getMaxSpeed().ToString());
            item.SubItems.Add(vehicle.getProductionDate().ToString());
            item.SubItems.Add(vehicle.getVehicleType().ToString());

            this.vehicleList.Items.Add(item);
        }

        private void showBelowRButton_CheckedChanged(object sender, EventArgs e)
        {
            this.filter_type = FilterType.Below;
            this.model = ((MainForm)MdiParent).FilterVehicles(this.filter_type);
            this.loadList();

        }

        public void editVehicle(Vehicle vehicle)
        {
            ListViewItem toRemove = null;
            foreach (ListViewItem listItem in this.vehicleList.Items)
            {
                
                if (listItem.Tag == vehicle)
                {
                    if (!vehicle.IsToAdd(this.filter_type))
                    {
                        toRemove = listItem;
                        break;
                    }

                    listItem.SubItems[0].Text = vehicle.getBrand();
                    listItem.SubItems[1].Text = vehicle.getMaxSpeed().ToString();
                    listItem.SubItems[2].Text = vehicle.getProductionDate().ToString(CultureInfo.InvariantCulture);
                    listItem.SubItems[3].Text = vehicle.getVehicleType().ToString();
                    return;
                }
            }
            if (toRemove != null)
                this.vehicleList.Items.Remove(toRemove);
            if (vehicle.IsToAdd(filter_type))
                addVehicleToList(vehicle);
        }

        public void addVehicle(Vehicle vehicle)
        {
            if (vehicle.IsToAdd(this.filter_type))
                addVehicleToList(vehicle);
        }

        private bool isToAddToListView(Vehicle vehicle)
        {
            if (this.filter_type == FilterType.None)
                return true;

            if (this.filter_type == FilterType.Below && vehicle.getMaxSpeed() < Consts.SPEED_BORDER )
                return true;

            if (vehicle.getMaxSpeed() > Consts.SPEED_BORDER && this.filter_type == FilterType.Above)
                return true;

            return false;
        }

        public void vehicleRemoved(Vehicle vehicle) {
        
        }

        public void setControlBox(bool controlBox) {
            ControlBox = controlBox;
        }

        private void VehicleListView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).viewClosed(this);
        }

        private void VehicleListView_Load(object sender, EventArgs e)
        {
            this.loadList();
        }

        private void showAboveRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.filter_type = FilterType.Above;
            this.model = ((MainForm)MdiParent).FilterVehicles(this.filter_type);
            this.loadList();
        }

        private void showAllRBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.filter_type = FilterType.None;
            this.model = ((MainForm)MdiParent).FilterVehicles(this.filter_type);
            this.loadList();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            ((MainForm)MdiParent).EditVehicleForm(GetActiveItem());
        }

        private Vehicle GetActiveItem()
        {
            if (vehicleList.SelectedItems.Count > 0)
            {
                return (Vehicle)vehicleList.SelectedItems[0].Tag;
            }

            return null;
        }
    }
}
