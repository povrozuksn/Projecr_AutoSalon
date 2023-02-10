namespace AutoSalonn
{
    partial class FiltrForm
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
            this.FindButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.kuzovComboBox = new System.Windows.Forms.ComboBox();
            this.kppComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(744, 12);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(128, 37);
            this.FindButton.TabIndex = 17;
            this.FindButton.Text = "Показать";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип кузова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Тип КПП";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Стоимость, руб.";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(192, 101);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(191, 30);
            this.priceTextBox.TabIndex = 21;
            // 
            // kuzovComboBox
            // 
            this.kuzovComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kuzovComboBox.FormattingEnabled = true;
            this.kuzovComboBox.Items.AddRange(new object[] {
            "Седан",
            "Хечбек",
            "Купе",
            "Кабриолет",
            "Универсал"});
            this.kuzovComboBox.Location = new System.Drawing.Point(192, 9);
            this.kuzovComboBox.Name = "kuzovComboBox";
            this.kuzovComboBox.Size = new System.Drawing.Size(191, 33);
            this.kuzovComboBox.TabIndex = 22;
            // 
            // kppComboBox
            // 
            this.kppComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kppComboBox.FormattingEnabled = true;
            this.kppComboBox.Items.AddRange(new object[] {
            "мкпп",
            "акпп"});
            this.kppComboBox.Location = new System.Drawing.Point(192, 53);
            this.kppComboBox.Name = "kppComboBox";
            this.kppComboBox.Size = new System.Drawing.Size(191, 33);
            this.kppComboBox.TabIndex = 25;
            // 
            // FiltrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(884, 586);
            this.Controls.Add(this.kppComboBox);
            this.Controls.Add(this.kuzovComboBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FindButton);
            this.Name = "FiltrForm";
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.FiltrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox kuzovComboBox;
        private System.Windows.Forms.ComboBox kppComboBox;
    }
}