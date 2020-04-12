namespace Lab2
{
    partial class Form1
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
            this.OpacityButton = new System.Windows.Forms.Button();
            this.bgColorButton = new System.Windows.Forms.Button();
            this.helloWorldButton = new System.Windows.Forms.Button();
            this.superButton = new System.Windows.Forms.Button();
            this.opacityCheckBox = new System.Windows.Forms.CheckBox();
            this.bgColorCheckBox = new System.Windows.Forms.CheckBox();
            this.helloWorldCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // OpacityButton
            // 
            this.OpacityButton.Location = new System.Drawing.Point(12, 12);
            this.OpacityButton.Name = "OpacityButton";
            this.OpacityButton.Size = new System.Drawing.Size(142, 42);
            this.OpacityButton.TabIndex = 0;
            this.OpacityButton.Text = "opacity";
            this.OpacityButton.UseVisualStyleBackColor = true;
            this.OpacityButton.Click += new System.EventHandler(this.OpacityButton_Click);
            // 
            // bgColorButton
            // 
            this.bgColorButton.Location = new System.Drawing.Point(160, 12);
            this.bgColorButton.Name = "bgColorButton";
            this.bgColorButton.Size = new System.Drawing.Size(139, 42);
            this.bgColorButton.TabIndex = 1;
            this.bgColorButton.Text = "bg color";
            this.bgColorButton.UseVisualStyleBackColor = true;
            this.bgColorButton.Click += new System.EventHandler(this.BgColorButton_Click);
            // 
            // helloWorldButton
            // 
            this.helloWorldButton.Location = new System.Drawing.Point(305, 11);
            this.helloWorldButton.Name = "helloWorldButton";
            this.helloWorldButton.Size = new System.Drawing.Size(141, 43);
            this.helloWorldButton.TabIndex = 2;
            this.helloWorldButton.Text = "show Hello World";
            this.helloWorldButton.UseVisualStyleBackColor = true;
            this.helloWorldButton.Click += new System.EventHandler(this.HelloWorldButton_Click);
            // 
            // superButton
            // 
            this.superButton.Location = new System.Drawing.Point(12, 92);
            this.superButton.Name = "superButton";
            this.superButton.Size = new System.Drawing.Size(434, 58);
            this.superButton.TabIndex = 3;
            this.superButton.Text = "Super mega button";
            this.superButton.UseVisualStyleBackColor = true;
            this.superButton.Click += new System.EventHandler(this.SuperButton_Click);
            // 
            // opacityCheckBox
            // 
            this.opacityCheckBox.AutoSize = true;
            this.opacityCheckBox.Location = new System.Drawing.Point(12, 166);
            this.opacityCheckBox.Name = "opacityCheckBox";
            this.opacityCheckBox.Size = new System.Drawing.Size(205, 21);
            this.opacityCheckBox.TabIndex = 4;
            this.opacityCheckBox.Text = "add opacity change on click";
            this.opacityCheckBox.UseVisualStyleBackColor = true;
            this.opacityCheckBox.CheckedChanged += new System.EventHandler(this.OpacityCheckBox_CheckedChanged);
            // 
            // bgColorCheckBox
            // 
            this.bgColorCheckBox.AutoSize = true;
            this.bgColorCheckBox.Location = new System.Drawing.Point(12, 193);
            this.bgColorCheckBox.Name = "bgColorCheckBox";
            this.bgColorCheckBox.Size = new System.Drawing.Size(211, 21);
            this.bgColorCheckBox.TabIndex = 5;
            this.bgColorCheckBox.Text = "add bg color change on click";
            this.bgColorCheckBox.UseVisualStyleBackColor = true;
            this.bgColorCheckBox.CheckedChanged += new System.EventHandler(this.BgColorCheckBox_CheckedChanged);
            // 
            // helloWorldCheckBox
            // 
            this.helloWorldCheckBox.AutoSize = true;
            this.helloWorldCheckBox.Location = new System.Drawing.Point(12, 220);
            this.helloWorldCheckBox.Name = "helloWorldCheckBox";
            this.helloWorldCheckBox.Size = new System.Drawing.Size(265, 21);
            this.helloWorldCheckBox.TabIndex = 6;
            this.helloWorldCheckBox.Text = "add messagebox Hello World on click";
            this.helloWorldCheckBox.UseVisualStyleBackColor = true;
            this.helloWorldCheckBox.CheckedChanged += new System.EventHandler(this.HelloWorldCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 259);
            this.Controls.Add(this.helloWorldCheckBox);
            this.Controls.Add(this.bgColorCheckBox);
            this.Controls.Add(this.opacityCheckBox);
            this.Controls.Add(this.superButton);
            this.Controls.Add(this.helloWorldButton);
            this.Controls.Add(this.bgColorButton);
            this.Controls.Add(this.OpacityButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpacityButton;
        private System.Windows.Forms.Button bgColorButton;
        private System.Windows.Forms.Button helloWorldButton;
        private System.Windows.Forms.Button superButton;
        private System.Windows.Forms.CheckBox opacityCheckBox;
        private System.Windows.Forms.CheckBox bgColorCheckBox;
        private System.Windows.Forms.CheckBox helloWorldCheckBox;
    }
}

