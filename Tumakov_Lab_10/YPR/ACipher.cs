using System;

namespace Tumakov_Lab_10
{
    public class ACipher : ICipher
    {
        public string Encode(string text)
        {
            char[] t = text.ToCharArray();
            for (int i = 0; i < t.Length; i++)
            {
                if (char.IsLetter(t[i]) && t[i] != 'z'
                    && t[i] != 'Z' && t[i] != 'я' && t[i] != 'Я')
                {
                    t[i]++;
                }
                else if (t[i] == 'Z')
                {
                    t[i] = 'A';
                }
                else if (t[i] == 'z')
                {
                    t[i] = 'a';
                }
                else if (t[i] == 'я')
                {
                    t[i] = 'а';
                }
                else if (t[i] == 'Я')
                {
                    t[i] = 'А';
                }
                else
                {
                    Console.WriteLine("Вы ввели число!");
                }
            }
            this.text = new string(t);
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
        public ACipher(string text)
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
