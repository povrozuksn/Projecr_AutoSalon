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
            this.KuzovTB = new System.Windows.Forms.TextBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.KppCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(25, 34);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(183, 25);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Название машины";
            // 
            // KuzovLabel
            // 
            this.KuzovLabel.AutoSize = true;
            this.KuzovLabel.Location = new System.Drawing.Point(25, 81);
            this.KuzovLabel.Name = "KuzovLabel";
            this.KuzovLabel.Size = new System.Drawing.Size(112, 25);
            this.KuzovLabel.TabIndex = 1;
            this.KuzovLabel.Text = "Тип кузова";
            // 
            // KPPLabel
            // 
            this.KPPLabel.AutoSize = true;
            this.KPPLabel.Location = new System.Drawing.Point(25, 129);
            this.KPPLabel.Name = "KPPLabel";
            this.KPPLabel.Size = new System.Drawing.Size(175, 25);
            this.KPPLabel.TabIndex = 2;
            this.KPPLabel.Text = "Тип трансмиссии";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(25, 176);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(104, 25);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Цена, руб.";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(247, 29);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(281, 30);
            this.NameTB.TabIndex = 4;
            // 
            // KuzovTB
            // 
            this.KuzovTB.Location = new System.Drawing.Point(247, 76);
            this.KuzovTB.Name = "KuzovTB";
            this.KuzovTB.Size = new System.Drawing.Size(281, 30);
            this.KuzovTB.TabIndex = 5;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(247, 171);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(281, 30);
            this.PriceTB.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.Location = new System.Drawing.Point(0, 268);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(565, 45);
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
            this.KppCB.Location = new System.Drawing.Point(246, 125);
            this.KppCB.Name = "KppCB";
            this.KppCB.Size = new System.Drawing.Size(281, 33);
            this.KppCB.TabIndex = 9;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 313);
            this.Controls.Add(this.KppCB);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.KuzovTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.KPPLabel);
            this.Controls.Add(this.KuzovLabel);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label KuzovLabel;
        private System.Windows.Forms.Label KPPLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox KuzovTB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox KppCB;
    }
}