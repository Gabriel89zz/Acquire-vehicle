namespace Acquire_vehicle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TypeVehicle = new ComboBox();
            txtbBrand = new TextBox();
            txtbModel = new TextBox();
            btnStartCar = new Button();
            btnClear = new Button();
            cbClass = new ComboBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(146, 14);
            label1.Name = "label1";
            label1.Size = new Size(289, 36);
            label1.TabIndex = 0;
            label1.Text = "Choose your vehicle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 75);
            label2.Name = "label2";
            label2.Size = new Size(64, 26);
            label2.TabIndex = 1;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 133);
            label3.Name = "label3";
            label3.Size = new Size(74, 26);
            label3.TabIndex = 2;
            label3.Text = "Brand:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(190, 197);
            label4.Name = "label4";
            label4.Size = new Size(79, 26);
            label4.TabIndex = 3;
            label4.Text = "Model:";
            // 
            // TypeVehicle
            // 
            TypeVehicle.FormattingEnabled = true;
            TypeVehicle.Items.AddRange(new object[] { "Car", "Motorcycle" });
            TypeVehicle.Location = new Point(260, 78);
            TypeVehicle.Name = "TypeVehicle";
            TypeVehicle.Size = new Size(121, 23);
            TypeVehicle.TabIndex = 4;
            // 
            // txtbBrand
            // 
            txtbBrand.Location = new Point(281, 133);
            txtbBrand.Name = "txtbBrand";
            txtbBrand.Size = new Size(100, 23);
            txtbBrand.TabIndex = 5;
            // 
            // txtbModel
            // 
            txtbModel.Location = new Point(281, 202);
            txtbModel.Name = "txtbModel";
            txtbModel.Size = new Size(100, 23);
            txtbModel.TabIndex = 6;
            // 
            // btnStartCar
            // 
            btnStartCar.BackColor = SystemColors.ActiveCaptionText;
            btnStartCar.FlatAppearance.BorderSize = 0;
            btnStartCar.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            btnStartCar.FlatStyle = FlatStyle.Flat;
            btnStartCar.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartCar.ForeColor = SystemColors.ButtonHighlight;
            btnStartCar.Location = new Point(177, 372);
            btnStartCar.Name = "btnStartCar";
            btnStartCar.Size = new Size(95, 40);
            btnStartCar.TabIndex = 7;
            btnStartCar.Text = "Start Car";
            btnStartCar.UseVisualStyleBackColor = false;
            btnStartCar.Click += btnStartCar_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveCaptionText;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft YaHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.Control;
            btnClear.Location = new Point(295, 372);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 40);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // cbClass
            // 
            cbClass.FormattingEnabled = true;
            cbClass.Items.AddRange(new object[] { "B", "A", "S" });
            cbClass.Location = new Point(260, 264);
            cbClass.Name = "cbClass";
            cbClass.Size = new Size(121, 23);
            cbClass.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(190, 261);
            label6.Name = "label6";
            label6.Size = new Size(65, 26);
            label6.TabIndex = 11;
            label6.Text = "Class:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 450);
            Controls.Add(cbClass);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnStartCar);
            Controls.Add(txtbModel);
            Controls.Add(txtbBrand);
            Controls.Add(TypeVehicle);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox TypeVehicle;
        private TextBox txtbBrand;
        private TextBox txtbModel;
        private Button btnStartCar;
        private Button btnClear;
        private Label label6;
        private ComboBox cbClass;
    }
}
