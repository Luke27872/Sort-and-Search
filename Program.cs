using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reads the text files into a string array

            string[] Net1 = System.IO.File.ReadAllLines("/Users/luke27872/Documents/UNI WORK/Algorithms and Complexity/Assessment 1/Search_and_Sort/Net_1_256.txt");
            string[] Net2 = System.IO.File.ReadAllLines("/Users/luke27872/Documents/UNI WORK/Algorithms and Complexity/Assessment 1/Search_and_Sort/Net_2_256.txt");
            string[] Net3 = System.IO.File.ReadAllLines("/Users/luke27872/Documents/UNI WORK/Algorithms and Complexity/Assessment 1/Search_and_Sort/Net_3_256.txt");
            string[] Net1_2048 = System.IO.File.ReadAllLines("/Users/luke27872/Documents/UNI WORK/Algorithms and Complexity/Assessment 1/Search_and_Sort/Net_1_2048.txt");
            string[] Net2_2048 = System.IO.File.ReadAllLines("/Users/luke27872/Documents/UNI WORK/Algorithms and Complexity/Assessment 1/Search_and_Sort/Net_2_2048.txt");
            string[] Net3_2048 = System.IO.File.ReadAllLines("/Users/luke27872/Documents/UNI WORK/Algorithms and Complexity/Assessment 1/Search_and_Sort/Net_3_2048.txt");

            //Converts the string array into int

            int[] Net1int = new int[Net1.Length];
            for (int i = 0; i < Net1.Length; i++)
            {
                string s = Net1[i];
                int r = Convert.ToInt32(s);
                Net1int[i] = r;

            }

            int[] Net2int = new int[Net2.Length];
            for (int i = 0; i < Net2.Length; i++)
            {
                string s = Net2[i];
                int r = Convert.ToInt32(s);
                Net2int[i] = r;

            }

            int[] Net3int = new int[Net3.Length];
            for (int i = 0; i < Net3.Length; i++)
            {
                string s = Net3[i];
                int r = Convert.ToInt32(s);
                Net3int[i] = r;

            }
            int[] Net1_2048int = new int[Net1_2048.Length];
            for (int i = 0; i < Net1_2048.Length; i++)
            {
                string s = Net1_2048[i];
                int r = Convert.ToInt32(s);
                Net1_2048int[i] = r;

            }
            int[] Net2_2048int = new int[Net2_2048.Length];
            for (int i = 0; i < Net2_2048.Length; i++)
            {
                string s = Net2_2048[i];
                int r = Convert.ToInt32(s);
                Net2_2048int[i] = r;

            }
            int[] Net3_2048int = new int[Net3_2048.Length];
            for (int i = 0; i < Net3_2048.Length; i++)
            {
                string s = Net3_2048[i];
                int r = Convert.ToInt32(s);
                Net3_2048int[i] = r;

            }

            //Asks the user to select an array to be loaded

            Console.WriteLine("Please select an array to be loaded (1,2,3,4,5,6)");
            int arraySelect = Convert.ToInt32(Console.ReadLine());

            //Takes the users input a displays the selected array

            if (arraySelect == 1)
            {
                Console.WriteLine();
                foreach (int line in Net1int)
                {
                    Console.WriteLine("\t" + line);
                }
                Menu(Net1int);
            }
            if (arraySelect == 2)
            {
                Console.WriteLine();
                foreach (int line in Net2int)
                {
                    Console.WriteLine("\t" + line);
                }
                Menu(Net2int);
            }
            if (arraySelect == 3)
            {
                Console.WriteLine();
                foreach (int line in Net3int)
                {
                    Console.WriteLine("\t" + line);
                }
                Menu(Net3int);
            }
            if (arraySelect == 4)
            {
                Console.WriteLine();
                foreach (int line in Net1_2048int)
                {
                    Console.WriteLine("\t" + line);
                }
                Menu(Net1_2048int);
            }
            if (arraySelect == 5)
            {
                Console.WriteLine();
                foreach (int line in Net2_2048int)
                {
                    Console.WriteLine("\t" + line);
                }
                Menu(Net2_2048int);
            }
            if (arraySelect == 6)
            {
                Console.WriteLine();
                foreach (int line in Net3_2048int)
                {
                    Console.WriteLine("\t" + line);
                }
                Menu(Net3_2048int);
            }
        }
        static void Menu(int[] a)
        {
            //Asks the user which sorting algorithm to use on the selected array

            Console.WriteLine("Which sorting algorithm do you want to use? (bubble, insertion)");
            string sortMethod = Console.ReadLine();
            if (sortMethod == "bubble")
            {
                //Asks the user to sort the array in ascending or descending order

                Console.WriteLine("Sort in Ascending order (a) or Descending order (d)?");
                string sortOrder = Console.ReadLine();
                if (sortOrder == "a")
                {
                    //Passes the array through the selected sorting algorithm

                    bubbleSortasc(a);
                    Console.WriteLine();
                    foreach (int line in a)
                    {
                        //Displays the sorted array

                        Console.WriteLine("\t" + line);
                    }
                }
                else if (sortOrder == "d")
                {
                    bubbleSortdes(a);
                    Console.WriteLine();
                    foreach (int line in a)
                    {
                        Console.WriteLine("\t" + line);
                    }
                }
            }
            if (sortMethod == "insertion")
            {
                Console.WriteLine("Sort in Ascending order (a) or Descending order (d)?");
                string sortOrder = Console.ReadLine();
                if (sortOrder == "a")
                {
                    InsertionSortasc(a);
                    Console.WriteLine();
                    foreach (int line in a)
                    {
                        Console.WriteLine("\t" + line);
                    }
                }
                else if (sortOrder == "d")
                {
                    InsertionSortdes(a);
                    Console.WriteLine();
                    foreach (int line in a)
                    {
                        Console.WriteLine("\t" + line);
                    }
                }
            }

            Console.WriteLine("Displaying only every 10th value of the sorted array:");
            Console.ReadLine();

            //Displays only every tenth value of the sorted array

            for (int i = 0; i < a.Length; i += 10)
            {
                Console.WriteLine(a[i]);
            }

            //Asks the user to input a value to search for in the selected array

            Console.WriteLine("Input a value to search for in the array:");
            int searchArray = Convert.ToInt32(Console.ReadLine());

            //Passes the users inputed value and array through the linear search algorithm

            Search(a, searchArray);
            if (Search(a, searchArray) == -1)
            {
                //If the value is not present in the array displays an error message

                Console.WriteLine("Value not found in array");
            }
            else
            {
                //Displays the location of the user inputed value if it is present in the array

                Console.WriteLine("The inputed value is found at position: " + Search(a, searchArray));
            }
        }
        static void bubbleSortasc(int[] a)
        {
            //Uses bubble sort to sort the array in ascending order

            int counter = 0;
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j + 1] < a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        counter++;
                    }

                }
            }

            //Displays to the user the number of steps the algorithm takes

            Console.WriteLine("Algorithm takes " + counter + " steps to complete.");
        }
        static void bubbleSortdes(int[] a)
        {
            //Uses bubble sort to sort the array in descending order

            int counter = 0;
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j + 1] > a[j])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        counter++;

                    }

                }
            }
            Console.WriteLine("Algorithm takes " + counter + " steps to complete.");
        }
        static void InsertionSortasc(int[] data)
        {
            //Uses insertion sort to sort the array in ascending order

            int counter = 0;
            int numSorted = 1;
            int index;
            int n = data.Length;
            while (numSorted < n)
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp < data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                    counter++;
                }
                data[index] = temp;
                numSorted++;
            }
            Console.WriteLine("Algorithm takes " + counter + " steps to complete.");
        }
        static void InsertionSortdes(int[] data)
        {
            //Uses bubble sort to sort the array in descending order

            int counter = 0;
            int numSorted = 1;
            int index;
            int n = data.Length;
            while (numSorted < n)
            {
                int temp = data[numSorted];
                for (index = numSorted; index > 0; index--)
                {
                    if (temp > data[index - 1])
                    {
                        data[index] = data[index - 1];
                    }
                    else
                    {
                        break;
                    }
                    counter++;
                }
                data[index] = temp;
                numSorted++;
            }
            Console.WriteLine("Algorithm takes " + counter + " steps to complete.");
        }
        static int Search(int[] list, int elementSought)
        {
            //Uses linear search to search the array for the user inputed array

            int counter = 0;
            bool found = false;
            int max = list.Length - 1;
            int currentElement = 0;
            do
            {
                if (list[currentElement] == elementSought)
                {
                    found = true;
                }
                else
                {
                    currentElement = currentElement + 1;
                }
                counter++;
            } while (!(found == true || currentElement > max));
            Console.WriteLine("Algorithm takes " + counter + " steps to complete.");
            if (found == true) 
            {
                return currentElement;
            }
            else
            {
                return -1;
            }
        }   
    }
}