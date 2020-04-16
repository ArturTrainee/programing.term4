namespace Lab3
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
            this.exercise1Btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.exercise2Btn = new System.Windows.Forms.Button();
            this.exercise3And4Btn = new System.Windows.Forms.Button();
            this.exercise6And7Btn = new System.Windows.Forms.Button();
            this.exercise8And9Btn = new System.Windows.Forms.Button();
            this.exercise5Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exercise1Btn
            // 
            this.exercise1Btn.Location = new System.Drawing.Point(12, 48);
            this.exercise1Btn.Name = "exercise1Btn";
            this.exercise1Btn.Size = new System.Drawing.Size(139, 43);
            this.exercise1Btn.TabIndex = 0;
            this.exercise1Btn.Text = "Exercise 1";
            this.exercise1Btn.UseVisualStyleBackColor = true;
            this.exercise1Btn.Click += new System.EventHandler(this.Exercise1Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open exercise form:";
            // 
            // exercise2Btn
            // 
            this.exercise2Btn.Location = new System.Drawing.Point(154, 48);
            this.exercise2Btn.Name = "exercise2Btn";
            this.exercise2Btn.Size = new System.Drawing.Size(139, 43);
            this.exercise2Btn.TabIndex = 0;
            this.exercise2Btn.Text = "Exercise 2";
            this.exercise2Btn.UseVisualStyleBackColor = true;
            this.exercise2Btn.Click += new System.EventHandler(this.Exercise2Btn_Click);
            // 
            // exercise3And4Btn
            // 
            this.exercise3And4Btn.Location = new System.Drawing.Point(12, 97);
            this.exercise3And4Btn.Name = "exercise3And4Btn";
            this.exercise3And4Btn.Size = new System.Drawing.Size(139, 43);
            this.exercise3And4Btn.TabIndex = 0;
            this.exercise3And4Btn.Text = "Exercise 3 and 4";
            this.exercise3And4Btn.UseVisualStyleBackColor = true;
            this.exercise3And4Btn.Click += new System.EventHandler(this.Exercise3And4Btn_Click);
            // 
            // exercise6And7Btn
            // 
            this.exercise6And7Btn.Location = new System.Drawing.Point(12, 146);
            this.exercise6And7Btn.Name = "exercise6And7Btn";
            this.exercise6And7Btn.Size = new System.Drawing.Size(139, 43);
            this.exercise6And7Btn.TabIndex = 0;
            this.exercise6And7Btn.Text = "Exercise 6 and 7";
            this.exercise6And7Btn.UseVisualStyleBackColor = true;
            this.exercise6And7Btn.Click += new System.EventHandler(this.Exercise6And7Btn_Click);
            // 
            // exercise8And9Btn
            // 
            this.exercise8And9Btn.Location = new System.Drawing.Point(156, 146);
            this.exercise8And9Btn.Name = "exercise8And9Btn";
            this.exercise8And9Btn.Size = new System.Drawing.Size(139, 43);
            this.exercise8And9Btn.TabIndex = 0;
            this.exercise8And9Btn.Text = "Exercise 8 and 9";
            this.exercise8And9Btn.UseVisualStyleBackColor = true;
            this.exercise8And9Btn.Click += new System.EventHandler(this.Exercise8And9Btn_Click);
            // 
            // exercise5Btn
            // 
            this.exercise5Btn.Location = new System.Drawing.Point(156, 97);
            this.exercise5Btn.Name = "exercise5Btn";
            this.exercise5Btn.Size = new System.Drawing.Size(139, 43);
            this.exercise5Btn.TabIndex = 0;
            this.exercise5Btn.Text = "Exercise 5";
            this.exercise5Btn.UseVisualStyleBackColor = true;
            this.exercise5Btn.Click += new System.EventHandler(this.Exercise5Btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exercise3And4Btn);
            this.Controls.Add(this.exercise2Btn);
            this.Controls.Add(this.exercise6And7Btn);
            this.Controls.Add(this.exercise8And9Btn);
            this.Controls.Add(this.exercise5Btn);
            this.Controls.Add(this.exercise1Btn);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exercise1Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exercise2Btn;
        private System.Windows.Forms.Button exercise3And4Btn;
        private System.Windows.Forms.Button exercise6And7Btn;
        private System.Windows.Forms.Button exercise8And9Btn;
        private System.Windows.Forms.Button exercise5Btn;
    }
}

