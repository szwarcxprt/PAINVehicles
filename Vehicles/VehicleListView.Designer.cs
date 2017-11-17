namespace Vehicles
{
    partial class VehicleListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleListView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addBtn = new System.Windows.Forms.ToolStripButton();
            this.editBtn = new System.Windows.Forms.ToolStripButton();
            this.removeBtn = new System.Windows.Forms.ToolStripButton();
            this.showAllRBtn = new System.Windows.Forms.RadioButton();
            this.showAboveRBtn = new System.Windows.Forms.RadioButton();
            this.showBelowRBtn = new System.Windows.Forms.RadioButton();
            this.vehicleList = new System.Windows.Forms.ListView();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBtn,
            this.editBtn,
            this.removeBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(578, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addBtn
            // 
            this.addBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(33, 22);
            this.addBtn.Text = "Add";
            // 
            // editBtn
            // 
            this.editBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editBtn.Image = ((System.Drawing.Image)(resources.GetObject("editBtn.Image")));
            this.editBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(31, 22);
            this.editBtn.Text = "Edit";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removeBtn.Image = ((System.Drawing.Image)(resources.GetObject("removeBtn.Image")));
            this.removeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(54, 22);
            this.removeBtn.Text = "Remove";
            // 
            // showAllRBtn
            // 
            this.showAllRBtn.AutoSize = true;
            this.showAllRBtn.Location = new System.Drawing.Point(138, 7);
            this.showAllRBtn.Name = "showAllRBtn";
            this.showAllRBtn.Size = new System.Drawing.Size(70, 17);
            this.showAllRBtn.TabIndex = 1;
            this.showAllRBtn.TabStop = true;
            this.showAllRBtn.Text = "display all";
            this.showAllRBtn.UseVisualStyleBackColor = true;
            this.showAllRBtn.CheckedChanged += new System.EventHandler(this.showAllRBtn_CheckedChanged);
            // 
            // showAboveRBtn
            // 
            this.showAboveRBtn.AutoSize = true;
            this.showAboveRBtn.Location = new System.Drawing.Point(278, 7);
            this.showAboveRBtn.Name = "showAboveRBtn";
            this.showAboveRBtn.Size = new System.Drawing.Size(80, 17);
            this.showAboveRBtn.TabIndex = 2;
            this.showAboveRBtn.TabStop = true;
            this.showAboveRBtn.Text = "> 100 km/h";
            this.showAboveRBtn.UseVisualStyleBackColor = true;
            this.showAboveRBtn.CheckedChanged += new System.EventHandler(this.showAboveRBtn_CheckedChanged);
            // 
            // showBelowRBtn
            // 
            this.showBelowRBtn.AutoSize = true;
            this.showBelowRBtn.Location = new System.Drawing.Point(374, 7);
            this.showBelowRBtn.Name = "showBelowRBtn";
            this.showBelowRBtn.Size = new System.Drawing.Size(80, 17);
            this.showBelowRBtn.TabIndex = 3;
            this.showBelowRBtn.TabStop = true;
            this.showBelowRBtn.Text = "< 100 km/h";
            this.showBelowRBtn.UseVisualStyleBackColor = true;
            this.showBelowRBtn.CheckedChanged += new System.EventHandler(this.showBelowRButton_CheckedChanged);
            // 
            // vehicleList
            // 
            this.vehicleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brand,
            this.MaxSpeed,
            this.ProductionDate,
            this.Type});
            this.vehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleList.Location = new System.Drawing.Point(0, 25);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vehicleList.Size = new System.Drawing.Size(578, 375);
            this.vehicleList.TabIndex = 4;
            this.vehicleList.UseCompatibleStateImageBehavior = false;
            this.vehicleList.View = System.Windows.Forms.View.Details;
            // 
            // Brand
            // 
            this.Brand.Text = "Brand";
            this.Brand.Width = 115;
            // 
            // MaxSpeed
            // 
            this.MaxSpeed.Text = "MaxSpeed( km/h )";
            this.MaxSpeed.Width = 106;
            // 
            // ProductionDate
            // 
            this.ProductionDate.Text = "ProductionDate";
            this.ProductionDate.Width = 167;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 159;
            // 
            // VehicleListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 400);
            this.Controls.Add(this.vehicleList);
            this.Controls.Add(this.showBelowRBtn);
            this.Controls.Add(this.showAboveRBtn);
            this.Controls.Add(this.showAllRBtn);
            this.Controls.Add(this.toolStrip1);
            this.Name = "VehicleListView";
            this.Text = "VehicleListView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehicleListView_FormClosing);
            this.Load += new System.EventHandler(this.VehicleListView_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RadioButton showAllRBtn;
        private System.Windows.Forms.RadioButton showAboveRBtn;
        private System.Windows.Forms.RadioButton showBelowRBtn;
        private System.Windows.Forms.ListView vehicleList;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader MaxSpeed;
        private System.Windows.Forms.ColumnHeader ProductionDate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ToolStripButton addBtn;
        private System.Windows.Forms.ToolStripButton editBtn;
        private System.Windows.Forms.ToolStripButton removeBtn;
    }
}