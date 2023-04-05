namespace AutoSalonn
{
    partial class RegForm
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SecNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pas1TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Pas2TB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 49);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(287, 30);
            this.NameTB.TabIndex = 1;
            // 
            // SecNameTB
            // 
            this.SecNameTB.Location = new System.Drawing.Point(12, 124);
            this.SecNameTB.Name = "SecNameTB";
            this.SecNameTB.Size = new System.Drawing.Size(287, 30);
            this.SecNameTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // Pas1TB
            // 
            this.Pas1TB.Location = new System.Drawing.Point(12, 268);
            this.Pas1TB.Name = "Pas1TB";
            this.Pas1TB.Size = new System.Drawing.Size(287, 30);
            this.Pas1TB.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(12, 193);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(287, 30);
            this.LoginTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Логин";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Регистрация";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pas2TB
            // 
            this.Pas2TB.Location = new System.Drawing.Point(12, 346);
            this.Pas2TB.Name = "Pas2TB";
            this.Pas2TB.Size = new System.Drawing.Size(287, 30);
            this.Pas2TB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Подтвердите пароль";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.Pas2TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pas1TB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegForm";
            this.Text = "Форма регистрации";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SecNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pas1TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Pas2TB;
        private System.Windows.Forms.Label label5;
    }
}