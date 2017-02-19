using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task2
{
    public partial class Task2_3Form : Form
    {
        private string regex; //Регулярное выражение
        Caesar caesar = new Caesar();
        Cryptanalysis cryptAnalysis = new Cryptanalysis();

        public Task2_3Form()
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

        //Кодирование, декодирование и криптоанализ
        #region
        //Закодировать
        private void EncryptButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            caesar.Result = "";
            caesar.Input = InputTextBox.Text;
            caesar.Encrypt();
            if (caesar.Alph == "C")
            {
                caesar.CyrillicTexts.Add(caesar.Input);
                caesar.CyrillicTexts.Add(caesar.Result);
                AddCyrillic();
            }
            else if (caesar.Alph == "R")
            {
                caesar.RomanTexts.Add(caesar.Input);
                caesar.RomanTexts.Add(caesar.Result);
                AddRoman();
            }
            ResultTextBox.Text = caesar.Result;
        }

        //Декодировать
        private void DecryptButton_Click(object sender, EventArgs e)
        {
            CryptListBox.Items.Clear();
            ResultTextBox.Text = "";
            caesar.Result = "";
            caesar.Input = InputTextBox.Text;
            caesar.Decrypt(caesar.Key);
            if (caesar.Alph == "C")
            {
                caesar.CyrillicTexts.Add(caesar.Input);
                caesar.CyrillicTexts.Add(caesar.Result);
                AddCyrillic();
            }
            else if (caesar.Alph == "R")
            {
                caesar.RomanTexts.Add(caesar.Input);
                caesar.RomanTexts.Add(caesar.Result);
                AddRoman();
            }
            ResultTextBox.Text = caesar.Result;
        }

        //Криптоанализ
        private void CryptButton_Click(object sender, EventArgs e)
        {
            CryptListBox.Items.Clear();
            ResultTextBox.Text = "";
            caesar.Result = "";
            caesar.Input = InputTextBox.Text;
            cryptAnalysis.BeginCryptanalysis(caesar);

            int[] convertedDistances = cryptAnalysis.Distances.Cast<int>().ToArray();

            var keys = convertedDistances.Where(str => convertedDistances.Count(s => s == str) > 1).Distinct();

            foreach (int key in keys)
            {
                caesar.Decrypt(key);
                CryptListBox.Items.Add(caesar.Result);
                caesar.Result = "";
            }
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
