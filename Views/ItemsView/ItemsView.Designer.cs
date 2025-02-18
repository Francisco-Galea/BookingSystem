namespace Boocking.Views.BookingsView
{
    partial class ItemsView
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
            cbbRentableEntities = new ComboBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            listBoxVehicles = new ListBox();
            listBoxProperties = new ListBox();
            listBoxElectronic = new ListBox();
            listBoxIndumentary = new ListBox();
            SuspendLayout();
            // 
            // cbbRentableEntities
            // 
            cbbRentableEntities.FormattingEnabled = true;
            cbbRentableEntities.Items.AddRange(new object[] { "Vehiculo", "Dispositivo electronico", "Indumentaria", "Propiedad", "Vehiculo" });
            cbbRentableEntities.Location = new Point(11, 179);
            cbbRentableEntities.Margin = new Padding(2);
            cbbRentableEntities.Name = "cbbRentableEntities";
            cbbRentableEntities.Size = new Size(193, 33);
            cbbRentableEntities.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(11, 218);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(192, 34);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(11, 258);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(192, 36);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(14, 302);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 36);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // listBoxVehicles
            // 
            listBoxVehicles.FormattingEnabled = true;
            listBoxVehicles.ItemHeight = 25;
            listBoxVehicles.Location = new Point(227, 12);
            listBoxVehicles.Name = "listBoxVehicles";
            listBoxVehicles.Size = new Size(273, 254);
            listBoxVehicles.TabIndex = 8;
            // 
            // listBoxProperties
            // 
            listBoxProperties.FormattingEnabled = true;
            listBoxProperties.ItemHeight = 25;
            listBoxProperties.Location = new Point(515, 12);
            listBoxProperties.Name = "listBoxProperties";
            listBoxProperties.Size = new Size(273, 254);
            listBoxProperties.TabIndex = 9;
            // 
            // listBoxElectronic
            // 
            listBoxElectronic.FormattingEnabled = true;
            listBoxElectronic.ItemHeight = 25;
            listBoxElectronic.Location = new Point(227, 272);
            listBoxElectronic.Name = "listBoxElectronic";
            listBoxElectronic.Size = new Size(273, 254);
            listBoxElectronic.TabIndex = 10;
            // 
            // listBoxIndumentary
            // 
            listBoxIndumentary.FormattingEnabled = true;
            listBoxIndumentary.ItemHeight = 25;
            listBoxIndumentary.Location = new Point(515, 272);
            listBoxIndumentary.Name = "listBoxIndumentary";
            listBoxIndumentary.Size = new Size(273, 254);
            listBoxIndumentary.TabIndex = 11;
            // 
            // ItemsView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 547);
            Controls.Add(listBoxIndumentary);
            Controls.Add(listBoxElectronic);
            Controls.Add(listBoxProperties);
            Controls.Add(listBoxVehicles);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(cbbRentableEntities);
            Margin = new Padding(2);
            Name = "ItemsView";
            Text = "Booking";
            ResumeLayout(false);
        }

        #endregion
        private ComboBox cbbRentableEntities;
        private Button btnCreate;
        private Button btnUpdate;
        private Button btnDelete;
        private ListBox listBoxVehicles;
        private ListBox listBoxProperties;
        private ListBox listBoxElectronic;
        private ListBox listBoxIndumentary;
    }
}