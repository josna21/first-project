namespace Assignment2;

class TemperatureConverter
{
    public void Start()
    {
        ShowMenu();
        GetUsersInput();


    }

    private void ShowMenu()
    {
        Console.WriteLine("-------------------------------------------\n");

        Console.WriteLine("       TEMPERATURE CONVERTER\n");

        Console.WriteLine("-------------------------------------------\n");

        Console.WriteLine("   Celsius to Fahrenheit  : 1");
        Console.WriteLine("   Celsius to Fahrenheit  : 2");
        Console.WriteLine("   Exit                   : 0");

        Console.WriteLine("\n-------------------------------------------");
    }

    private void GetUsersInput()

    {
        bool done = false;

        while (!done)
        {

            Console.Write("Your choice: ");
            string usersinput = Console.ReadLine();
            int usersOption;

            if (!int.TryParse(usersinput, out usersOption))
            {
                Console.WriteLine("\"Invalid input! \\\"Please choose numbers from the Menu\\\"\"");
                continue; // Continue the loop
            }


            switch (usersOption)
            {
                case 0:
                    Console.WriteLine("You're Exiting the Program");
                    done = true;
                    break;
                case 1:
                    ConvertCelsiusToFahrenheit();
                    //Console.WriteLine("Trying thos code ");

                    break;
                case 2:
                    ConvertFahrenheitToCelsius();
                    Console.WriteLine("Function 2");
                    break;

                default:
                    if (usersOption > 2 || usersOption < 0)
                    {
                        Console.WriteLine("Invalid input! \"Please choose numbers from the Menu\"");
                    }
                    else
                    {
                        // do something if the value is less than or equal to 2
                    }
                    break;

            }


        }
        // Move this line is inside the while loop to ensure that the loop is executed at least once
        ExitCalculation();






    }

    private void ConvertCelsiusToFahrenheit()

    {
        Console.WriteLine("++++++ CONVERT FROM CELSIUS TO FAHRENHEIT ++++++\n");

        double numMin = 0.00;
        const double numMax = 100.00;

        for (double Celsius = numMin; Celsius <= numMax; Celsius++)
        {
            // Console.WriteLine(num);
            // the formula to convert Celsius to fahreinhet is F = (C x 1.8)+ 32

            double Fahrenheit = Math.Round((Celsius * 1.8) + 32.00, 2);
            Console.WriteLine($"\n{Celsius} C =   {Fahrenheit.ToString("F2")} F"); // ToString("F2") is a format string that specifies how to format
                                                                                   // a numeric value as a string. In this case, "F2" indicates that
                                                                                   // the number should be formatted with fixed-point notation and 2 decimal places
                                                                                   // Out put in this case would be for ex:- 100.00.
            Console.WriteLine("--------------------------------------------------\n");






        }





    }

    private void ConvertFahrenheitToCelsius()
    {
        Console.WriteLine("++++++ CONVERT FROM FAHRENHEIT TO CELSIUS ++++++\n");


        double numMin = 0.00;
        const double numMax = 212.00;

        for (double Fahrenheit = numMin; Fahrenheit <= numMax; Fahrenheit++)
        {
            // Console.WriteLine(num);
            // the formula to convert Celsius to fahreinhet is F = (C x 1.8)+ 32
            if (Fahrenheit % 4 == 0)

            {
                double Celsius = Math.Round((Fahrenheit - 32.00) / 1.8, 2);
                Console.WriteLine($"\n{Fahrenheit} F =   {Celsius.ToString("F2")} C"); //line 77 for explanation for string(F2)
                Console.WriteLine("--------------------------------------------------\n");


            }


        }


    }



    private bool ExitCalculation()
    {
        //bool done = false; // initiallization
        bool responseOk = false; // initialliazation
        while (!responseOk)
        {
            Console.Write("Do you want to exit the program (y/n)?");
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
















}