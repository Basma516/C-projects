
using System.Linq;
using System.Text;


while (true)
{
    Console.WriteLine("1. Generate Random Number.");
    Console.WriteLine("2. Generate Random String.");
    int option = int.Parse(Console.ReadLine());
    if (option == 1)
        GenerateRandomNumber();
    else if (option == 2)
        GenerateRandomString();
    else
        Console.WriteLine("invalid option!");
}

const string CapitalBuffer = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
const string SmallBuffer = "abcdefghijklmnopqrstuvwxyz";
const string NumbersBuffer = "0123456789";
const string SymbolsBuffer = "~!@#$%^&*()_";
static void GenerateRandomNumber()
{
    Random random = new Random();
    Console.Write("Enter the Min , Max Values :");
    int min = int.Parse(Console.ReadLine());
    int max = int.Parse(Console.ReadLine());
    int value = random.Next(min, max - 1);
    Console.WriteLine($"Random Number is : {value}");
}
string buffer = "";
static void GenerateRandomString()
{
    StringBuilder sb = new StringBuilder();
    Random random = new Random();
    Console.WriteLine("Enter the length of string:");
    int length = int.Parse(Console.ReadLine());
    if (length < 0)
    {
        throw new Exception("the length must be positive");
    }
    Console.WriteLine("Select Buffer Options:");
    Console.WriteLine("1.include capital letters?(yes/no)");
    string capitalOption = Console.ReadLine().ToLower();
    Console.WriteLine("2.include small letters?(yes/no)");
    string smallOption = Console.ReadLine().ToLower();
    Console.WriteLine("2.include numbers?(yes/no)");
    string numberOption = Console.ReadLine().ToLower();
    Console.WriteLine("2.include symbols?(yes/no)");
    string symbolOption = Console.ReadLine().ToLower();
    StringBuilder buffer = new StringBuilder();

    if (capitalOption == "yes")
    {
        buffer.Append(CapitalBuffer);

    }
    if (smallOption == "yes")
    {
        buffer.Append(SmallBuffer);
    }
    if (numberOption == "yes")
    {
        buffer.Append(NumbersBuffer);
    }
    if (symbolOption == "yes")
    {
        buffer.Append(SymbolsBuffer);
    }

    while (sb.Length < length)
    {
        int randomIndex = random.Next(0, buffer.Length - 1);
        sb.Append(buffer[randomIndex]);

    }
    Console.WriteLine($"Random String is : {sb}");
}