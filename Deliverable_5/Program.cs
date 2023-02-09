// Name: Maxwell Ahmadi
// Date: 02/09/23
// Project: Deliverable_5
// Description: 

// parameter: number or data type*
// argument: value that will be assigned later to a parameter




using System.Transactions;

namespace Deliverable_5
{
    class Program
    {

        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for (int i =0; i < array_len; i++)
            {
                MyArray[i] = random.Next(10,50);
            }
            return MyArray;
        }

        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Boolean done = false;

            while(!done)

            try
            {

                while (true)
                {

                    Console.WriteLine("Enter an integer between 5 and 15: ");
                    int input = int.Parse(Console.ReadLine());

                    int[] sample_Array = random_array(input);

                    if (input >= 5 && input <= 15)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("The elements in the random array are: ");
                        foreach (int element in sample_Array)
                        {
                            Console.WriteLine(element + " ");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("Therefore, the sum is: " + sum(sample_Array));
                            break;
                    }

                    else
                    {
                        Console.WriteLine("Please enter a valid positive integer between 5 and 15!");
                    }
                }
                done = true;
            }
            catch
            {
                Console.WriteLine("Please enter an integer between 5 and 15, no text entry is allowed!");
            }

        }
    }
}