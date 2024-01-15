using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabAssignment_02
{
    internal class LabClass
    {
        /// <summary>
        /// This method takes a list of numbers as an input from the user and returns that list.
        /// </summary>
        /// <returns></returns>
        public List<int> InputNumberList()
        {
            try
            {
                List<int> inputList = new List<int>();
                bool isTrue = true;

                while (isTrue)
                {
                    Console.Write("Enter number for a list or type 'stop' when you're done: ");
                    string inputStr = Console.ReadLine().ToLower();

                    if (inputStr == "stop")
                        isTrue = false;
                    else
                    {
                        if (int.TryParse(inputStr, out int inputNum))
                        {
                            inputList.Add(inputNum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter a valid number");
                        }
                    }
                }
                return inputList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // - - - - - - EXERCISE - 01 - - - - - -
        /// <summary>
        /// This method takes a number and a list of numbers from the user and finds the count of the number in the list
        /// </summary>
        public void SearchNumInList()
        {
            try
            {
                // Taking a number input from user
                Console.WriteLine("Enter a number to check in a list : ");
                int searchNum;

                while (!int.TryParse(Console.ReadLine(), out searchNum))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number");
                    Console.WriteLine("Enter a number to check in a list : ");
                }

                // Taking a list of numbers from user
                List<int> inputList = InputNumberList();

                // Checking how many times searchNum appears in inputList
                int count = 0;
                for (int i = 0; i < inputList.Count; i++)
                {
                    if (inputList[i] == searchNum)
                    {
                        count++;
                    }
                }

                Console.WriteLine("");
                Console.WriteLine($"The count of {searchNum} in the list is {count}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // - - - - - - EXERCISE - 02 - - - - - -
        /// <summary>
        /// This method takes two lists of characters from the user and prints the elements in the first list that are not in
        /// the second list.
        /// </summary>
        public void RemoveElementsFromList()
        {
            try
            {
                // Taking first list of characters from user
                List<char> firstList = new List<char>();
                bool isTrue = true;

                while (isTrue)
                {
                    Console.Write("Enter a letter for first list or type 'stop' when you're done: ");
                    string firstListInput = Console.ReadLine().ToLower();

                    if (firstListInput == "stop")
                        isTrue = false;
                    else
                    {
                        if (char.TryParse(firstListInput, out char firstListChar))
                        {
                            firstList.Add(firstListChar);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter a valid letter");
                        }
                    }
                }

                Console.WriteLine("");

                // Taking second list of characters from user
                isTrue = true;
                List<char> secondList = new List<char>();

                while (isTrue)
                {
                    Console.Write("Enter a letter for second list or type 'stop' when you're done: ");
                    string secondListInput = Console.ReadLine().ToLower();

                    if (secondListInput == "stop")
                        isTrue = false;
                    else
                    {
                        if (char.TryParse(secondListInput, out char secondListChar))
                        {
                            secondList.Add(secondListChar);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input! Please enter a valid letter");
                        }
                    }
                }

                Console.WriteLine("");

                // Checking the lists for the same character

                List<char> thirdList = new List<char>(firstList);

                foreach (char c in firstList)
                {
                    if (secondList.Contains(c))
                    {
                        thirdList.Remove(c);
                    }
                }

                // Printing the remaining elements in first list
                StringBuilder result = new StringBuilder();

                foreach (char c in thirdList)
                {
                    result.Append($"{c} ");
                }
                Console.WriteLine($"The elements in first list which are not in second list are: {result} ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // - - - - - - EXERCISE - 03 - - - - - -
        public void SlicingList()
        {
            try
            {
                Console.WriteLine("Slicing the list into subset");
                Console.WriteLine("");

                // Taking a number input from user
                Console.WriteLine("Enter minimum index : ");
                int minIndex;

                while (!int.TryParse(Console.ReadLine(), out minIndex))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number");
                    Console.WriteLine("Enter minimum index : ");
                }

                Console.WriteLine("Enter maximum index : ");
                int maxIndex;

                while (!int.TryParse(Console.ReadLine(), out maxIndex))
                {
                    Console.WriteLine("Invalid input! Please enter a valid number");
                    Console.WriteLine("Enter maximum index : ");
                }

                // Taking list as input from user
                List<int> inputList = InputNumberList();

                // Checking the index range
                if (minIndex < 0 || maxIndex < 0 || maxIndex >= inputList.Count || minIndex > maxIndex)
                {
                    throw new IndexOutOfRangeException();
                }

                // Making subset of the list
                int count = maxIndex - minIndex + 1;
                List<int> subsetList = inputList.GetRange(minIndex, count);

                Console.WriteLine("");
                // Length of the list
                Console.WriteLine("The length of the subset list is: {0}", count);

                // Minimum value in the list
                Console.WriteLine("The minimum value in the list is: {0}", MinValueInList(subsetList));

                // Maximum value in the list
                Console.WriteLine("The maximum value in the list is: {0}", MaxValueInList(subsetList));

                // Sum of intergers in the list
                Console.WriteLine("The sum of integers in the list is: {0}", SumOfIntegersInList(subsetList));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); ;
            }
        }

        /// <summary>
        /// This method finds and returns the minimum value in an integer list
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        public int MinValueInList(List<int> inputList)
        {
            try
            {
                int minValue = inputList[0];

                for (int i = 1; i < inputList.Count; i++)
                {
                    if (inputList[i] < minValue)
                    {
                        minValue = inputList[i];
                    }
                }
                return minValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method finds and returns the maximum value in an integer list
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        public int MaxValueInList(List<int> inputList)
        {
            try
            {
                int maxValue = inputList[0];

                for (int i = 1; i < inputList.Count; i++)
                {
                    if (inputList[i] > maxValue)
                    {
                        maxValue = inputList[i];
                    }
                }
                return maxValue;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method finds and returns the sum of all integers in an integer list
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns></returns>
        public int SumOfIntegersInList(List<int> inputList)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < inputList.Count; i++)
                {
                    sum += inputList[i];
                }
                return sum;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // - - - - - - EXERCISE - 04 - - - - - -
        /// <summary>
        /// This method takes in a sequence of numbers as an input and converts it into a list and displays the count of
        /// positive even, negative even, positive odd, negative odd and zero.
        /// </summary>
        public void SequenceOfInputNumbers()
        {
            Console.WriteLine("Enter a sequence of numbers separated by space and type 'done' at the end.");
            string userString = Console.ReadLine().ToLower();
            List<string> stringList = userString.Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<int> inputNumberList = new List<int>();
            bool invalidInput = false;

            foreach (string str in stringList)
            {
                if (str == "done") break;

                if (int.TryParse(str, out int inputNum))
                {
                    inputNumberList.Add(inputNum);
                }
                else
                {
                    invalidInput = true;
                    break;
                }
            }

            if (invalidInput)
            {
                Console.WriteLine("Invalid input! Please enter valid integers.");
            }
            else
            {
                // Displaying number of positive even and negative even numbers
                NoOfEvenNumbers(inputNumberList);
                // Displaying number of positive odd and negative odd numbers
                NoOfOddNumbers(inputNumberList);
                // Displaying number of zeroes
                NoOfZeroes(inputNumberList);
            }
        }

        /// <summary>
        /// This methods takes in a list as an argument and prints the count of positive even and negative even numbers.
        /// </summary>
        /// <param name="list"></param>
        public void NoOfEvenNumbers(List<int> list)
        {
            try
            {
                int positiveCount = 0;
                int negativeCount = 0;

                foreach (int i in list)
                {
                    if (i > 0 && i % 2 == 0) positiveCount++;
                    if (i < 0 && i % 2 == 0) negativeCount++;
                }

                Console.WriteLine("The number of positive even numbers in the list is: {0}", positiveCount);
                Console.WriteLine("The number of negative even numbers in the list is: {0}", negativeCount);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This methods takes in a list as an argument and prints the count of positive odd and negative odd numbers.
        /// </summary>
        /// <param name="list"></param>

        public void NoOfOddNumbers(List<int> list)
        {
            try
            {
                int positiveCount = 0;
                int negativeCount = 0;

                foreach (int i in list)
                {
                    if (i > 0 && i % 2 == 1) positiveCount++;
                    if (i < 0 && i % 2 == -1) negativeCount++;
                }

                Console.WriteLine("The number of positive odd numbers in the list is: {0}", positiveCount);
                Console.WriteLine("The number of negative odd numbers in the list is: {0}", negativeCount);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This methods takes in a list as an argument and prints the count of zero.
        /// </summary>
        /// <param name="list"></param>
        public void NoOfZeroes(List<int> list)
        {
            try
            {
                int count = 0;
                foreach (int i in list)
                {
                    if (i == 0) count++;
                }
                Console.WriteLine("The number of zeroes in the list is: {0}", count);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}