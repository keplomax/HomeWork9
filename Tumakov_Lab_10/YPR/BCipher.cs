using System;

namespace Tumakov_Lab_10
{
    internal class BCipher : ICipher
    {
        public string Encode(string text)
        {
            char[] t = text.ToCharArray();

            return new string(t);
        }
        public string Decode()
        {
            char[] t = text.ToCharArray();
            for (int i = 0; i < t.Length; i++)
            {
                if (char.IsLetter(t[i]) && t[i] != 'a'
                    && t[i] != 'A' && t[i] != 'а' && t[i] != 'А')
                {
                    t[i]--;
                }
                else if (t[i] == 'A')
                {
                    t[i] = 'Z';
                }
                else if (t[i] == 'a')
                {
                    t[i] = 'z';
                }
                else if (t[i] == 'а')
                {
                    t[i] = 'я';
                }
                else if (t[i] == 'А')
                {
                    t[i] = 'Я';
                }
                else
                {
                    Console.WriteLine("Вы ввели число!");
                }
            }
            return new string(t);
        }
        public BCipher(string text)
        {
            this.text = text;
        }
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
}
