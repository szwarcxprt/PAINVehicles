namespace Vehicles
{
    partial class TypeControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 73);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(35, 13);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "label1";
            this.typeLabel.Visible = false;
            // 
            // typeBtn
            // 
            this.typeBtn.Image = global::Vehicles.Properties.Resources.car;
            this.typeBtn.Location = new System.Drawing.Point(111, 14);
            this.typeBtn.Name = "typeBtn";
            this.typeBtn.Size = new System.Drawing.Size(136, 131);
            this.typeBtn.TabIndex = 0;
            this.typeBtn.UseVisualStyleBackColor = true;
            this.typeBtn.Click += new System.EventHandler(this.TypeBtn_Click);
            // 
            // TypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeBtn);
            this.Name = "TypeControl";
            this.Size = new System.Drawing.Size(250, 165);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button typeBtn;
        private System.Windows.Forms.Label typeLabel;
    }
}
