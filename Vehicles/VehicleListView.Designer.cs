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
            this.vehicleList = new System.Windows.Forms.ListView();
            this.Brand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaxSpeed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elementCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.showBelowRBtn = new System.Windows.Forms.RadioButton();
            this.showAboveRBtn = new System.Windows.Forms.RadioButton();
            this.showAllRBtn = new System.Windows.Forms.RadioButton();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleList
            // 
            this.vehicleList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Brand,
            this.MaxSpeed,
            this.ProductionDate,
            this.Type});
            this.vehicleList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleList.Location = new System.Drawing.Point(0, 24);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.vehicleList.Size = new System.Drawing.Size(578, 376);
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
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.menuToolStripMenuItem.Text = "Add";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elementCounter
            // 
            this.elementCounter.AutoSize = true;
            this.elementCounter.BackColor = System.Drawing.SystemColors.Window;
            this.elementCounter.Location = new System.Drawing.Point(531, 7);
            this.elementCounter.Name = "elementCounter";
            this.elementCounter.Size = new System.Drawing.Size(0, 13);
            this.elementCounter.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(484, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Counter:";
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
            // showAllRBtn
            // 
            this.showAllRBtn.AutoSize = true;
            this.showAllRBtn.Location = new System.Drawing.Point(175, 5);
            this.showAllRBtn.Name = "showAllRBtn";
            this.showAllRBtn.Size = new System.Drawing.Size(70, 17);
            this.showAllRBtn.TabIndex = 1;
            this.showAllRBtn.TabStop = true;
            this.showAllRBtn.Text = "display all";
            this.showAllRBtn.UseVisualStyleBackColor = true;
            this.showAllRBtn.CheckedChanged += new System.EventHandler(this.showAllRBtn_CheckedChanged);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click_1);
            // 
            // VehicleListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 400);
            this.Controls.Add(this.elementCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vehicleList);
            this.Controls.Add(this.showBelowRBtn);
            this.Controls.Add(this.showAboveRBtn);
            this.Controls.Add(this.showAllRBtn);
            this.Controls.Add(this.menuStrip1);
            this.Name = "VehicleListView";
            this.Text = "VehicleListView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehicleListView_FormClosing);
            this.Load += new System.EventHandler(this.VehicleListView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vehicleList;
        private System.Windows.Forms.ColumnHeader Brand;
        private System.Windows.Forms.ColumnHeader MaxSpeed;
        private System.Windows.Forms.ColumnHeader ProductionDate;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label elementCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton showBelowRBtn;
        private System.Windows.Forms.RadioButton showAboveRBtn;
        private System.Windows.Forms.RadioButton showAllRBtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
    }
}