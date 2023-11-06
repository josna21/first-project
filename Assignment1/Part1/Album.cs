

using System.Xml.Linq;

namespace Assignment1;

class Album
{

    private string albumName;
    private string artistName;
    private int numOfTracks;

    public void ReadInput()
    {
        Console.WriteLine("Starting the Album Program!");
        Console.WriteLine("*************************************************");

        Console.Write("What is the your favorite music album? :");
        albumName = Console.ReadLine();


        Console.Write("What is the name of The Artist or Band for " + albumName);
        artistName = Console.ReadLine();

        Console.Write("How many tracks does " + albumName + " have? ");
        numOfTracks = int.Parse(Console.ReadLine());


    }

    public void Displayinfo()
    {
        Console.WriteLine("Here is album information");
        Console.WriteLine("Album name: " + albumName);
        Console.WriteLine("Artist/Band: " + artistName);
        Console.WriteLine("Number of Tracks: " + numOfTracks) ;
        Console.WriteLine("Enjoy Listening!");
        Console.WriteLine("*************************************************");

        Console.Write("Press Enter to start next part...");
        Console.ReadLine();

    }

    public void Start()
    {
        ReadInput();
        Displayinfo();

    }

}

