namespace Lab4.Forms
{
    partial class EditRepertoireForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editSelectedBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(440, 22);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(508, 244);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Performances";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(364, 342);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(445, 342);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cacnel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // editSelectedBtn
            // 
            this.editSelectedBtn.Enabled = false;
            this.editSelectedBtn.Location = new System.Drawing.Point(15, 342);
            this.editSelectedBtn.Name = "editSelectedBtn";
            this.editSelectedBtn.Size = new System.Drawing.Size(118, 23);
            this.editSelectedBtn.TabIndex = 2;
            this.editSelectedBtn.Text = "Edit Selected";
            this.editSelectedBtn.UseVisualStyleBackColor = true;
            this.editSelectedBtn.Click += new System.EventHandler(this.EditSelectedBtn_Click);
            // 
            // EditRepertoireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 377);
            this.Controls.Add(this.editSelectedBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "EditRepertoireForm";
            this.Text = "Edit Repertoire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editSelectedBtn;
    }
}