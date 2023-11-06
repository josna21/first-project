namespace Part2;

class Phone
{
    private string name;
    private string brandName;
    string releaseDate;
    DateTime currentDate = DateTime.Now;
    private int amountofstorage;
    private double price;
    private double usagePeriod;
    //phone information inquiry 
    public void Info_Inquiry()
    {
        //Communiting to user 
        Console.WriteLine("*** This is a phone discription inquiry! ***");
        Console.WriteLine("************************************************************** \n");

        Console.Write("What is the name of your current phone? ");
        //Getting Users input for name
        name = Console.ReadLine();
        Console.WriteLine("You said your phone is called " + name +" Wonderful!");
        Console.Write("What brand is your phone? ");
        //Getting Users input for brandname
        brandName = Console.ReadLine();
        Console.Write("What year was your phone released? ");
        //Getting Users input for releaseDate
        releaseDate = Console.ReadLine();
        Console.Write("How much storage is your phone? (Reply with digits) ");
        //Getting Users input for amountofstorage
        amountofstorage = int.Parse(Console.ReadLine());
        Console.Write("How much did it cost in full? ");
        price = double.Parse(Console.ReadLine());


    }
    //calculating how long user has had her phone
    public void CalculatePhoneAge()
    {
        DateTime releaseDateTime = DateTime.Parse(releaseDate);
        TimeSpan difference = currentDate - releaseDateTime;
        usagePeriod = Math.Round(difference.TotalDays / 365, 2);



    }

    // Creating a method for displaing phone infomation
    public void DisplayPhoneInfo()
    {

        Console.WriteLine("**********************************************************************************************");
        Console.WriteLine("Here is information I've gatthered about your phone! \n ");

        Console.WriteLine("Your phone is called " +'"'+ name +'"');
        Console.WriteLine(name + " was manufuctured by " + brandName);
        Console.WriteLine("The model you're currently using was released " + releaseDate );
        Console.WriteLine("Since your phone was released " + releaseDate + " You have had it for " + usagePeriod + " Years!");
        Console.WriteLine("********************************************************************************************** \n");

        Console.Write("Press Enter to exit...");
        Console.ReadLine();
        Environment.Exit(0);




    }
    //Creating a method that will be called in main which later initiates other methods
    public void Start()
    {
        Info_Inquiry();
        CalculatePhoneAge();
        DisplayPhoneInfo();

    }

}

