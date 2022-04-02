using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArrayVSList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textOne = Console.ReadLine();
            string[] textOneArray = textOne.Split(' ');
            string textTwo = Console.ReadLine();
            string[] textTwoArray = textTwo.Split(' ');
            List<string> listText = new List<string>();

            AddElement(textOneArray, listText);
            AddElement(textTwoArray, listText);            
            ShowText(listText);
            
        }

        static void AddElement(string[] array, List<string> text )
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (text.Contains(array[i]) == false)
                {
                    text.Add(array[i]);
                }
            }
        }

        static void ShowText(List<string> text)
        {
            foreach (string word in text)
            {
                Console.Write(word + " ");
            }
        }
    }
}
