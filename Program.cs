using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int[] numbersofArray = new int[] { -1,5,0,9,98,76};
            Program value = new Program();
            int minimumnumber = value.FindMinimumNumber(numbersofArray);
            Console.WriteLine();
            Console.WriteLine($"minimum value is ::" + minimumnumber);
            int maximumnumber=value.FindMaximumNumber(numbersofArray);
            Console.WriteLine();
            Console.WriteLine($"maximum value is ::" +maximumnumber);
            int sum = value.FindSum(numbersofArray);
            Console.WriteLine();
            Console.WriteLine($"sum of all numbers is::" + sum);
            double average = value.FindAverage(numbersofArray);
            Console.WriteLine();
            Console.WriteLine($"average of all numbers is ::" + average);
        }
        public int FindMinimumNumber(int[] array)
        {
         int lengthofArray=array.Length;
         int i;
         for(i=0;i<lengthofArray;++i)
            {
                int presentelement=array[i];
                int j = i - 1;
                while(j>=0 && array[j] <presentelement)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = presentelement;
            }
          for(i=0;i<lengthofArray;++i)
             Console.WriteLine(array[i]+ " ");
            int minimumnumber = array[5];
            return minimumnumber ;
            


          
        }
        public int FindMaximumNumber(int[]array)
        {
            int lengthofArray = array.Length;
            int i;
            for (i = 0; i < lengthofArray; ++i)
            {
                int presentelement = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > presentelement)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = presentelement;
            }
            for (i = 0; i < lengthofArray; ++i)
                Console.WriteLine(array[i] + " ");
            int maximumnumber = array[5];
            return maximumnumber;



           
        }
        public int FindSum(int[] array)
        {
            int sum = 0;
            foreach(var item in array)
            {
                sum = sum + item;
            }
            return sum;

        }
       
        public double FindAverage(int[] array)
        {
            int sum = 0;
            double avg;
            int length=array.Length;
            foreach(var item in array)
            {
                sum = sum + item;
            }
            avg = sum / length;
            return avg;
                
        }
     





        /*public void output(double afr)
        {
            Console.WriteLine("Average is :" + afr);

        }

        public double average()
        {
            double num1, num2, num3, avg;
            Console.WriteLine("Enter Your First Number");
            num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Second Number");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Your Third Number");
            num3 = Convert.ToDouble(Console.ReadLine());
            avg = (num1 + num2 + num3) / 3;
            return avg;

        }*/


    }
}
