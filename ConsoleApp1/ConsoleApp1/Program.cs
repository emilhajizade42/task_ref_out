using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           

            int[] arr = { 1, 2, 3 };
            Push(ref arr, 55);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            string word = " Hikmet  Abbasov ";
            Trim(ref word);
            Console.WriteLine(word);


            int num = 35;
            LowPow(ref num);
            Console.WriteLine(num);

        }

        static void Push(ref int[] arr,int last)
        {
            int[] temp = new int[arr.Length+1];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            temp[arr.Length]=last;
             arr = temp;
        }

        static void Trim(ref string word)
        {
            string temp = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==' ')
                {
                    continue;
                }
                temp+=word[i];
            }
            word = temp;
        }

        static void LowPow(ref int num)
        {
            int count = 0;
            int i = 0; 
            while (i*i <= num)
            {
                count++;
                i++;
            }
            num = count-1;
        }





    }
}
