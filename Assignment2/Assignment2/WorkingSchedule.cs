namespace Assignment2;

class WorkingSchedule
{
    public void Start()
    {
        ShowMenu();
        GetUserInput();

    }

    //Show  menu to user
    private void ShowMenu()
    {
        Console.WriteLine("           YOUR WORK SCHEDULE           ");
        Console.WriteLine("-------------------------------------------\n");
        Console.WriteLine("1 Show a list of the weenkends to work.");
        Console.WriteLine("2 Show a list of the nights to work.");
        Console.WriteLine("0 Exit.");


    }

    // get input from the user and handle the user's selection
    private void GetUserInput()
    {
        bool isDone = false;

        while (!isDone)
        {
            Console.Write("Your choice: ");
            string userinput = Console.ReadLine();
            int userOption;
            if (!int.TryParse(userinput, out userOption))
            {
                Console.WriteLine("\"Invalid input! \\\"Please choose numbers from the Menu\\\"\"");
                continue;
            }
            switch (userOption)
            {
                case 0:
                    Console.WriteLine("You're Exiting the Program");
                    isDone = true;
                    break;
                case 1:
                   
                    Console.WriteLine("\nWeekends to Work:\n");
                    ListOfWeekendToWork();
                    break;

                case 2:
                    
                    Console.WriteLine("\nNights to Work:\n");
                    ListOfNightToWork();
                    break;


            }

        }

    }



    // list all the weekends that the employee needs to work
    private void ListOfWeekendToWork()
    {
        int startWeek = 1;
        int endWeek = 52;
        int currentWeeksInRow = 1;
        int weeksInRow = 4; // number of weeks to display in each row

        Console.WriteLine("          Your Weekends Schedule :\n");
        Console.WriteLine("--------------------------------------------------\n");

        for (int week = startWeek; week <= endWeek; week++)
        {
            // the employee needs to work every other weekend starting from week 1
            if ((week % 2 == 1) && (currentWeeksInRow <= weeksInRow))
            {
                // display the week number in a formatted string
                Console.Write($"Week {week,-5}");
                currentWeeksInRow++;
            }

            // if we've printed out enough weeks in a row, start a new line and reset the counter
            if (currentWeeksInRow > weeksInRow)
            {
                Console.WriteLine();
                currentWeeksInRow = 1;
            }
        }
        Console.WriteLine();
    }





    // list all the nights that the employee needs to work
    private void ListOfNightToWork()
    {
        int startWeek = 1;
        int endWeek = 52;
        int currentWeeksInRow = 1;
        int weeksInRow = 4; // number of weeks to display in each row

        Console.WriteLine("Your Nightshift Schedule:\n");
        Console.WriteLine("--------------------------------------------------\n");


        for (int week = startWeek; week <= endWeek; week++)
        {
            // the employee needs to work a nightshift every 4th week starting from week 1
            if ((week % 4 == 1) && (currentWeeksInRow <= weeksInRow))
            {
                // display the week number in a formatted string
                Console.Write($"Week {week,-5}");
                currentWeeksInRow++;
            }

            // if we've printed out enough weeks in a row, start a new line and reset the counter
            if (currentWeeksInRow > weeksInRow)
            {
                Console.WriteLine();
                currentWeeksInRow = 1;
            }
        }
        Console.WriteLine();
    }






}