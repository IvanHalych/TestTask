using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace TestTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Textprocessing();
        }
        public static void Textprocessing()
        {
            string text = Read();
            if (text == null)
            {
                Console.WriteLine("Wrong path");
                Console.ReadLine();
            }
            else
            {
                string[] masiv = text.Split(new char[] { ' ', '\n' });
                char[] VowelsCharacters = new char[] { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Y', 'y' };
                int count = Count(masiv, VowelsCharacters);
                Console.WriteLine(count);
                Console.ReadLine();
            }
        }
        public static string Read()
        {
            string path = Console.ReadLine();
            if (Verify(path))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        return sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return null;
            }
            return null;
        }
        public static int Count(string[] masiv, char[] VowelsCharacters)
        {
            int count = 0;
            for (int k=0;k<masiv.Length;k++)
            {
                int countLetters = 0;
                for (int i = 0;i < masiv[k].Length;i++)
                {
                    for(int j = 0 ;j < VowelsCharacters.Length;j++)
                    {
                        if (masiv[k][i] == VowelsCharacters[j])
                        {
                            countLetters++;
                            break;
                        }
                    }
                }
                if (countLetters == masiv[k].Length)
                    count++;
            }
            return count;
        }
        public static bool Verify(string str)
        {
            string pattern = @"^((\w+[\\])+\w+[.txt])|(\w+[.txt])$";
            if (Regex.IsMatch(str, pattern))
                return true;
            return false;
        }
    }
}
