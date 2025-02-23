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
            btnShowVehicles.Location = new Point(134, 76);
            btnShowVehicles.Name = "btnShowVehicles";
            btnShowVehicles.Size = new Size(137, 34);
            btnShowVehicles.TabIndex = 9;
            btnShowVehicles.Text = "Vehiculos";
            btnShowVehicles.UseVisualStyleBackColor = true;
            btnShowVehicles.Click += btnShowVehicles_Click;
            // 
            // btnShowProperties
            // 
            btnShowProperties.Location = new Point(134, 116);
            btnShowProperties.Name = "btnShowProperties";
            btnShowProperties.Size = new Size(137, 34);
            btnShowProperties.TabIndex = 10;
            btnShowProperties.Text = "Propiedades";
            btnShowProperties.UseVisualStyleBackColor = true;
            btnShowProperties.Click += btnShowProperties_Click;
            // 
            // btnShowIndumentary
            // 
            btnShowIndumentary.Location = new Point(134, 36);
            btnShowIndumentary.Name = "btnShowIndumentary";
            btnShowIndumentary.Size = new Size(137, 34);
            btnShowIndumentary.TabIndex = 11;
            btnShowIndumentary.Text = "Indumentaria";
            btnShowIndumentary.UseVisualStyleBackColor = true;
            btnShowIndumentary.Click += btnShowIndumentary_Click;
            // 
            // btnShowElectronics
            // 
            btnShowElectronics.Location = new Point(134, 156);
            btnShowElectronics.Name = "btnShowElectronics";
            btnShowElectronics.Size = new Size(137, 34);
            btnShowElectronics.TabIndex = 12;
            btnShowElectronics.Text = "Electronica";
            btnShowElectronics.UseVisualStyleBackColor = true;
            btnShowElectronics.Click += btnShowElectronics_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 8);
            label1.Name = "label1";
            label1.Size = new Size(294, 25);
            label1.TabIndex = 13;
            label1.Text = "Seleccione lo que desea administrar";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(300, 313);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 14;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // ItemsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 359);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(btnShowElectronics);
            Controls.Add(btnShowIndumentary);
            Controls.Add(btnShowProperties);
            Controls.Add(btnShowVehicles);
            Margin = new Padding(2);
            Name = "ItemsView";
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