namespace Lab3.Exercise1
{
    partial class WіnQuestіonForm
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
            this.btnyes = new System.Windows.Forms.Button();
            this.btnno = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(12, 85);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(146, 52);
            this.btnyes.TabIndex = 0;
            this.btnyes.Text = "Так";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.Btnyes_Click);
            // 
            // btnno
            // 
            this.btnno.Location = new System.Drawing.Point(171, 85);
            this.btnno.Name = "btnno";
            this.btnno.Size = new System.Drawing.Size(146, 52);
            this.btnno.TabIndex = 0;
            this.btnno.TabStop = false;
            this.btnno.Text = "Ні";
            this.btnno.UseVisualStyleBackColor = true;
            this.btnno.Enter += new System.EventHandler(this.btnno_Enter);
            this.btnno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Btnno_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ви задоволені своєю заробітною платою?";
            // 
            // WіnQuestіonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 149);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnyes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WіnQuestіonForm";
            this.Text = "Нагальне питання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Button btnno;
        private System.Windows.Forms.Label label1;
    }
}