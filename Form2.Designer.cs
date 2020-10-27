namespace MortgageProg
{
    partial class Form2
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
            this.mgtAmountTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intRateTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loanLengthTxtBox = new System.Windows.Forms.TextBox();
            this.dataBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mortgage Amount";
            // 
            // mgtAmountTxtBox
            // 
            this.mgtAmountTxtBox.Location = new System.Drawing.Point(138, 13);
            this.mgtAmountTxtBox.Name = "mgtAmountTxtBox";
            this.mgtAmountTxtBox.Size = new System.Drawing.Size(397, 20);
            this.mgtAmountTxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Interest Rate";
            // 
            // intRateTxtBox
            // 
            this.intRateTxtBox.Location = new System.Drawing.Point(138, 53);
            this.intRateTxtBox.Name = "intRateTxtBox";
            this.intRateTxtBox.Size = new System.Drawing.Size(397, 20);
            this.intRateTxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loan Length";
            // 
            // loanLengthTxtBox
            // 
            this.loanLengthTxtBox.Location = new System.Drawing.Point(138, 92);
            this.loanLengthTxtBox.Name = "loanLengthTxtBox";
            this.loanLengthTxtBox.Size = new System.Drawing.Size(397, 20);
            this.loanLengthTxtBox.TabIndex = 5;
            // 
            // dataBtn
            // 
            this.dataBtn.Location = new System.Drawing.Point(16, 137);
            this.dataBtn.Name = "dataBtn";
            this.dataBtn.Size = new System.Drawing.Size(75, 23);
            this.dataBtn.TabIndex = 6;
            this.dataBtn.Text = "Save Data";
            this.dataBtn.UseVisualStyleBackColor = true;
            this.dataBtn.Click += new System.EventHandler(this.dataBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 172);
            this.Controls.Add(this.dataBtn);
            this.Controls.Add(this.loanLengthTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.intRateTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mgtAmountTxtBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Mortgage Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mgtAmountTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox intRateTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loanLengthTxtBox;
        private System.Windows.Forms.Button dataBtn;
    }
}