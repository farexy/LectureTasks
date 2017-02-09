using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Task2Form : Form
    {
        private string regex; //Регулярное выражение
        Caesar caesar = new Caesar();

        public Task2Form()
        {
            InitializeComponent();
            CyrillicRadioButton.Checked = true;
        }

        //Изменение алфавита
        #region
        //Выбор кириллицы
        private void CyrillicRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            caesar.Alph = "C";
            KeyTrackBar.Value = 1;
            KeyTrackBar.Maximum = 32;
            regex = @"[а-я\s]";
            InputTextBox.Text = "";
            ResultTextBox.Text = "";
            AddCyrillic();
        }

        //Выбор латиницы
        private void RomanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            caesar.Alph = "R";
            KeyTrackBar.Value = 1;
            KeyTrackBar.Maximum = 26;
            regex = @"[a-z\s]";
            InputTextBox.Text = "";
            ResultTextBox.Text = "";
            AddRoman();
        }
        #endregion

        //Заполнение listbox
        #region
        //При кириллице
        private void AddCyrillic()
        {
            TextsListBox.Items.Clear();
            foreach (string cyrillicText in caesar.CyrillicTexts)
                TextsListBox.Items.Add(cyrillicText);
        }

        //При латинице
        private void AddRoman()
        {
            TextsListBox.Items.Clear();
            foreach (string romanText in caesar.RomanTexts)
                TextsListBox.Items.Add(romanText);
        }
        #endregion

        //Кодирование и декодирование
        #region
        //Закодировать
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            caesar.Result = "";
            caesar.Input = InputTextBox.Text;
            caesar.Encrypt();
            ResultTextBox.Text = caesar.Result;
            if (caesar.Alph == "C")
                AddCyrillic();
            else
                AddRoman();
        }

        //Декодировать
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            caesar.Result = "";
            caesar.Input = InputTextBox.Text;
            caesar.Decrypt();
            ResultTextBox.Text = caesar.Result;
            if (caesar.Alph == "C")
                AddCyrillic();
            else
                AddRoman();
        }
        #endregion

        //Изменение ключа через trackbar
        private void KeyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            KeyLabel.Text = KeyTrackBar.Value.ToString();
            caesar.Key = KeyTrackBar.Value;
        }

        //Запрет на ввод букв не по алфавиту
        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length > 0 && 
                !Regex.IsMatch(InputTextBox.Text[InputTextBox.Text.Length - 1].ToString(), regex))
                InputTextBox.Text = InputTextBox.Text.Remove(InputTextBox.Text.Length - 1);
            InputTextBox.SelectionStart = InputTextBox.Text.Length;
        }

        //Выбор строки из списка
        private void TextsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InputTextBox.Text = TextsListBox.SelectedItem.ToString();
        }
    }
}
