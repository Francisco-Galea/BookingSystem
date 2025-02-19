namespace Boocking.Views.RentableObjectsView
{
    partial class PropertyView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtProperty = new TextBox();
            txtDescription = new TextBox();
            txtCostUsage = new TextBox();
            txtDirection = new TextBox();
            btnCancel = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo de propiedad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 85);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 162);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 2;
            label3.Text = "Tarifa diaria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 242);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(85, 25);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            // 
            // txtProperty
            // 
            txtProperty.Location = new Point(98, 40);
            txtProperty.Margin = new Padding(2);
            txtProperty.Name = "txtProperty";
            txtProperty.Size = new Size(180, 31);
            txtProperty.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(98, 112);
            txtDescription.Margin = new Padding(2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(180, 31);
            txtDescription.TabIndex = 5;
            // 
            // txtCostUsage
            // 
            txtCostUsage.Location = new Point(98, 191);
            txtCostUsage.Margin = new Padding(2);
            txtCostUsage.Name = "txtCostUsage";
            txtCostUsage.Size = new Size(180, 31);
            txtCostUsage.TabIndex = 6;
            // 
            // txtDirection
            // 
            txtDirection.Location = new Point(98, 271);
            txtDirection.Margin = new Padding(2);
            txtDirection.Name = "txtDirection";
            txtDirection.Size = new Size(180, 31);
            txtDirection.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 354);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(250, 354);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Crear";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // PropertyView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 400);
            Controls.Add(btnCreate);
            Controls.Add(btnCancel);
            Controls.Add(txtDirection);
            Controls.Add(txtCostUsage);
            Controls.Add(txtDescription);
            Controls.Add(txtProperty);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "PropertyView";
            Text = "PropertyView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProperty;
        private TextBox txtDescription;
        private TextBox txtCostUsage;
        private TextBox txtDirection;
        private Button btnCancel;
        private Button btnCreate;
    }
}