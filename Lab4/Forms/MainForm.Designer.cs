namespace Lab4.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEditSelected = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(776, 260);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(11, 287);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(186, 47);
            this.buttonNew.TabIndex = 1;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonEditSelected
            // 
            this.buttonEditSelected.Enabled = false;
            this.buttonEditSelected.Location = new System.Drawing.Point(203, 287);
            this.buttonEditSelected.Name = "buttonEditSelected";
            this.buttonEditSelected.Size = new System.Drawing.Size(186, 47);
            this.buttonEditSelected.TabIndex = 2;
            this.buttonEditSelected.Text = "Edit selected";
            this.buttonEditSelected.UseVisualStyleBackColor = true;
            this.buttonEditSelected.Click += new System.EventHandler(this.ButtonEditSelected_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.buttonEditSelected);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBox1);
            this.Name = "MainForm";
            this.Text = "Repertoires list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEditSelected;
    }
}

