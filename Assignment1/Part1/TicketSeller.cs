

using static System.Net.Mime.MediaTypeNames;


namespace Assignment1;

class TicketSeller
{

    private string name;
    private double price = 100;
    private int numOfAdults;
    private int numOfChildren;
    private double amountToPay;

    public void ReadInput()
    {

        Console.WriteLine("Welcome to KIDS' FAIR!");
        Console.WriteLine("Children always get a 75% Discount ");
        Console.WriteLine("*************************************************");

        Console.Write("What is the your name please? :");
        name = Console.ReadLine();


        Console.Write("What is the number of adults :");
       numOfAdults = int.Parse(Console.ReadLine());

        Console.Write("what is the number of children? :");
        numOfChildren = int.Parse(Console.ReadLine());

    }

    public void Calculate()
        // calculating ticket price for both discounted and non discounted prices
    {
        double childrenDiscount ;
        double adultPrice;
        double discountpercetange;
        // calculating discount for later subtraction

        discountpercetange = (100 - 75) / 100;

        childrenDiscount = (price * discountpercetange * numOfChildren);
        adultPrice = (price * (numOfAdults));

        amountToPay = adultPrice +  childrenDiscount;

    }
    


    public void Displayinfo()
    {

        Console.WriteLine("+++ Your receipt +++");
        Console.WriteLine("+++ Amount to pay =  " + amountToPay);
        Console.WriteLine("+++ Thank you " + name + " please come back next time! +++");

        Console.Write("Press Enter to exit...");
        Console.ReadLine();
        Environment.Exit(0);

    }


    public void Start()
    {
        ReadInput();
        Calculate();
        Displayinfo();
        
    }

}

