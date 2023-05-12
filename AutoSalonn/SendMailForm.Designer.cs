namespace AutoSalonn
{
    partial class SendMailForm
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
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ExitBbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(45, 27);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(404, 30);
            this.AdressTextBox.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(45, 94);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(180, 45);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ExitBbutton
            // 
            this.ExitBbutton.Location = new System.Drawing.Point(269, 94);
            this.ExitBbutton.Name = "ExitBbutton";
            this.ExitBbutton.Size = new System.Drawing.Size(180, 45);
            this.ExitBbutton.TabIndex = 2;
            this.ExitBbutton.Text = "Отмена";
            this.ExitBbutton.UseVisualStyleBackColor = true;
            this.ExitBbutton.Click += new System.EventHandler(this.ExitBbutton_Click);
            // 
            // SendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 173);
            this.Controls.Add(this.ExitBbutton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AdressTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SendMailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Отправка списка на Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdressTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button ExitBbutton;
    }
}