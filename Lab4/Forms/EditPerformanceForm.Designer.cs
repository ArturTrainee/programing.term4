namespace Lab4.Forms
{
    partial class EditPerformanceForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.troupeTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.editLocationBtn = new System.Windows.Forms.Button();
            this.editTroupeBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.withOrchestraCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Troupe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rent Price:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(88, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(455, 22);
            this.nameTextBox.TabIndex = 6;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(88, 68);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(454, 22);
            this.locationTextBox.TabIndex = 8;
            // 
            // troupeTextBox
            // 
            this.troupeTextBox.Location = new System.Drawing.Point(88, 96);
            this.troupeTextBox.Name = "troupeTextBox";
            this.troupeTextBox.ReadOnly = true;
            this.troupeTextBox.Size = new System.Drawing.Size(453, 22);
            this.troupeTextBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(454, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(88, 157);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(454, 22);
            this.rentTextBox.TabIndex = 11;
            // 
            // editLocationBtn
            // 
            this.editLocationBtn.Location = new System.Drawing.Point(550, 70);
            this.editLocationBtn.Name = "editLocationBtn";
            this.editLocationBtn.Size = new System.Drawing.Size(75, 23);
            this.editLocationBtn.TabIndex = 12;
            this.editLocationBtn.Text = "Edit";
            this.editLocationBtn.UseVisualStyleBackColor = true;
            this.editLocationBtn.Click += new System.EventHandler(this.EditLocationBtn_Click);
            // 
            // editTroupeBtn
            // 
            this.editTroupeBtn.Location = new System.Drawing.Point(550, 98);
            this.editTroupeBtn.Name = "editTroupeBtn";
            this.editTroupeBtn.Size = new System.Drawing.Size(75, 23);
            this.editTroupeBtn.TabIndex = 13;
            this.editTroupeBtn.Text = "Edit";
            this.editTroupeBtn.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(439, 223);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 33);
            this.okBtn.TabIndex = 14;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(535, 223);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 33);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(454, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // withOrchestraCheckBox
            // 
            this.withOrchestraCheckBox.AutoSize = true;
            this.withOrchestraCheckBox.Location = new System.Drawing.Point(15, 200);
            this.withOrchestraCheckBox.Name = "withOrchestraCheckBox";
            this.withOrchestraCheckBox.Size = new System.Drawing.Size(122, 21);
            this.withOrchestraCheckBox.TabIndex = 17;
            this.withOrchestraCheckBox.Text = "With orchestra";
            this.withOrchestraCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditPerformanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 268);
            this.Controls.Add(this.withOrchestraCheckBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.editTroupeBtn);
            this.Controls.Add(this.editLocationBtn);
            this.Controls.Add(this.rentTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.troupeTextBox);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditPerformanceForm";
            this.Text = "FormEditPerformance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox troupeTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.Button editLocationBtn;
        private System.Windows.Forms.Button editTroupeBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox withOrchestraCheckBox;
    }
}