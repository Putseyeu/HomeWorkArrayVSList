using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkArrayVSList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textOne = Console.ReadLine();
            string[] textOneArray = textOne.Split(' ');
            string textTwo = Console.ReadLine(); 
            string[] textTwoArray = textTwo.Split(' ');
            string[] textAllArray = new string[textOneArray.Length + textTwoArray.Length];
            List<string> listAllOne = new List<string>();
            List<string> listAllTwo = new List<string>();

            for (int i = 0; i < textOneArray.Length; i++)
            {
                textAllArray[i] = textOneArray[i];
            }

            for (int i = 0; i < textTwoArray.Length; i++)
            {
                textAllArray[textOneArray.Length + i] = textTwoArray[i];
            }

            for (int i = 0; i < textAllArray.Length; i++)
            {
                listAllOne.Add(textAllArray[i]);

            }

            listAllTwo = listAllOne;

            for (int i = 0; i < listAllOne.Count; i++)
            {
                for (int j = i + 1; j < listAllOne.Count; j++)
                {
                    if (listAllOne[i] == listAllTwo[j])
                    {
                        listAllTwo.RemoveAt(j);
                    }
                }
            }

            foreach (var word in listAllTwo)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
        }
    }
}
