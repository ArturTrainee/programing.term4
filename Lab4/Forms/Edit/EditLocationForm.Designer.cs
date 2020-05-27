namespace Lab4.Forms
{
    partial class EditLocationForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addessTextBox = new System.Windows.Forms.TextBox();
            this.rentalPriceTextBox = new System.Windows.Forms.TextBox();
            this.freeSeatsAmountTextBox = new System.Windows.Forms.TextBox();
            this.orchestraPriceTextBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rental Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Free Seats Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Orchestra Price:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(81, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(249, 22);
            this.nameTextBox.TabIndex = 0;
            // 
            // addessTextBox
            // 
            this.addessTextBox.Location = new System.Drawing.Point(81, 44);
            this.addessTextBox.Name = "addessTextBox";
            this.addessTextBox.Size = new System.Drawing.Size(249, 22);
            this.addessTextBox.TabIndex = 1;
            // 
            // rentalPriceTextBox
            // 
            this.rentalPriceTextBox.Location = new System.Drawing.Point(148, 83);
            this.rentalPriceTextBox.Name = "rentalPriceTextBox";
            this.rentalPriceTextBox.Size = new System.Drawing.Size(182, 22);
            this.rentalPriceTextBox.TabIndex = 2;
            // 
            // freeSeatsAmountTextBox
            // 
            this.freeSeatsAmountTextBox.Location = new System.Drawing.Point(148, 118);
            this.freeSeatsAmountTextBox.Name = "freeSeatsAmountTextBox";
            this.freeSeatsAmountTextBox.Size = new System.Drawing.Size(182, 22);
            this.freeSeatsAmountTextBox.TabIndex = 3;
            // 
            // orchestraPriceTextBox
            // 
            this.orchestraPriceTextBox.Location = new System.Drawing.Point(148, 156);
            this.orchestraPriceTextBox.Name = "orchestraPriceTextBox";
            this.orchestraPriceTextBox.Size = new System.Drawing.Size(182, 22);
            this.orchestraPriceTextBox.TabIndex = 4;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(124, 228);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(98, 34);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(232, 228);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(98, 34);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditLocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 274);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.orchestraPriceTextBox);
            this.Controls.Add(this.freeSeatsAmountTextBox);
            this.Controls.Add(this.rentalPriceTextBox);
            this.Controls.Add(this.addessTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditLocationForm";
            this.Text = "Edit Location";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditLocationForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addessTextBox;
        private System.Windows.Forms.TextBox rentalPriceTextBox;
        private System.Windows.Forms.TextBox freeSeatsAmountTextBox;
        private System.Windows.Forms.TextBox orchestraPriceTextBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}