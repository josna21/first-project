namespace Assignment2;

class MathWorK
{


    private void Calculate()
    {
        bool done = false;
        while (!done)
        {

            Console.WriteLine("****** THE CALCULATOR ******\n");
            Console.Write("Enter start number: ");
            int startNum = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int endNum = int.Parse(Console.ReadLine());


            if (startNum >= endNum)
            {
                int tempNum = startNum;
                startNum = endNum;
                endNum = tempNum;

                
                int sum = SumNumbers(startNum, endNum);
                Console.WriteLine(sum);
                PrintMultiplicationTable();
                PrintEvenNumber(startNum, endNum);
                PrintOddNumbers(startNum, endNum);
                CalculateSqaureRoots(startNum, endNum);
                

            }
            else
            {
                int sum = SumNumbers(startNum, endNum);
                Console.WriteLine(sum);

                PrintMultiplicationTable();
                PrintEvenNumber(startNum, endNum);
                PrintOddNumbers(startNum, endNum);
                CalculateSqaureRoots(startNum, endNum);
                


            }


            done = ExitCalculation();
            

        }
    }
     //Method to calculate the squareroot.
    private void CalculateSqaureRoots(int startNum, int endNum)
    {
        Console.WriteLine();
        Console.WriteLine("  ****** SQUARE ROOT *******");
        // Loop over each number in the range from startNum to endNum
        for (int number = startNum; number <= endNum; number++)
        {
            // Display the current number and the range for which its square root is being calculated
            Console.Write($"Sqrt of ({number} to {endNum}) is: ");
            // Loop over each number from the current number to the end of the range
            for (int index = number; index <= endNum; index++)
            {
                // Calculate the square root of the current number
                double squareRoot =  Math.Sqrt(index);  // calculate the square root of the current number
                Console.Write($"{string.Format("{0,6:f2}",squareRoot)}");

            }
            Console.WriteLine(); // this is to create a mew line at the end of each iteration
        }


    }



    private bool ExitCalculation()
    {
        //bool done = false; // initiallization
        bool responseOk = false; // initialliazation
        while (!responseOk)
        {
            Console.WriteLine("\nDo you want to exit MathWork (y/n)?");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                responseOk = true;
              return true;
            }
            else if (userInput == "n") 
            {
               
                responseOk = true;
                return false;

            }
            else
            {

                responseOk = false;
                Console.WriteLine("\"Invalid input\". Please enter 'y' or 'n'.");

            }


        }
        return true;

    }

    private void PrintEvenNumber(int startNum, int endNum)
    {
        Console.WriteLine($"\n**** Even numbers between {startNum} and {endNum} ***** ");
        for (int number = startNum; number <= endNum; number++)
        {

            if (number % 2 == 0)
            {

                Console.Write(number + " ");

            }



        }


    }

    private void PrintMultiplicationTable()
    {
        //Method to Display a multiplication table for numbers 1 to 12
        Console.WriteLine("\nMultiplication Table from 1 to 12!\n");
        Console.WriteLine("************************************************************************************************");
        for (int rowNum = 1;  rowNum <= 12; rowNum++)
        {
            for (int column = 1; column <= 12; column++)
            {
                Console.Write(rowNum * column + "\t");
            }

            Console.WriteLine();
        }
        //Console.ReadLine();

    }

    private void PrintOddNumbers(int startNum, int endNum)
        //Method to check if the number is odd
    {
        Console.WriteLine($"\n**** Odd numbers between {startNum} and {endNum} ***** ");
        for (int number = startNum; number <= endNum; number ++)
        {

            if (number % 2 != 0)
            {

                Console.Write(number + " ");
            }


        }



    }
   

    public void Start()
    {
        Calculate();

    }


    



    private int SumNumbers(int startNum, int endNum)
        //method to sum two numbers
        
    {
        int sum = 0;
        for (int num = startNum; num <=endNum;num++)
        {
             sum += num;
        }

        Console.Write($"\nThe sum of the numbers between {startNum} and {endNum} is: ");

        return sum;

    }



}
