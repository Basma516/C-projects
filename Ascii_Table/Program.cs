//Console.WriteLine("Enter the first character:");
//int input = Console.Read();
//Console.Write((char) input + "\t\t");
//Console.WriteLine(input);//0->48





//int input=Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < input; i++)
//{
//    Console.Write((char)i + "\t\t");
//    Console.WriteLine(i);//0->48
//}



//Console.Write("Enter your Full Name:");
//string fullName = Console.ReadLine();
//Console.Write("Enter the old part:");
//string find = Console.ReadLine();
//Console.Write("Enter the new part:");
//string replace = Console.ReadLine();
//if (fullName.Contains(find,StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine(@$"New Name is :
//    {fullName.Replace(find,replace,StringComparison.OrdinalIgnoreCase)}
//");
//}
//else
//{
//    Console.WriteLine("Not found!");
//}


//Console.WriteLine("Enter 5 Numbers:");
//int[] numbers=new int[5];
//for (int i = 0; i < numbers.Length; i++)
//{

//    numbers[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("Numbers after sorting:");
//Array.Sort(numbers);
//for (int i = 0;i < numbers.Length; i++)
//{
//    Console.Write($"{numbers[i]} ");
//}


//Console.Write("Enter the length of array:");
//int length=int.Parse(Console.ReadLine());
//int[] nums=new int[length];
//for (int i = 0; i < length; i++)
//{
//    Console.Write($"Enter the {i} array item:");
//    nums[i] = int.Parse(Console.ReadLine());
//}
////for(int i= 0; i<nums.Length; i++)
////{
////    Console.Write($"{nums[i]} ");
////}
////Console.WriteLine("Reversed Array:");
////for(int i=length-1; i>0; i--)
////{
////    Console.Write($"{nums[i]} ");
////}

//int result=0;
//foreach (int i in nums)
//{
//    result += i;
//}
//double avg=result/length;
//Console.WriteLine($"Average of numbers is : {avg}");











//string response="";
//do
//{
//    Console.Write("Enter any string:");
//    string str = Console.ReadLine();
//    Console.WriteLine(@"----Menue-----
//1.Capitalize your string.
//2.Lowerize your string.
//3.Dispaly string length.");
//    int option = int.Parse(Console.ReadLine());

//    switch (option)
//    {
//        case 1:
//            Console.WriteLine($"{str.ToUpper()}");
//            break;
//        case 2:
//            Console.WriteLine($"{str.ToLower()}");
//            break;
//        case 3:
//            Console.WriteLine($"{str.Length}");
//            break;
//        default:
//            Console.WriteLine("invalid option");
//            break;
//    }
//    Console.WriteLine("Do you want to continue? Y:N");
//    response = (Console.ReadLine()).ToUpper();
//} while (response == "Y");








//while (true)
//{
//    Console.Write("Enter any string:");
//    string str = Console.ReadLine();
//    if (str != "Exit")
//    {
//        Console.WriteLine(@"----Menue-----
//    1.Capitalize your string.
//    2.Lowerize your string.
//    3.Dispaly string length.");
//        int option = int.Parse(Console.ReadLine());

//        switch (option)
//        {
//            case 1:
//                Console.WriteLine($"{str.ToUpper()}");
//                break;
//            case 2:
//                Console.WriteLine($"{str.ToLower()}");
//                break;
//            case 3:
//                Console.WriteLine($"{str.Length}");
//                break;
//            default:
//                Console.WriteLine("invalid option");
//                break;
//        }
//    }
//    else
//    {
//        break;
//    }
//}
// todo:ccccccccc



//Console.Write("Enter the Number  of items:");
//int length=int.Parse(Console.ReadLine());
//int[] nums= new int[length];
//for(int i=0; i < length; i++)
//{
//    Console.Write($"Enter the {i} item :");
//    nums[i]= int.Parse(Console.ReadLine());
//}
//Console.WriteLine($"Smallest item is : {nums.Min()}");
//Console.WriteLine($"Largest item is : {nums.Max()}");
//Console.WriteLine($"Average is :{nums.Average()}");

//Console.WriteLine($"Average from function  is {CalcAvg(nums)}");
//Console.WriteLine($"Smallest item from function is {CalcSmallest(nums)}");
//Console.WriteLine($"Largest item from function is {CalcLargest(nums)}");
//static double CalcAvg(int[] nums)
//{
//    int sum = 0;


//    for (int i = 0; i < nums.Length; i++)
//    {
//        sum += nums[i];

//    }
//    double avg = sum / nums.Length;
//    return avg;

//}


//static int CalcSmallest(int[] nums)
//{
//    int smallest = nums[0];
//    for (int i = 0; i < nums.Length; i++)
//    {

//        if (smallest < nums[i])
//        {
//            continue;
//        }
//        else
//        {
//            smallest=nums[i];
//        }

//    }
//    return smallest;
//}

//static int CalcLargest(int[] nums)
//{
//    int largest = nums[0];
//    for (int i = 0; i < nums.Length; i++)
//    {

//        if (largest > nums[i])
//        {
//            continue;
//        }
//        else
//        {
//            largest = nums[i];
//        }

//    }
//    return largest;
//}












//palindrome words ---> mom ,dad,non
//while (true)
//{
//    Console.WriteLine("Enter a palindrome word (or type 'exit' to quit):");
//    string input = Console.ReadLine().ToLower();

//    if (input == "exit")
//        break;

//    string statement = "The word **is** a palindrome!";

//    for (int i = 0; i < input.Length / 2; i++)
//    {
//        if (input[i] != input[^(i + 1)])
//        {
//            statement = "The word **is not** a palindrome!";
//            break;
//        }
//    }

//    Console.WriteLine(statement);
//    Console.WriteLine(); 
//}

//double d = 10;
//double x = 'f';
//float f = 42000000;
//int c = (int)2.5;



//try
//{
//    Console.Write("Enter the first number:");
//    int num1 = int.Parse(Console.ReadLine());
//    Console.Write("Enter the second number:");
//    int num2 = int.Parse(Console.ReadLine());
//    Console.WriteLine($"Division result :{num1 / num2}");
//}catch(FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Unexpected error:  {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Finished");
//}





//while (true)
//{
//    Console.WriteLine("1.Change Background Color.");
//    Console.WriteLine("2.Change Foreground Color.");
//    int option=int.Parse(Console.ReadLine());
//    foreach(var color in Enum.GetNames(typeof(ConsoleColor)))
//    {
//        Console.WriteLine(color);
//    }

//    Console.Write("Enter the Color Name:");
//    string colorName = Console.ReadLine();
//    ConsoleColor consoleColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName, true);
//    if (option == 1)
//    {
//        Console.BackgroundColor = consoleColor;
//    }
//    else if (option == 2)
//    {
//        Console.ForegroundColor = consoleColor;
//    }
//    else
//    {
//        Console.WriteLine("invalid option!");
//    }
//}
//Roles userRoles = Roles.Admin | Roles.Editor;
//Console.WriteLine($"User roles : {userRoles}");
//if (userRoles.HasFlag(Roles.Admin))
//{
//    Console.WriteLine("User is Admin");
//}
////& bitwise  return common
//userRoles |= Roles.Viewer;//or bitwise merges
//userRoles &=~Roles.Editor;//except
//Console.WriteLine($"updated roles : {userRoles}");
//userRoles ^=Roles.Editor;
//Console.WriteLine($"last updated roles : {userRoles}");//toggle 
//[Flags]
//public enum Roles
//{
//    None = 0,
//    Admin = 1,
//    Editor = 2,
//    Viewer =4
//}

