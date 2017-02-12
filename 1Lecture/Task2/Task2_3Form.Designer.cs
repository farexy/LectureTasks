namespace Task2
{
    partial class Task2_3Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextsListBox = new System.Windows.Forms.ListBox();
            this.CyrillicRadioButton = new System.Windows.Forms.RadioButton();
            this.RomanRadioButton = new System.Windows.Forms.RadioButton();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.KeyTrackBar = new System.Windows.Forms.TrackBar();
            this.ResultRadioButton = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.NameKeyLabel = new System.Windows.Forms.Label();
            this.CryptListBox = new System.Windows.Forms.ListBox();
            this.CryptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.KeyTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // TextsListBox
            // 
            this.TextsListBox.FormattingEnabled = true;
            this.TextsListBox.Location = new System.Drawing.Point(121, 12);
            this.TextsListBox.Name = "TextsListBox";
            this.TextsListBox.Size = new System.Drawing.Size(293, 82);
            this.TextsListBox.TabIndex = 0;
            this.TextsListBox.SelectedIndexChanged += new System.EventHandler(this.TextsListBox_SelectedIndexChanged);
            // 
            // CyrillicRadioButton
            // 
            this.CyrillicRadioButton.AutoSize = true;
            this.CyrillicRadioButton.Location = new System.Drawing.Point(12, 12);
            this.CyrillicRadioButton.Name = "CyrillicRadioButton";
            this.CyrillicRadioButton.Size = new System.Drawing.Size(80, 17);
            this.CyrillicRadioButton.TabIndex = 1;
            this.CyrillicRadioButton.Text = "Кириллица";
            this.CyrillicRadioButton.UseVisualStyleBackColor = true;
            this.CyrillicRadioButton.CheckedChanged += new System.EventHandler(this.CyrillicRadioButton_CheckedChanged);
            // 
            // RomanRadioButton
            // 
            this.RomanRadioButton.AutoSize = true;
            this.RomanRadioButton.Location = new System.Drawing.Point(12, 35);
            this.RomanRadioButton.Name = "RomanRadioButton";
            this.RomanRadioButton.Size = new System.Drawing.Size(74, 17);
            this.RomanRadioButton.TabIndex = 2;
            this.RomanRadioButton.Text = "Латиница";
            this.RomanRadioButton.UseVisualStyleBackColor = true;
            this.RomanRadioButton.CheckedChanged += new System.EventHandler(this.RomanRadioButton_CheckedChanged);
            // 
            // InputTextBox
            // 
            this.InputTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.InputTextBox.Location = new System.Drawing.Point(121, 191);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(293, 20);
            this.InputTextBox.TabIndex = 3;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.ResultTextBox.Location = new System.Drawing.Point(121, 217);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(293, 20);
            this.ResultTextBox.TabIndex = 4;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(13, 191);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(34, 13);
            this.InputLabel.TabIndex = 5;
            this.InputLabel.Text = "Вход:";
            // 
            // KeyTrackBar
            // 
            this.KeyTrackBar.LargeChange = 1;
            this.KeyTrackBar.Location = new System.Drawing.Point(121, 257);
            this.KeyTrackBar.Maximum = 32;
            this.KeyTrackBar.Minimum = 1;
            this.KeyTrackBar.Name = "KeyTrackBar";
            this.KeyTrackBar.Size = new System.Drawing.Size(293, 45);
            this.KeyTrackBar.TabIndex = 7;
            this.KeyTrackBar.Value = 1;
            this.KeyTrackBar.ValueChanged += new System.EventHandler(this.KeyTrackBar_ValueChanged);
            // 
            // ResultRadioButton
            // 
            this.ResultRadioButton.AutoSize = true;
            this.ResultRadioButton.Location = new System.Drawing.Point(12, 224);
            this.ResultRadioButton.Name = "ResultRadioButton";
            this.ResultRadioButton.Size = new System.Drawing.Size(62, 13);
            this.ResultRadioButton.TabIndex = 6;
            this.ResultRadioButton.Text = "Результат:";
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(73, 266);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(13, 13);
            this.KeyLabel.TabIndex = 8;
            this.KeyLabel.Text = "1";
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(12, 62);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(103, 35);
            this.EncryptButton.TabIndex = 9;
            this.EncryptButton.Text = "Закодировать по ключу";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(12, 103);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(103, 35);
            this.DecryptButton.TabIndex = 10;
            this.DecryptButton.Text = "Декодировать по ключу";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // NameKeyLabel
            // 
            this.NameKeyLabel.AutoSize = true;
            this.NameKeyLabel.Location = new System.Drawing.Point(13, 266);
            this.NameKeyLabel.Name = "NameKeyLabel";
            this.NameKeyLabel.Size = new System.Drawing.Size(36, 13);
            this.NameKeyLabel.TabIndex = 11;
            this.NameKeyLabel.Text = "Ключ:";
            // 
            // CryptListBox
            // 
            this.CryptListBox.FormattingEnabled = true;
            this.CryptListBox.Location = new System.Drawing.Point(121, 103);
            this.CryptListBox.Name = "CryptListBox";
            this.CryptListBox.Size = new System.Drawing.Size(293, 82);
            this.CryptListBox.TabIndex = 12;
            // 
            // CryptButton
            // 
            this.CryptButton.Location = new System.Drawing.Point(12, 144);
            this.CryptButton.Name = "CryptButton";
            this.CryptButton.Size = new System.Drawing.Size(103, 35);
            this.CryptButton.TabIndex = 13;
            this.CryptButton.Text = "Криптоанализ";
            this.CryptButton.UseVisualStyleBackColor = true;
            this.CryptButton.Click += new System.EventHandler(this.CryptButton_Click);
            // 
            // Task2_3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 314);
            this.Controls.Add(this.CryptButton);
            this.Controls.Add(this.CryptListBox);
            this.Controls.Add(this.NameKeyLabel);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyTrackBar);
            this.Controls.Add(this.ResultRadioButton);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.RomanRadioButton);
            this.Controls.Add(this.CyrillicRadioButton);
            this.Controls.Add(this.TextsListBox);
            this.Name = "Task2_3Form";
            this.Text = "Task2_3";
            ((System.ComponentModel.ISupportInitialize)(this.KeyTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TextsListBox;
        private System.Windows.Forms.RadioButton CyrillicRadioButton;
        private System.Windows.Forms.RadioButton RomanRadioButton;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TrackBar KeyTrackBar;
        private System.Windows.Forms.Label ResultRadioButton;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button EncryptButton;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.Label NameKeyLabel;
        private System.Windows.Forms.ListBox CryptListBox;
        private System.Windows.Forms.Button CryptButton;
    }
}

