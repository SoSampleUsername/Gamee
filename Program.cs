using System;
using System.Linq;

namespace С1
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 254;
            //Console.WriteLine(b);
            //Console.WriteLine($" {short.MaxValue}, {short.MinValue}");
            //Console.WriteLine($" {long.MaxValue}, {long.MinValue}");
            //Console.WriteLine($" {int.MaxValue}, {int.MinValue}");
            //Console.WriteLine($" {float.MaxValue}, {float.MinValue}");
            //Console.WriteLine($" {double.MaxValue}, {double.MinValue}");
            //Console.WriteLine($" {decimal.MaxValue}, {decimal.MinValue}");
            //decimal dec = 2.50m;
            //Console.WriteLine(b);
            //Console.WriteLine($" {UInt32.MaxValue}, {UInt32.MinValue}");
            //-----------------------------------------------------------------------------------------------------------
            //int variable = 10;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Start----------------------");
            //    Console.WriteLine($" Before {variable}");
            //    Console.WriteLine($" Increment {variable--}");
            //    Console.WriteLine($" After {variable}");
            //    Console.WriteLine("End------------------------");
            //}
            //-------------------------------------------------------------------------------------------------
            //!!!!STRING BUILDER!!!!
            //----------------------------------------------------------------------------------------
            //bool b = true;
            //float age = 17;
            //if (b = age >= 18 && age < 50)
            //{
            //    console.writeline("access granted");
            //}
            //else
            //{
            //    console.writeline("access denied");
            //}
            //-----------------------------------------------------------------------------    
            //for (int i = 0; i <= 20; i++)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            Console.WriteLine($"{i} SampleCase");
            //            break;

            //        case 10:
            //            Console.WriteLine($"{i} SampleCase");
            //            break;

            //        case 20:
            //            Console.WriteLine($"{i} SampleCase");
            //            break;

            //        default:
            //            Console.WriteLine($"{i} Default case");
            //            break;
            //    }
            //}
            //-----------------------------------------------------------------------------------------------------------
            //string[] kekush = new string[10] ;
            //kekush[0] = "one";
            //kekush[1] = "two";
            //kekush[2] = "three";
            //kekush[3] = "four";
            //kekush[4] = "five";
            //kekush[5] = "six";
            //kekush[6] = "seven";
            //kekush[7] = "eight";
            //kekush[8] = "nine";
            //kekush[9] = "ten";
            //Console.Write($"{kekush[0]},{kekush[1]},{kekush[2]},{kekush[3]},{kekush[4]},{kekush[5]},{kekush[6]},{kekush[7]},{kekush[8]},{kekush[9]}\n");
            //for (int i = 0; i < kekush.Length; i++)
            //{
            //    Console.Write($"{kekush[i]}, ");

            //}
            //Console.Write("\n");
            //foreach (string item in kekush)
            //{
            //    Console.Write($"{item}, ");
            //}
            //---------------------------------
            //int rows = 2;
            //int columns = 3;
            //int[,] myArr = new int[2, 3];
            //myArr[0,0] = 10;
            //int d = 10;
            //for (int i = 0; i < rows; i++)
            //{

            //    for (int j = 0; j < columns; j++)
            //    {
            //        myArr[i, j] = myArr[i -1, j]+d;
            //    }
            //}     

            //for (int i = 0; i < rows; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine("1st row");
            //    }
            //    else
            //    {
            //        Console.WriteLine("2nd row");
            //    }

            //    for (int j = 0; j < columns; j++)
            //    {
            //        Console.Write($"{myArr[i, j]} \t");

            //    }
            //    Console.WriteLine();
            //    }
            //------------------------------------------

            //int n;
            //Console.WriteLine("Vvedute n");
            //n = Convert.ToInt32(Console.ReadLine());
            //int[] x = new int[n,n];

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Vvedute {0} element massuva", i);
            //    x[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //----------------------------------------
            //int size = 0;
            //do
            //{                
            //    size = ReadInt("Size: ");
            //}
            //while (size < 0);



            //int[,] myMassive = new int[size, size];

            //    for (int i = 0; i < size; i++)
            //    {

            //        for (int k = 0; k < size; k++)
            //        {
            //            myMassive[i, k] = (i + k) % 2 == 1 ? 0 : (i + 1) * (k + 1);                        
            //        }
            //    }
            //ShowArray(size, myMassive); 


            //static void ShowArray(int arraySize, int[,] myMassive)
            //{
            //    for (int i = 0; i < arraySize; i++)
            //    {
            //        Console.WriteLine();
            //        for (int k = 0; k < arraySize; k++)
            //        {                      
            //            Console.Write("{0}\t", myMassive[i, k]);
            //        }
            //    }
            //}

            //static int ReadInt(string q)
            //{
            //    bool @continue = true;
            //    int size = 0;
            //    do
            //    {
            //        Console.WriteLine("Size: ");
            //        string input = (Console.ReadLine());
            //        @continue = !int.TryParse(input, out size);
            //        ////if(size < 0) @continue = true; 
            //    }
            //    while (@continue);
            //    return size;
            //}
            //----------------------------------------------------------

            //int[,] array = new int[8, 8];    
            //Random rand = new Random();

            //for (int i = 0; i < 8; i++)
            //{
            //    for (int k = 0; k < 8; k++)
            //    {
            //        array[i, k] = rand.Next(100, 999);
            //        Console.Write("{0}\t", array[i, k]);
            //    }
            //    Console.WriteLine();


            //}
            //static int MaxElement(int[,] array)
            //{
            //    int maxElement2 = array[0, 0];
            //    int maxElement = array[0, 0];
            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(0); j++)
            //        {
            //            if (maxElement < array[i, j])
            //            {
            //                maxElement2 = maxElement;
            //                maxElement = array[i, j];
            //            }
            //        }

            //    }
            //    Console.WriteLine($"1Max: {maxElement}");               
            //    return maxElement2;                
            //}
            //Console.WriteLine($"2Max: {MaxElement(array)}");
            //----------------------------------------------------------

            static int Factorial(int n)
            {
                int factor = 1;
                for (int i = 0; i <=n ; i++)
                {
                    factor =factor* i;
                }                
                return factor;
                
            }
            Console.WriteLine(Factorial(10));


        }

    }
}
