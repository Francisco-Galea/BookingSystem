namespace Booking.Views
{
    partial class RentableObjectView
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
            this.listBoxRentable = new ListBox();
            cbObjectType = new ComboBox();
            label1 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // listBoxRentable
            // 
            this.listBoxRentable.FormattingEnabled = true;
            this.listBoxRentable.Location = new Point(12, 12);
            this.listBoxRentable.Name = "listBoxRentable";
            this.listBoxRentable.Size = new Size(484, 684);
            this.listBoxRentable.TabIndex = 0;
            // 
            // cbObjectType
            // 
            cbObjectType.FormattingEnabled = true;
            cbObjectType.Location = new Point(502, 35);
            cbObjectType.Name = "cbObjectType";
            cbObjectType.Size = new Size(193, 28);
            cbObjectType.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(502, 12);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 2;
            label1.Text = "Seleccione el objeto a crear";
            // 
            // txtName
            // 
            txtName.Location = new Point(502, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 27);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(502, 280);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 27);
            txtPrice.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 66);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 6;
            label2.Text = "Ingrese el nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 119);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 7;
            label3.Text = "Ingrese una descripcion";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(502, 142);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(193, 112);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 257);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 9;
            label4.Text = "Ingrese el precio por dia";
            // 
            // RentableObjectView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1224, 704);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(cbObjectType);
            Controls.Add(this.listBoxRentable);
            Name = "RentableObjectView";
            Text = "RentableObjectView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox cbObjectType;
        private Label label1;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
        private Label label4;
    }
}