namespace Boocking.Views.BookingsView
{
    partial class RentablesView
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
            btnShowVehicles = new Button();
            btnShowProperties = new Button();
            btnShowIndumentary = new Button();
            btnShowElectronics = new Button();
            label1 = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnShowVehicles
            // 
            btnShowVehicles.Location = new Point(107, 61);
            btnShowVehicles.Margin = new Padding(2, 2, 2, 2);
            btnShowVehicles.Name = "btnShowVehicles";
            btnShowVehicles.Size = new Size(110, 27);
            btnShowVehicles.TabIndex = 9;
            btnShowVehicles.Text = "Vehiculos";
            btnShowVehicles.UseVisualStyleBackColor = true;
            btnShowVehicles.Click += btnShowVehicles_Click;
            // 
            // btnShowProperties
            // 
            btnShowProperties.Location = new Point(107, 93);
            btnShowProperties.Margin = new Padding(2, 2, 2, 2);
            btnShowProperties.Name = "btnShowProperties";
            btnShowProperties.Size = new Size(110, 27);
            btnShowProperties.TabIndex = 10;
            btnShowProperties.Text = "Propiedades";
            btnShowProperties.UseVisualStyleBackColor = true;
            btnShowProperties.Click += btnShowProperties_Click;
            // 
            // btnShowIndumentary
            // 
            btnShowIndumentary.Location = new Point(107, 29);
            btnShowIndumentary.Margin = new Padding(2, 2, 2, 2);
            btnShowIndumentary.Name = "btnShowIndumentary";
            btnShowIndumentary.Size = new Size(110, 27);
            btnShowIndumentary.TabIndex = 11;
            btnShowIndumentary.Text = "Indumentaria";
            btnShowIndumentary.UseVisualStyleBackColor = true;
            btnShowIndumentary.Click += btnShowIndumentary_Click;
            // 
            // btnShowElectronics
            // 
            btnShowElectronics.Location = new Point(107, 125);
            btnShowElectronics.Margin = new Padding(2, 2, 2, 2);
            btnShowElectronics.Name = "btnShowElectronics";
            btnShowElectronics.Size = new Size(110, 27);
            btnShowElectronics.TabIndex = 12;
            btnShowElectronics.Text = "Electronica";
            btnShowElectronics.UseVisualStyleBackColor = true;
            btnShowElectronics.Click += btnShowElectronics_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 20);
            label1.TabIndex = 13;
            label1.Text = "Seleccione lo que desea administrar";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(240, 250);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 27);
            btnBack.TabIndex = 14;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RentablesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 287);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnShowElectronics);
            Controls.Add(btnShowIndumentary);
            Controls.Add(btnShowProperties);
            Controls.Add(btnShowVehicles);
            Margin = new Padding(2);
            Name = "RentablesView";
            Text = "Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnShowVehicles;
        private Button btnShowProperties;
        private Button btnShowIndumentary;
        private Button btnShowElectronics;
        private Label label1;
        private Button btnBack;
    }
}