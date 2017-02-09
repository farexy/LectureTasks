using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Caesar
    {
        //Поля
        #region
        private string input; //Входная строка
        private string result; //Выходная строка
        private string alph; //Алфавит
        private int key; //Ключ
        private List<string> cyrillicTexts = new List<string>(); //Список всех строк на кириллице
        private List<string> romanTexts = new List<string>(); //Список всех строк на латинице
        #endregion

        //Свойства
        #region
        public string Input { get { return input; } set { input = value; } } //Входная строка
        public string Result { get { return result; } set { result = value; } } //Выходная строка
        public string Alph { get { return alph; } set { alph = value; } } //Алфавит
        public int Key { get { return key; } set { key = value; } } //Ключ
        public List<string> CyrillicTexts { get { return cyrillicTexts; } set { cyrillicTexts = value; } } //Список всех строк на кириллице
        public List<string> RomanTexts { get { return romanTexts; } set { romanTexts = value; } } //Список всех строк на латинице
        #endregion

        //Кодирование
        public void Encrypt()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                //Пробел
                if (Input[i] == 32)
                {
                    Result += Input[i];
                    continue;
                }
                //Если кириллица
                if (Alph == "C")
                {
                    //Если буква после сдвига выходит за пределы алфавита
                    if (Input[i] + Key > 1103)
                        Result += Convert.ToChar(Input[i] + Key - 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        Result += Convert.ToChar(Input[i] + Key);
                }
                //Если латиница
                else if (Alph == "R")
                {
                    //Если буква после сдвига выходит за пределы алфавита
                    if (Input[i] + Key > 122)
                        Result += Convert.ToChar(Input[i] + Key - 26);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        Result += Convert.ToChar(Input[i] + Key);
                }
            }

            if (Alph == "C")
            {
                CyrillicTexts.Add(Input);
                CyrillicTexts.Add(Result);
            }
            else if (Alph == "R")
            {
                RomanTexts.Add(Input);
                RomanTexts.Add(Result);
            }
        }

        //Декодирование
        public void Decrypt()
        {
            for (int i = 0; i < Input.Length; i++)
            {
                //Пробел
                if (Input[i] == 32)
                {
                    Result += Input[i];
                    continue;
                }
                //Если кириллица
                if (Alph == "C")
                {
                    //Если буква после сдвига выходит за пределы алфавита
                    if (Input[i] - Key < 1072)
                        result += Convert.ToChar(Input[i] - Key + 32);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        result += Convert.ToChar(Input[i] - Key);
                }
                //Если латиница
                else if (Alph == "R")
                {
                    //Если буква после сдвига выходит за пределы алфавита
                    if (Input[i] - Key < 97)
                        result += Convert.ToChar(Input[i] - Key + 26);
                    //Если буква может быть сдвинута в пределах алфавита
                    else
                        result += Convert.ToChar(Input[i] - Key);
                }
            }

            if (Alph == "C")
            {
                CyrillicTexts.Add(Input);
                CyrillicTexts.Add(Result);
            }
            else if (Alph == "R")
            {
                RomanTexts.Add(Input);
                RomanTexts.Add(Result);
            }
        }
    }
}
