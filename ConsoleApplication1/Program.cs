using System;
using System.Text;

namespace ConsoleApplication1
{
    public class Program
    {
        static string Encode(string msg, string key)
        {
            int ascii;
            char newChar;
            var bufferKey
                = Encoding.UTF8.GetBytes(key);
            var encodedString = "";

            foreach (var chr in msg)
            {
                foreach (var Key in bufferKey)
                {
                    ascii = chr;
                    ascii += Key;
                    newChar = (char)ascii;
                    encodedString += newChar.ToString();
                    break;
                    
                }
            }
            return encodedString;
        }

        static string Decode(string msg, string key)
        {
            int ascii;
            char newChar;
            var bufferKey 
                = Encoding.UTF8.GetBytes(key);
            var encodedString = "";
            foreach (var chr in msg)
            {
                foreach (var Key in bufferKey)
                {
                    ascii = chr;
                    ascii -= Key;
                    newChar = (char)ascii;
                    encodedString += newChar.ToString();
                    break;
                    
                }
            }

            return encodedString;
        }
        
        public static void Main(string[] args)
        {
            int switchedOptions;
            Console.WriteLine("Şifreleme işlemleri");
            switchedOptions = int.Parse(Console.ReadLine());

            switch (switchedOptions)
            {
                case 1:
                    Console.WriteLine(Encode("merhaba", "abc"));
                    Console.WriteLine(Decode("ÎÆÓÉÂÃÂ", "abc"));
                    Console.WriteLine(Encode("merhaba", "xyz"));
                    Console.WriteLine(Decode("åÝêàÙÚÙ", "xyz"));
                    break;
                case 2:
                    Console.WriteLine(Decode("merhaba", "xyz"));
                    Console.WriteLine(Encode("merhaba", "abc"));
                    break;
            }
        }
    }
}