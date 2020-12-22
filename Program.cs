using System;


namespace JuggerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many symbols do you want to have?");
            int numberOfSymbols = Convert.ToInt32(Console.ReadLine());
            int[] myArray = new int[numberOfSymbols];

            Random rnd = new Random();

            for (int i = 0; i < myArray.Length; i++)
            {
                //Console.Write($"Enter {numberOfSymbols--} numbers ", i + 1);
                myArray[i] = rnd.Next(0, 100);
            }


            Console.WriteLine("Min To Max {0}", string.Join(" / ", BubbleSortMax(myArray)));
            Console.Write("Max To Min {0}", string.Join(" / ", BubbleSortMin(myArray)));
            Console.ReadKey();

        }

        static int[] BubbleSortMax(int[] myArray)
        {
            int temp;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] > myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            return myArray;
        }

        static int[] BubbleSortMin(int[] myArray)
        {
            int temp;
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            return myArray;
        }

    }
}
