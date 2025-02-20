namespace Boocking.Views.BookingsView.BookingsHistorialView
{
    partial class BookingsHistoricalView
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
            dgvEntities = new DataGridView();
            label1 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            btnVehicles = new Button();
            btnProperties = new Button();
            btnIndumentary = new Button();
            btnElectronic = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Location = new Point(12, 72);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowHeadersWidth = 51;
            dgvEntities.Size = new Size(676, 366);
            dgvEntities.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 2;
            label1.Text = "Buscar por";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(694, 223);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(694, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(694, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnVehicles
            // 
            btnVehicles.Location = new Point(12, 37);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(112, 29);
            btnVehicles.TabIndex = 7;
            btnVehicles.Text = "Vehiculos";
            btnVehicles.UseVisualStyleBackColor = true;
            // 
            // btnProperties
            // 
            btnProperties.Location = new Point(130, 37);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(112, 29);
            btnProperties.TabIndex = 8;
            btnProperties.Text = "Propiedades";
            btnProperties.UseVisualStyleBackColor = true;
            // 
            // btnIndumentary
            // 
            btnIndumentary.Location = new Point(248, 37);
            btnIndumentary.Name = "btnIndumentary";
            btnIndumentary.Size = new Size(112, 29);
            btnIndumentary.TabIndex = 9;
            btnIndumentary.Text = "Indumentaria";
            btnIndumentary.UseVisualStyleBackColor = true;
            // 
            // btnElectronic
            // 
            btnElectronic.Location = new Point(366, 37);
            btnElectronic.Name = "btnElectronic";
            btnElectronic.Size = new Size(112, 29);
            btnElectronic.TabIndex = 10;
            btnElectronic.Text = "Electronica";
            btnElectronic.UseVisualStyleBackColor = true;
            // 
            // BookingsHistoricalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnElectronic);
            Controls.Add(btnIndumentary);
            Controls.Add(btnProperties);
            Controls.Add(btnVehicles);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(dgvEntities);
            Name = "BookingsHistoricalView";
            Text = "BookingsHistoricalView";
            ((System.ComponentModel.ISupportInitialize)dgvEntities).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEntities;
        private Label label1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private Button btnVehicles;
        private Button btnProperties;
        private Button btnIndumentary;
        private Button btnElectronic;
    }
}