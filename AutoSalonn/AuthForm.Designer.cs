namespace AutoSalonn
{
    partial class AuthForm
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
            this.InpButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InpButton
            // 
            this.InpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InpButton.Location = new System.Drawing.Point(0, 314);
            this.InpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InpButton.Name = "InpButton";
            this.InpButton.Size = new System.Drawing.Size(266, 46);
            this.InpButton.TabIndex = 0;
            this.InpButton.Text = "Войти";
            this.InpButton.UseVisualStyleBackColor = true;
            this.InpButton.Click += new System.EventHandler(this.InpButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите логин";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(13, 39);
            this.LoginTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(240, 30);
            this.LoginTB.TabIndex = 2;
            // 
            // PasTB
            // 
            this.PasTB.Location = new System.Drawing.Point(13, 114);
            this.PasTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PasTB.Name = "PasTB";
            this.PasTB.Size = new System.Drawing.Size(240, 30);
            this.PasTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пароль";
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(14, 253);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(240, 48);
            this.RegButton.TabIndex = 5;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 56);
            this.label3.TabIndex = 6;
            this.label3.Text = "Для авторизации зарегистрируйтесь";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.PasTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InpButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AuthForm";
            this.Text = "ID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InpButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label label3;
    }
}