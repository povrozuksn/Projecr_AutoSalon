namespace AutoSalonn
{
    partial class AddCarForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.KuzovLabel = new System.Windows.Forms.Label();
            this.KPPLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.KppCB = new System.Windows.Forms.ComboBox();
            this.KuzovCB = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(23, 81);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(183, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название машины";
            // 
            // KuzovLabel
            // 
            this.KuzovLabel.AutoSize = true;
            this.KuzovLabel.Location = new System.Drawing.Point(23, 128);
            this.KuzovLabel.Name = "KuzovLabel";
            this.KuzovLabel.Size = new System.Drawing.Size(112, 25);
            this.KuzovLabel.TabIndex = 1;
            this.KuzovLabel.Text = "Тип кузова";
            // 
            // KPPLabel
            // 
            this.KPPLabel.AutoSize = true;
            this.KPPLabel.Location = new System.Drawing.Point(23, 176);
            this.KPPLabel.Name = "KPPLabel";
            this.KPPLabel.Size = new System.Drawing.Size(175, 25);
            this.KPPLabel.TabIndex = 2;
            this.KPPLabel.Text = "Тип трансмиссии";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(23, 223);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(104, 25);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Цена, руб.";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(245, 76);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(281, 30);
            this.NameTB.TabIndex = 4;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(245, 218);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(281, 30);
            this.PriceTB.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(0, 466);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(1007, 65);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // KppCB
            // 
            this.KppCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KppCB.FormattingEnabled = true;
            this.KppCB.Items.AddRange(new object[] {
            "акпп",
            "мкпп"});
            this.KppCB.Location = new System.Drawing.Point(244, 168);
            this.KppCB.Name = "KppCB";
            this.KppCB.Size = new System.Drawing.Size(281, 33);
            this.KppCB.TabIndex = 9;
            // 
            // KuzovCB
            // 
            this.KuzovCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KuzovCB.FormattingEnabled = true;
            this.KuzovCB.Items.AddRange(new object[] {
            "Седан",
            "Хечбек",
            "Купе",
            "Кабриолет",
            "Универсал"});
            this.KuzovCB.Location = new System.Drawing.Point(245, 120);
            this.KuzovCB.Name = "KuzovCB";
            this.KuzovCB.Size = new System.Drawing.Size(280, 33);
            this.KuzovCB.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(248, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выберите картинку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(203, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(203, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(203, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Добавление машины";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(557, 76);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(435, 369);
            this.InfoTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(302, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Добавление описания машины";
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 531);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.KuzovCB);
            this.Controls.Add(this.KppCB);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.KPPLabel);
            this.Controls.Add(this.KuzovLabel);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Форма добавления машины";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label KuzovLabel;
        private System.Windows.Forms.Label KPPLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox KppCB;
        private System.Windows.Forms.ComboBox KuzovCB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label label6;
    }
}