namespace Lab4.Forms
{
    partial class CreatePerformanceForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.addLocationBtn = new System.Windows.Forms.Button();
            this.addTroupe = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Troupe:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Start Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rent Price:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(455, 22);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 22);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(79, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(455, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(79, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(455, 22);
            this.textBox2.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 21);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "With orchestra";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(79, 95);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(455, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 160);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(455, 22);
            this.textBox4.TabIndex = 5;
            // 
            // addLocationBtn
            // 
            this.addLocationBtn.Location = new System.Drawing.Point(550, 68);
            this.addLocationBtn.Name = "addLocationBtn";
            this.addLocationBtn.Size = new System.Drawing.Size(75, 23);
            this.addLocationBtn.TabIndex = 2;
            this.addLocationBtn.Text = "Add";
            this.addLocationBtn.UseVisualStyleBackColor = true;
            this.addLocationBtn.Click += new System.EventHandler(this.AddLocationBtn_Click);
            // 
            // addTroupe
            // 
            this.addTroupe.Location = new System.Drawing.Point(550, 96);
            this.addTroupe.Name = "addTroupe";
            this.addTroupe.Size = new System.Drawing.Size(75, 23);
            this.addTroupe.TabIndex = 3;
            this.addTroupe.Text = "Add";
            this.addTroupe.UseVisualStyleBackColor = true;
            this.addTroupe.Click += new System.EventHandler(this.AddTroupe_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(435, 224);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(92, 32);
            this.okBtn.TabIndex = 7;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(533, 224);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(92, 32);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // FormCreatePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 268);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.addTroupe);
            this.Controls.Add(this.addLocationBtn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCreatePerformance";
            this.Text = "Create Performance";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button addLocationBtn;
        private System.Windows.Forms.Button addTroupe;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}