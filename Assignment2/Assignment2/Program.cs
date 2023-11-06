namespace Assignment2;
class MainProgram
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.Title = "Strings, select and iteration in C#";
        FunFeature funitem = new FunFeature(); //Creating an object of feature
        funitem.Start(); // Calling the object*s Start method

        ContinueToNextPart(); // Calling the method (continuetonextpart) below
        //Continue with Mathwork

        MathWorK calc = new MathWorK();
        calc.Start();

        ContinueToNextPart();

        TemperatureConverter NewTemp = new TemperatureConverter();
        NewTemp.Start();
        ContinueToNextPart();
        WorkingSchedule NewWork = new WorkingSchedule();
        NewWork.Start();
       

    }

    //Method called in the Class main to continue to the next program
    private static void ContinueToNextPart()
    {

        Console.Write("\nPRESS ENTER TO CONTINUE TO NEXT PART");
        Console.ReadLine();
        Console.Clear();



    }

    
        


}
