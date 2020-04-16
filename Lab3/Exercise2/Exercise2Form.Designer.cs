namespace Lab3.Exercise2
{
    partial class TestListForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memberLіst = new System.Windows.Forms.CheckedListBox();
            this.peopleLіst = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberLіst);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список учасників";
            // 
            // memberLіst
            // 
            this.memberLіst.FormattingEnabled = true;
            this.memberLіst.Location = new System.Drawing.Point(0, 21);
            this.memberLіst.Name = "memberLіst";
            this.memberLіst.Size = new System.Drawing.Size(304, 89);
            this.memberLіst.TabIndex = 4;
            // 
            // peopleLіst
            // 
            this.peopleLіst.Items.AddRange(new object[] {
            "Іван Іванович Іванов",
            "Петро Петрович Петров",
            "Миколай Миколайович Миколаєнко",
            "Сергій Сергійович Сергієнко"});
            this.peopleLіst.Location = new System.Drawing.Point(12, 135);
            this.peopleLіst.Name = "peopleLіst";
            this.peopleLіst.Size = new System.Drawing.Size(310, 24);
            this.peopleLіst.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 211);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(98, 40);
            this.Add.TabIndex = 6;
            this.Add.Text = "Додати";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(116, 213);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(98, 38);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Видалити";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(220, 213);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(98, 38);
            this.Sort.TabIndex = 6;
            this.Sort.Text = "Сортувати";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // TestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 263);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.peopleLіst);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TestListForm";
            this.Text = "Робота зі списками";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox memberLіst;
        private System.Windows.Forms.ComboBox peopleLіst;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Sort;
    }
}