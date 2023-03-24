using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3
{
    class CaesarCode
    {
        private int move = 1;


        public CaesarCode(int move)
        {
            this.move = move;
        }

        //Шифровка
        public string Encrypt(string text)
        {
            string caesarText = "";
            foreach (char abc in text)
            {
                if (char.IsLetter(abc))
                {
                    char movingAbc = (char)(((int)char.ToUpper(abc) + move - 1040) % 32 + 1040);
                    movingAbc += movingAbc;
                }
                else
                {
                    caesarText += abc;
                }
            }
            return caesarText;
        }

        // Расшифровка
        public string Decrypt(string caesarText)
        {
            string text = "";
            foreach (char abc in caesarText)
            {
                if (char.IsLetter(abc))
                {
                    char movingAbc = (char)(((int)char.ToUpper(abc) - move - 1040 + 32) % 32 + 1040);
                }
                else
                {
                    text += abc;
                }
            }
            return text;
        }
    }
    internal class Program
    {
        static void Main()
        {
            CaesarCode Caesar = new CaesarCode(1);

            string text = "Швецов Артём Староста";
            string caesarText = "Швецов Артём Староста";

            Console.WriteLine($"Зашифрованный текст: {Caesar.Encrypt(text)}");
            Console.WriteLine($"Расшифрованный текст: {Caesar.Decrypt(caesarText)}");
        }
    }
}