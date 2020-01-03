namespace GasMileageTracker
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.averageMPGLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vehicleComboBox = new System.Windows.Forms.ComboBox();
            this.milesDrivenTextbox = new System.Windows.Forms.TextBox();
            this.fuelTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addTripButton = new System.Windows.Forms.Button();
            this.newVehicleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average MPG:";
            // 
            // averageMPGLabel
            // 
            this.averageMPGLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.averageMPGLabel.AutoSize = true;
            this.averageMPGLabel.Location = new System.Drawing.Point(353, 13);
            this.averageMPGLabel.Name = "averageMPGLabel";
            this.averageMPGLabel.Size = new System.Drawing.Size(18, 20);
            this.averageMPGLabel.TabIndex = 1;
            this.averageMPGLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vehicle:";
            // 
            // vehicleComboBox
            // 
            this.vehicleComboBox.FormattingEnabled = true;
            this.vehicleComboBox.Location = new System.Drawing.Point(85, 13);
            this.vehicleComboBox.Name = "vehicleComboBox";
            this.vehicleComboBox.Size = new System.Drawing.Size(121, 28);
            this.vehicleComboBox.TabIndex = 5;
            this.vehicleComboBox.SelectionChangeCommitted += new System.EventHandler(this.updateInfo);
            // 
            // milesDrivenTextbox
            // 
            this.milesDrivenTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.milesDrivenTextbox.Location = new System.Drawing.Point(147, 88);
            this.milesDrivenTextbox.Name = "milesDrivenTextbox";
            this.milesDrivenTextbox.Size = new System.Drawing.Size(100, 26);
            this.milesDrivenTextbox.TabIndex = 6;
            // 
            // fuelTextbox
            // 
            this.fuelTextbox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.fuelTextbox.Location = new System.Drawing.Point(147, 120);
            this.fuelTextbox.Name = "fuelTextbox";
            this.fuelTextbox.Size = new System.Drawing.Size(100, 26);
            this.fuelTextbox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Miles Driven:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Fuel Purchased:";
            // 
            // addTripButton
            // 
            this.addTripButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addTripButton.Location = new System.Drawing.Point(147, 152);
            this.addTripButton.Name = "addTripButton";
            this.addTripButton.Size = new System.Drawing.Size(100, 38);
            this.addTripButton.TabIndex = 12;
            this.addTripButton.Text = "Add Trip";
            this.addTripButton.UseVisualStyleBackColor = true;
            this.addTripButton.Click += new System.EventHandler(this.addTrip);
            // 
            // newVehicleButton
            // 
            this.newVehicleButton.Location = new System.Drawing.Point(85, 48);
            this.newVehicleButton.Name = "newVehicleButton";
            this.newVehicleButton.Size = new System.Drawing.Size(121, 34);
            this.newVehicleButton.TabIndex = 13;
            this.newVehicleButton.Text = "Add Vehicle";
            this.newVehicleButton.UseVisualStyleBackColor = true;
            this.newVehicleButton.Click += new System.EventHandler(this.addVehicle);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 233);
            this.Controls.Add(this.newVehicleButton);
            this.Controls.Add(this.addTripButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fuelTextbox);
            this.Controls.Add(this.milesDrivenTextbox);
            this.Controls.Add(this.vehicleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.averageMPGLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label averageMPGLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox vehicleComboBox;
        private System.Windows.Forms.TextBox milesDrivenTextbox;
        private System.Windows.Forms.TextBox fuelTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addTripButton;
        private System.Windows.Forms.Button newVehicleButton;
    }
}

