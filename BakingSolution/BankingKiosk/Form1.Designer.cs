namespace BankingKiosk
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.amountInput = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(346, 141);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(125, 27);
            this.amountInput.TabIndex = 0;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(241, 210);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(94, 29);
            this.depositButton.TabIndex = 1;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(472, 210);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(94, 29);
            this.withdrawButton.TabIndex = 2;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.amountInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox amountInput;
        private Button depositButton;
        private Button withdrawButton;
    }
}