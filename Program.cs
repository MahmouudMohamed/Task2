namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                char op ;
                List<int> listOfNumber = new List<int>();
                Console.WriteLine("Main Manu");
                Console.WriteLine("=======================================");
                do
                {
                    Console.WriteLine("P - Print Numbers");
                    Console.WriteLine("A - Add Number");
                    Console.WriteLine("M - Display The Mean Of Numbers");
                    Console.WriteLine("S - Display The Smallest Number");
                    Console.WriteLine("L - Display The Largest Number");
                    Console.WriteLine("F - Search About Element Index");
                    Console.WriteLine("C - Clear The List");
                    Console.WriteLine("Q - Qut");
                    Console.WriteLine("=========================================\n");
                    op = char.ToUpper(char.Parse(Console.ReadLine()));
                    if (op == 'P')
                    {
                        if (listOfNumber.Count == 0)
                        {
                            Console.WriteLine(" [] - the list is empty");
                            Console.WriteLine("=========================================\n");
                        }
                        else
                        {
                            int sortedList;
                            for (int i = 0; i < listOfNumber.Count; i++)
                            {
                                for (int x = i + 1; x < listOfNumber.Count; x++)
                                {

                                    if (listOfNumber[i] > listOfNumber[x])
                                    {
                                        sortedList = listOfNumber[x];
                                        listOfNumber[x] = listOfNumber[i];
                                        listOfNumber[i] = sortedList;
                                    }

                                }


                            }
                            Console.Write("[ ");
                            for (int i = 0; i < listOfNumber.Count; i++)
                            {
                                Console.Write($"{listOfNumber[i]} ");

                            }
                            Console.WriteLine("]");
                        }
                    }
                    else if (op == 'A')
                    {
                        bool numberDuplicat = false;
                        int number;
                        Console.Write("Enter Number To Add = ");
                        number = int.Parse(Console.ReadLine());
                        for (int i = 0; i < listOfNumber.Count; i++)
                        {
                            if (number == listOfNumber[i])
                            {
                                Console.WriteLine("This Number is already exist\n");
                                Console.WriteLine("=========================================");
                                numberDuplicat = true;
                            }
                        }
                        if (numberDuplicat != true)
                        {
                            listOfNumber.Add(number);
                            Console.WriteLine($"{number} is added successfully\n");
                            Console.WriteLine("=========================================");
                        }

                    }
                    else if (op == 'M')
                    {
                        if (listOfNumber.Count == 0)
                        {
                            Console.WriteLine("Can't Calculate the mean - No Data \n");
                            Console.WriteLine("=========================================");
                        }
                        else
                        {
                            int sum = 0;
                            int mean;
                            for (int i = 0; i < listOfNumber.Count; i++) { sum += listOfNumber[i]; }

                            mean = sum / listOfNumber.Count;
                            Console.WriteLine($"The mean = {(mean)}");

                        }
                    }
                    else if (op == 'S')
                    {
                        if (listOfNumber.Count == 0)
                        {
                            Console.WriteLine("Unable to Determine the Smallest Number - List is Ermpty");
                            Console.WriteLine("=========================================");
                        }

                        else
                        {
                            int smallestNumber = listOfNumber[0];
                            for (int i = 1; i < listOfNumber.Count; i++)
                            {
                                if (smallestNumber > listOfNumber[i])
                                {
                                    smallestNumber = listOfNumber[i];
                                }
                            }
                            Console.WriteLine($"The Smallest Number is {smallestNumber}");
                            Console.WriteLine("=========================================");
                        }
                    }  
                    else if (op == 'L')
                    {
                        if (listOfNumber.Count == 0)
                        {
                            Console.WriteLine("Unable to Determine the Largest Number - list is Ermpty");
                            Console.WriteLine("=========================================");
                        }

                        else
                        {
                            int largestNumber = listOfNumber[0];
                            for (int i = 1; i < listOfNumber.Count; i++)
                            {
                                if (largestNumber < listOfNumber[i])
                                {
                                    largestNumber = listOfNumber[i];
                                }
                            }
                            Console.WriteLine($"The Largest Number is {largestNumber}");
                            Console.WriteLine("=========================================");
                        }
                    }
                    else if (op=='F') {
                        bool findNumber = false;
                        int numberOfSearch;
                        Console.Write("Enter Number To Search = ");
                        numberOfSearch = int.Parse(Console.ReadLine());
                        for (int i = 0; i < listOfNumber.Count; i++)
                        {
                            if (numberOfSearch == listOfNumber[i])
                            {
                                Console.WriteLine($"The Number:{numberOfSearch} is Exist At Index ({i})\n");
                                Console.WriteLine("=========================================");
                                findNumber = true;
                            }
                        }
                        if (findNumber != true)
                        {
                            Console.WriteLine($"The Number:{numberOfSearch} is Not Exist\n");
                            Console.WriteLine("=========================================");
                        }
                        
                    }
                    else if (op == 'C')
                    {
                        if (listOfNumber.Count == 0)
                        {
                            Console.WriteLine("[] - The List is Empty");
                            Console.WriteLine("=========================================");
                        }
                        else
                        {
                            listOfNumber.Clear();
                            Console.WriteLine("List Cleared Successfully");
                            Console.WriteLine("=========================================\n");
                        }

                    }
                    else if (op == 'Q')
                    {
                        Console.WriteLine("GoodBye");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("NOT Found This Choice !");
                        Console.WriteLine("=========================================");
                    }
                }
                while (op != 'Q');

                }
    }
        
         } 
} 
                  

            
        
    

