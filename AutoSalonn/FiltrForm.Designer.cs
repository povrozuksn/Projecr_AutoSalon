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
            this.kppComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.KuzovCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.CarsPanel = new System.Windows.Forms.Panel();
            this.HideButton = new System.Windows.Forms.Button();
            this.FiltrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(744, 51);
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
            this.label1.Location = new System.Drawing.Point(389, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Тип кузова";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Тип КПП";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Стоимость, руб.";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceTextBox.Location = new System.Drawing.Point(192, 150);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(191, 30);
            this.priceTextBox.TabIndex = 21;
            this.priceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.priceTextBox_KeyDown);
            // 
            // kppComboBox
            // 
            this.kppComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kppComboBox.FormattingEnabled = true;
            this.kppComboBox.Items.AddRange(new object[] {
            "мкпп",
            "акпп"});
            this.kppComboBox.Location = new System.Drawing.Point(192, 100);
            this.kppComboBox.Name = "kppComboBox";
            this.kppComboBox.Size = new System.Drawing.Size(191, 33);
            this.kppComboBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Название";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(192, 51);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(191, 30);
            this.NameTextBox.TabIndex = 27;
            this.NameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTextBox_KeyDown);
            // 
            // KuzovCheckedListBox
            // 
            this.KuzovCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KuzovCheckedListBox.FormattingEnabled = true;
            this.KuzovCheckedListBox.Items.AddRange(new object[] {
            "Седан",
            "Хечбек",
            "Купе",
            "Кабриолет",
            "Универсал"});
            this.KuzovCheckedListBox.Location = new System.Drawing.Point(507, 51);
            this.KuzovCheckedListBox.Name = "KuzovCheckedListBox";
            this.KuzovCheckedListBox.Size = new System.Drawing.Size(202, 129);
            this.KuzovCheckedListBox.TabIndex = 28;
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.Controls.Add(this.HideButton);
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.KuzovCheckedListBox);
            this.FiltrPanel.Controls.Add(this.FindButton);
            this.FiltrPanel.Controls.Add(this.NameTextBox);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.kppComboBox);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.priceTextBox);
            this.FiltrPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FiltrPanel.Location = new System.Drawing.Point(0, 0);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1095, 200);
            this.FiltrPanel.TabIndex = 29;
            // 
            // CarsPanel
            // 
            this.CarsPanel.AutoScroll = true;
            this.CarsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CarsPanel.Location = new System.Drawing.Point(0, 200);
            this.CarsPanel.Name = "CarsPanel";
            this.CarsPanel.Size = new System.Drawing.Size(1095, 386);
            this.CarsPanel.TabIndex = 30;
            this.CarsPanel.Resize += new System.EventHandler(this.CarsPanel_Resize);
            // 
            // HideButton
            // 
            this.HideButton.Location = new System.Drawing.Point(13, 0);
            this.HideButton.Name = "HideButton";
            this.HideButton.Size = new System.Drawing.Size(153, 30);
            this.HideButton.TabIndex = 29;
            this.HideButton.Text = "Скрыть фильтр";
            this.HideButton.UseVisualStyleBackColor = true;
            this.HideButton.Click += new System.EventHandler(this.HideButton_Click);
            // 
            // FiltrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 586);
            this.Controls.Add(this.CarsPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Name = "FiltrForm";
            this.Text = "Выбери автомобиль";
            this.Load += new System.EventHandler(this.FiltrForm_Load);
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox kppComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.CheckedListBox KuzovCheckedListBox;
        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Panel CarsPanel;
        private System.Windows.Forms.Button HideButton;
    }
}