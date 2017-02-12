using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Cryptanalysis
    {
        //Поля
        #region
        private Dictionary<char, int> freq = new Dictionary<char, int>(); //Словарь с частотами
        private Dictionary<char, int> maxFreq = new Dictionary<char, int>(); //Словарь с четырьмя максимальными частотами
        private int[,] distances = new int[4, 4]; //Матрица расстояний
        #endregion

        //Свойства
        #region
        public int[,] Distances { get { return distances; } set { distances = value; } }
        #endregion

        //Криптоанализ
        public void BeginCryptanalysis(Caesar caesar)
        {
            freq.Clear();
            maxFreq.Clear();
            Frequency(caesar.Input);
            GetMaxFreq();
            GetDistances(caesar.Alph);
        }

        //Получение частот
        private void Frequency(string input)
        {
            foreach (char letter in input)
            {
                if (freq.ContainsKey(letter) || letter == 32)
                    continue;

                freq.Add(letter, input.Count(c => c == char.Parse(letter.ToString())));
            }
        }

        //Получение четырех букв с максимальными частотами
        private void GetMaxFreq()
        {
            do
            {
                int max = freq.Max(s => s.Value);
                List<char> buffer = freq.Where(s => s.Value.Equals(max)).Select(s => s.Key).ToList();
                foreach (char letter in buffer)
                {
                    maxFreq.Add(letter, max);
                    freq.Remove(letter);
                    if (maxFreq.Count == 4)
                        break;
                }
            }
            while (maxFreq.Count < 4);
        }

        //Получение матрицы расстояний
        private void GetDistances(string alph)
        {
            if (alph == "C")
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j == 0 && 1086 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 1086;
                        else if (j == 0 && 1086 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 32 - (1086 - maxFreq.ElementAt(i).Key);
                        else if (j == 1 && 1072 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 1072;
                        else if (j == 1 && 1072 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 32 - (1072 - maxFreq.ElementAt(i).Key);
                        else if (j == 2 && 1077 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 1077;
                        else if (j == 2 && 1077 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 32 - (1077 - maxFreq.ElementAt(i).Key);
                        else if (j == 3 && 1080 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 1080;
                        else if (j == 3 && 1080 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 32 - (1080 - maxFreq.ElementAt(i).Key);
                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j == 0 && 101 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 101;
                        else if (j == 0 && 101 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 26 - (101 - maxFreq.ElementAt(i).Key);
                        else if (j == 1 && 116 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 116;
                        else if (j == 1 && 116 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 26 - (116 - maxFreq.ElementAt(i).Key);
                        else if (j == 2 && 97 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 97;
                        else if (j == 2 && 97 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 26 - (97 - maxFreq.ElementAt(i).Key);
                        else if (j == 3 && 111 - maxFreq.ElementAt(i).Key <= 0)
                            distances[i, j] = maxFreq.ElementAt(i).Key - 111;
                        else if (j == 3 && 111 - maxFreq.ElementAt(i).Key > 0)
                            distances[i, j] = 26 - (111 - maxFreq.ElementAt(i).Key);
                    }
                }
            }
        }
    }
}
