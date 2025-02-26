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
            btnElectronic = new Button();
            btnProperties = new Button();
            btnIndumentary = new Button();
            btnVehicles = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEntities).BeginInit();
            SuspendLayout();
            // 
            // dgvEntities
            // 
            dgvEntities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEntities.Location = new Point(15, 90);
            dgvEntities.Margin = new Padding(4);
            dgvEntities.Name = "dgvEntities";
            dgvEntities.RowHeadersWidth = 51;
            dgvEntities.Size = new Size(845, 458);
            dgvEntities.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 2;
            label1.Text = "Buscar por";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(868, 279);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 36);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Modificar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(868, 322);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 36);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(868, 511);
            btnBack.Margin = new Padding(4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(118, 36);
            btnBack.TabIndex = 6;
            btnBack.Text = "Volver";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnElectronic
            // 
            btnElectronic.Location = new Point(458, 46);
            btnElectronic.Margin = new Padding(4);
            btnElectronic.Name = "btnElectronic";
            btnElectronic.Size = new Size(140, 36);
            btnElectronic.TabIndex = 10;
            btnElectronic.Text = "Electronica";
            btnElectronic.UseVisualStyleBackColor = true;
            // 
            // btnProperties
            // 
            btnProperties.Location = new Point(162, 46);
            btnProperties.Margin = new Padding(4);
            btnProperties.Name = "btnProperties";
            btnProperties.Size = new Size(140, 36);
            btnProperties.TabIndex = 8;
            btnProperties.Text = "Propiedades";
            btnProperties.UseVisualStyleBackColor = true;
            btnProperties.Click += btnProperties_Click;
            // 
            // btnIndumentary
            // 
            btnIndumentary.Location = new Point(310, 46);
            btnIndumentary.Margin = new Padding(4);
            btnIndumentary.Name = "btnIndumentary";
            btnIndumentary.Size = new Size(140, 36);
            btnIndumentary.TabIndex = 9;
            btnIndumentary.Text = "Indumentaria";
            btnIndumentary.UseVisualStyleBackColor = true;
            btnIndumentary.Click += btnIndumentary_Click;
            // 
            // btnVehicles
            // 
            btnVehicles.Location = new Point(15, 46);
            btnVehicles.Margin = new Padding(4);
            btnVehicles.Name = "btnVehicles";
            btnVehicles.Size = new Size(140, 36);
            btnVehicles.TabIndex = 7;
            btnVehicles.Text = "Vehiculos";
            btnVehicles.UseVisualStyleBackColor = true;
            btnVehicles.Click += btnVehicles_Click;
            // 
            // BookingsHistoricalView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnElectronic);
            Controls.Add(btnIndumentary);
            Controls.Add(btnProperties);
            Controls.Add(btnVehicles);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label1);
            Controls.Add(dgvEntities);
            Margin = new Padding(4);
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
        private Button btnElectronic;
        private Button btnProperties;
        private Button btnIndumentary;
        private Button btnVehicles;
    }
}