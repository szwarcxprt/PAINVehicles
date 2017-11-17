using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class MainForm : Form, IRefreshable
    {
        private readonly Model model = new Model();
        private readonly List<IRefreshable> views = new List<IRefreshable>();

        public MainForm()
        {
            InitializeComponent();
            VehicleListView view = new VehicleListView(this);
            view.setControlBox(false);
            view.Show();
            views.Add(view);
        }

       

        private void Add_Click(object sender, EventArgs e)
        {   
            AddVehicleForm add = new AddVehicleForm(this);
            add.Show();
        }

        public void EditVehicleForm(Vehicle vehicle)
        {
            if (vehicle == null)
                return;
            AddVehicleForm edit = new AddVehicleForm(vehicle) {MdiParent = this};
            edit.Show();
        }

        public Model getModel() {
            return this.model;
        }

        public void addVehicle(Vehicle vehicle) {
            this.model.Add(vehicle);
            this.refreshModel(vehicle);
        }

        public void refreshModel(Vehicle vehicle) {
            foreach (var view in views)
                view.refreshModel(vehicle);
        }

        public void vehicleRemoved(Vehicle vehicle) {
        
        }

        public void setControlBox(bool controlBox) {
            ControlBox = controlBox;
        }

        public void viewClosed(IRefreshable view)
        {
            Console.Write(views.Count);
            views.Remove(view);
            if (views.Count == 1)
            {
                views[0].setControlBox(false);
            }
        }

        public void viewOpened(IRefreshable view) {
            if (views.Count == 1)
                views[0].setControlBox(true);
            views.Add(view);
        }

        private void listViewOpenItem_Click(object sender, EventArgs e)
        {
            VehicleListView view = new VehicleListView(this);
            this.viewOpened(view);
            view.Show();
        }

        public List<Vehicle> FilterVehicles(FilterType type)
        {
            return this.model.FilterVehicles(type);
        }
    }
}
