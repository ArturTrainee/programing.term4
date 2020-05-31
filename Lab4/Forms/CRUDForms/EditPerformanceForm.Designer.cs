namespace Lab4.Forms
{
    partial class PerformanceInfoForm
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
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.withOrchestraCheckBox = new System.Windows.Forms.CheckBox();
            this.addLocationBtn = new System.Windows.Forms.Button();
            this.addTroupBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Troupe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rent Price:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(87, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(455, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(87, 77);
            this.locationTextBox.Multiline = true;
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(454, 92);
            this.locationTextBox.TabIndex = 10;
            this.locationTextBox.TabStop = false;
            // 
            // troupeTextBox
            // 
            this.troupeTextBox.Location = new System.Drawing.Point(88, 192);
            this.troupeTextBox.Multiline = true;
            this.troupeTextBox.Name = "troupeTextBox";
            this.troupeTextBox.ReadOnly = true;
            this.troupeTextBox.Size = new System.Drawing.Size(453, 91);
            this.troupeTextBox.TabIndex = 11;
            this.troupeTextBox.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 306);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(454, 22);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // rentTextBox
            // 
            this.rentTextBox.Location = new System.Drawing.Point(86, 339);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(454, 22);
            this.rentTextBox.TabIndex = 7;
            // 
            // editLocationBtn
            // 
            this.editLocationBtn.Enabled = false;
            this.editLocationBtn.Location = new System.Drawing.Point(6, 139);
            this.editLocationBtn.Name = "editLocationBtn";
            this.editLocationBtn.Size = new System.Drawing.Size(75, 34);
            this.editLocationBtn.TabIndex = 3;
            this.editLocationBtn.Text = "Edit";
            this.editLocationBtn.UseVisualStyleBackColor = true;
            this.editLocationBtn.Click += new System.EventHandler(this.EditLocationBtn_Click);
            // 
            // editTroupeBtn
            // 
            this.editTroupeBtn.Enabled = false;
            this.editTroupeBtn.Location = new System.Drawing.Point(5, 251);
            this.editTroupeBtn.Name = "editTroupeBtn";
            this.editTroupeBtn.Size = new System.Drawing.Size(75, 32);
            this.editTroupeBtn.TabIndex = 5;
            this.editTroupeBtn.Text = "Edit";
            this.editTroupeBtn.UseVisualStyleBackColor = true;
            this.editTroupeBtn.Click += new System.EventHandler(this.EditTroupeBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(356, 384);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 33);
            this.okBtn.TabIndex = 9;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(452, 384);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(90, 33);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(87, 40);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(454, 24);
            this.categoryComboBox.TabIndex = 1;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // withOrchestraCheckBox
            // 
            this.withOrchestraCheckBox.AutoSize = true;
            this.withOrchestraCheckBox.Location = new System.Drawing.Point(13, 378);
            this.withOrchestraCheckBox.Name = "withOrchestraCheckBox";
            this.withOrchestraCheckBox.Size = new System.Drawing.Size(122, 21);
            this.withOrchestraCheckBox.TabIndex = 8;
            this.withOrchestraCheckBox.Text = "With orchestra";
            this.withOrchestraCheckBox.UseVisualStyleBackColor = true;
            // 
            // addLocationBtn
            // 
            this.addLocationBtn.Enabled = false;
            this.addLocationBtn.Location = new System.Drawing.Point(6, 97);
            this.addLocationBtn.Name = "addLocationBtn";
            this.addLocationBtn.Size = new System.Drawing.Size(75, 36);
            this.addLocationBtn.TabIndex = 2;
            this.addLocationBtn.Text = "Add";
            this.addLocationBtn.UseVisualStyleBackColor = true;
            this.addLocationBtn.Click += new System.EventHandler(this.AddLocationBtn_Click);
            // 
            // addTroupBtn
            // 
            this.addTroupBtn.Enabled = false;
            this.addTroupBtn.Location = new System.Drawing.Point(6, 212);
            this.addTroupBtn.Name = "addTroupBtn";
            this.addTroupBtn.Size = new System.Drawing.Size(75, 34);
            this.addTroupBtn.TabIndex = 4;
            this.addTroupBtn.Text = "Add";
            this.addTroupBtn.UseVisualStyleBackColor = true;
            this.addTroupBtn.Click += new System.EventHandler(this.AddTroupBtn_Click);
            // 
            // PerformanceInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 429);
            this.Controls.Add(this.addTroupBtn);
            this.Controls.Add(this.addLocationBtn);
            this.Controls.Add(this.withOrchestraCheckBox);
            this.Controls.Add(this.categoryComboBox);
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
            this.Name = "PerformanceInfoForm";
            this.Text = "Performance Info";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPerformanceForm_FormClosing);
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
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.CheckBox withOrchestraCheckBox;
        private System.Windows.Forms.Button addLocationBtn;
        private System.Windows.Forms.Button addTroupBtn;
    }
}