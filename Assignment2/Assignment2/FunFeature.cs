namespace Assignment2;

class FunFeature
{
    private string? name;
    private string? email;
    
  
    //method to get name from user.
    public void Start()
    {
        Introduce();

         
       // SAVING THIS CODE TO ASK LECTURER WHY THE CODE ISN'T QUITING THE LOOP.
        

        bool repeat = false;
        do
        {
            // Call method to read number 1 to 7 and display the
            //name of the day (1= Monday, / = Sunday) with a comment
            PredictMyDay();
            //Calculate the length of a given text
            CalculateStringLength();

            repeat = RunAgain();
           

        } while (repeat);




    }

    private void ReadName()
    {
        Console.WriteLine("My name is Josephine and I am the Programmer of this application! ");
        Console.WriteLine("Tell me about yourself!\n ");

        Console.Write("Your first name please: ");
        string firstname = Console.ReadLine();
        Console.Write("Your last name please: ");
        string lastname = Console.ReadLine();
        string lastNameUpperCased = lastname.ToUpper(); // using .ToUpper to uppercase the entire name. 

        name = lastNameUpperCased + " " + firstname;

        Console.WriteLine("Hello " + name + " Welcome To my Application \n");

    }

    //method for gettin email from user

    private void ReadEmail()
    {
        Console.Write("Your email please: ");
        email = Console.ReadLine();

       
        Console.WriteLine("Nice to meet you " + name);
        Console.WriteLine("Your email is " + email + "\n");
    }


    private void PredictMyDay()
    {
        Console.WriteLine("****** FORTUNE TELLER ******");
        Console.Write("Select a number between 1 and 7: ");
        int  userinput = int.Parse(Console.ReadLine());

        switch (userinput)
        {

            case 1:
                Console.WriteLine(" Keep calm on Mondays! You can fall apart!");
                break;
            case 2:
            case 3:
                Console.WriteLine("Tuesdays and Wednasdays break your heart!");
                break;
            
               
            case 4:
                Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                break;
            case 5:
                Console.WriteLine("Friday, you are in love!");
                break;
            case 6:
                Console.WriteLine("Saturday, do nothing and do plenty of it!");
                break;
            case 7:
                Console.WriteLine("And Sunday always comes too soon!\n");
                break;
            default:
                Console.WriteLine("No day is a good day but it doesn't exist!");
                break;

        }


    }


    private void CalculateStringLength()
    {
        Console.WriteLine("\n---- STRENGTH LENGTH ----\n");
        Console.WriteLine("Enter any Sentence or word of your choice: ");
        Console.Write("You can even even copy and enter a text from any file: ");
        string anyString = Console.ReadLine();
        //string uppercase_anyStringLen = anyString.ToUpper();
        int anyStringLen = anyString.Length;
        string uppercase_anyStringLen = anyString.ToUpper();

        //Display information to user 
        Console.WriteLine(uppercase_anyStringLen);
        Console.WriteLine("Number of chars = "+ anyStringLen);
    }

    //introduction method by calling prevous methods

    private void Introduce()
    {

        ReadName();
        ReadEmail();
    }


    private  bool RunAgain()     
    {
        bool again = false;

        Console.Write("\n Contine to MathWork (y/n)? ");
        string response = Console.ReadLine();
        if (response == "Y" || response == "y" || response == "yes" || response == "Yes")
        {
            
            Console.WriteLine("You have quit the program!");
            //Environment.Exit(0); //This code exits the program
            again = true;
            Environment.Exit(0); //This code exits the program

        }
        else
        {
            again = false; // else if false Continue the  loop
            
        }
        return again;
    }

}
