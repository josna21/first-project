

namespace Assignment1;

class Pet 
{
    private string? name;

    private int age;

    private bool isFemale;


    public void ReadInput()
    {
        Console.WriteLine("Greetings ");
        Console.Write("What is the name one your pet? :");
        name = Console.ReadLine();


        Console.Write("What is " + name + "'s Age");

        age = int.Parse(Console.ReadLine());

        Console.Write("Is the pet female? (True/False)");
        isFemale = bool.Parse(Console.ReadLine());
       
    }

    public void Displayinfo()

    {
        Console.WriteLine("Here is pets information\n");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + (isFemale ? "Female" : "Male"));
        Console.WriteLine(name + " is a good girl");
        Console.WriteLine("*************************************************\n");

        Console.Write("Press Enter to start next part....");
        Console.ReadLine();
    }

    public void Start()
    {
        ReadInput();
        Displayinfo();

    }
    
}

