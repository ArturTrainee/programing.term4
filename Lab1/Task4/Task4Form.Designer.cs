namespace ProgramingTerm4.Lab1.Task4
{
    partial class Task4Form
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
            this.LabelGenerationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelGenerationButton
            // 
            this.LabelGenerationButton.Location = new System.Drawing.Point(12, 12);
            this.LabelGenerationButton.Name = "LabelGenerationButton";
            this.LabelGenerationButton.Size = new System.Drawing.Size(147, 36);
            this.LabelGenerationButton.TabIndex = 0;
            this.LabelGenerationButton.Text = "Create new label";
            this.LabelGenerationButton.UseVisualStyleBackColor = true;
            this.LabelGenerationButton.Click += new System.EventHandler(this.LabelGenerationButton_Click);
            // 
            // Task4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 464);
            this.Controls.Add(this.LabelGenerationButton);
            this.Name = "Task4Form";
            this.Text = "Task4Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LabelGenerationButton;
    }
}