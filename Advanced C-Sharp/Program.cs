using Advanced_C_Sharp;
using System;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection;
using System.Text;
//using static Alarm;

//string sentence = "Basma Mohamed Elsaid Elmenshawy";
//Console.WriteLine($"String Has {sentence.WordCount()} Words.");
//Console.WriteLine($"Reversed string: {sentence.Reverse()} ");
//Console.WriteLine(StringExtensions.WordCount(sentence));
//var textEditor = new TextEditor(sentence);
//textEditor.ToUpper().AddExclamation().ReplaceSpacesWithDash().print();




//StringBuilder stringBuilder =new StringBuilder();
//Console.WriteLine(stringBuilder.AddNewLine("Hello ").AddNewLine("World!"));
//CountDown(5);
//Console.WriteLine(Factorial(5));  // تطبع 120
//Console.WriteLine(Fibonacci(6));
//static void  CountDown(int x)
//{
//    if (x == 0)
//    {
//        Console.WriteLine("Done!");
//        return;
//    }
//    Console.WriteLine(x);
//    CountDown(x-1);
//}
//static int Factorial(int n)
//{
//    if (n == 0) return 1;
//    if (n == 1) return 1;
//    return n*Factorial(n-1);
//}


/*
 * القاعدة:

    fib(0) = 0

    fib(1) = 1

    fib(n) = fib(n-1) + fib(n-2)
*/
//static int Fibonacci (int f)
//{
//    if(f == 1) return 1;
//    if(f==0) return 1;
//    return Fibonacci(f-1) + Fibonacci(f-2);
//}



//PrintMessageDelegate PrintMessage = ShowMessageWithoutName;
//PrintMessage += ShowMessageWithName;
//PrintMessage("Hello from Delegate!");


//static void ShowMessageWithoutName(string message)
//{
//    Console.WriteLine(message);
//}
//static void ShowMessageWithName(string message)
//{
//    Console.WriteLine($"{message} Basma");
//}
//public delegate void PrintMessageDelegate(string message);



//List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//List<int> oddNumbers = numbers.FindAll(x => x % 2 == 1);
//foreach (int n in oddNumbers)
//{
//    Console.WriteLine(n);
//}

//Action sayHi = () => Console.WriteLine("Hi Nada");
//sayHi();
//Action<string> greet = name => Console.WriteLine($"Hello {name}");
//greet("Basma");
//Action<int,int> printSum = (int x ,int y) => Console.WriteLine(x + y);
//printSum(3,5);
//Action<string,string> greeting = (msg,name) => Console.WriteLine($"{msg}, {name}!");
//greeting("Hi","Basma");

//Func<int> getRandom = () => new Random().Next(1,101);
//Console.WriteLine(getRandom());
//Func<int, int> squre = x => x * x;
//Console.WriteLine(squre(5));
//Func<int,int,int> multiply=(x,y) => x * y;
//Console.WriteLine(multiply(5,6));


//Predicate<int> IsEven=number=> number % 2 == 0;
//Console.WriteLine(IsEven(5));
//Console.WriteLine(IsEven(4));


//Predicate<string> isLong = name => name.Length > 5;
//Action action = () => Console.WriteLine(isLong("Basma"));
//Action action2 = () => Console.WriteLine(isLong("Elmenshawy"));

//action();
//action2();








//File.WriteAllText("test.txt", "Hello, Basma!");
//string content = File.ReadAllText("test.txt");
//Console.WriteLine(content);
////File.Delete("test.txt");
//Directory.CreateDirectory("MyNewCarrier");
//Directory.Delete("MyNewCarrier");
//Console.WriteLine("-------------------------------");

//string[] files = Directory.GetFiles("C:\\Users\\MG\\source\\repos\\Advanced C-Sharp");
//foreach (string file in files)
//    Console.WriteLine(file);
//FileInfo fileData = new FileInfo("test.txt");
//Console.WriteLine(fileData.Name);
//Console.WriteLine(fileData.Length);
//Console.WriteLine(fileData.CreationTime);
//Console.WriteLine(fileData.ToString());
//Console.WriteLine("-------------------------------");

//DirectoryInfo dir = new DirectoryInfo("C:\\Users\\MG\\source\\repos\\Advanced C-Sharp\\bin\\Debug\\net8.0");

//foreach (var item in dir.GetFiles())
//    Console.WriteLine(item.Name);






//FileSystemWatcher watcher = new FileSystemWatcher();
//watcher.Path = @"C:\\Users\\MG\\source\\repos\\Advanced C-Sharp";
//watcher.Filter = "*.txt";
//watcher.EnableRaisingEvents = true;
//watcher.Deleted += (sender, e) => Console.WriteLine($"File Deleted!");
//// لما يتعمل ملف جديد:
//watcher.Created += (sender, e) =>
//{
//    Console.WriteLine($"File created: {e.Name}");
//};

//// لما يتعدل ملف:
//watcher.Changed += (sender, e) =>
//{
//    Console.WriteLine($"File changed: {e.Name}");
//};
//Console.ReadKey();

//Alarm alarm = new Alarm();


//alarm.AlarmEventHeld += OnAlarm;
//alarm.AlarmEventHeld += Message;
//alarm.Ring();
//    static void OnAlarm(string msg)
//{
//    Console.WriteLine("Alarm message: " + msg);
//}
//static void Message(string msg)

//{
//    Console.WriteLine("Important message!" +msg);
//}
//public class Alarm
//{
//    public delegate void AlarmEventHandler(string message);
//    public event AlarmEventHandler AlarmEventHeld;
//    public  void Ring()
//    {
//        Console.WriteLine("Alarm Ringing......");
//        AlarmEventHeld?.Invoke("Wake up!");
//    }


//}











//MyButton myButton = new MyButton();
//myButton.ButtonClick += Sound;

//myButton.Click();
//static void Sound()
//{
//Console.WriteLine("Button is clicked Open the door!");
//}
//public class MyButton
//{
//    public delegate void ClickHandler();

//    // كملي هنا: تعريف الحدث
//    // ________________________________
//    public event ClickHandler ButtonClick;

//    public void Click()
//    {
//        Console.WriteLine("Button clicked internally");

//        // كملي هنا: تشغيل الحدث
//        //  ________________________________
//        ButtonClick?.Invoke();
//    }
//}
//Door door = new Door();
//door.OnOpen +=Message;

//door.Open();
//static void Message(string message)
//{
//    Console.WriteLine("Event says: " + message);
//}
//public class Door
//{

//    //public delegate void DoorHandler(string message);
//    public event Action<string> OnOpen;
//    public void Open()
//    {
//        Console.WriteLine("Opening the door...");
//        OnOpen.Invoke("The door is now open");
//    }
//}



//Smart Door Event
/*
 * [Mobile App] Door opened: Welcome home!
[Security] Camera started recording.

[Mobile App] Door closed: See you later!
[Security] Camera stopped recording.
 * */
//SmartDoor smartDoor =new SmartDoor();
//smartDoor.OnClose += MobileApp;
//smartDoor.OnOpen += MobileApp;

//smartDoor.OnClose += SecuritySystem;
//smartDoor.OnOpen += SecuritySystem;

//smartDoor.Open();
//smartDoor.Close();

//static void MobileApp(string msg="",string Smsg="" )
//{
//    Console.WriteLine($"[Mobile App]    {msg}" );
//}
//static void SecuritySystem(string msg="", string Smsg = "")
//{
//    Console.WriteLine($"[Security]      {Smsg}");
//}
//public class SmartDoor
//{
//    public event Action<string,string> OnOpen;
//    public event Action<string,string> OnClose;


//    public void Open() => OnOpen?.Invoke("Door opened: Welcome home!", "Camera started recording.");
//    public void Close() => OnClose?.Invoke("Door closed: See you later!", "Camera stopped recording.");
//}

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("processing.....");
//    Thread.Sleep(1000);
//}
//Console.WriteLine("Finally");


//new Thread(() =>
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.WriteLine("Background task running...");
//        Thread.Sleep(1000);
//    }
//}).Start();


//Console.WriteLine("User can continue using the program!");


using System.Threading;
using System.Timers;

//void PrintA()
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;

//        Console.WriteLine("A");
//        Thread.Sleep(500); // يوقف نص ثانية
//    }
//}

//void PrintB()
//{
//    for (int i = 0; i < 5; i++)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine("B");
//        Thread.Sleep(500);
//    }
//}

//Thread t1 = new Thread(PrintA);
//Thread t2 = new Thread(PrintB);

//t1.Start();
//t2.Start();


//static void Print()
//{
//    for (int i = 0; i <= 5; i++)
//    {
//        Console.WriteLine(i);
//        Thread.Sleep(1000);
//    }
//}
//Thread thread = new Thread(Print);
//thread.Start();
//Console.WriteLine("I'm Free Now");


//new Thread(() =>
//{
//    for (int i = 0; i <= 5; i++)
//    {
//        Console.WriteLine(i);
//        Thread.Sleep(1000);
//    }

//}).Start();
//Console.WriteLine("I'm Free Now");




//static void CountSscond()
//{
//    for (int i = 0; i <= 10; i++)
//    {
//        Console.WriteLine($"Second: {i}");
//        Thread.Sleep( 1000 );
//    }
//}
//Thread thread = new Thread( CountSscond );
//thread.Start();


//while (true)
//{
//    Console.Write("Write any thing: ");
//    var input = Console.ReadLine();

//    if (input.ToLower() == "exit")
//    {
//        break;
//    }
//    else if (input.ToLower() == "")
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine($"You Write this : {input}\n");
//    }
//}



//using System;
//using System.Threading;

//class Program
//{
//    static void Main()
//    {
//        // عداد في الخلفية
//        Thread counterThread = new Thread(() =>
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                Thread.Sleep(1000);

//                // حفظ اللون الأصلي
//                var prevColor = Console.ForegroundColor;

//                // طباعة بلون مختلف
//                Console.ForegroundColor = ConsoleColor.Yellow;
//                Console.WriteLine($"\n[Timer] Second: {i}");
//                Console.ForegroundColor = prevColor;
//            }
//        });

//        counterThread.Start();

//        // الإدخال من المستخدم
//        while (true)
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.Write("Write any thing: ");
//            Console.ResetColor();

//            string input = Console.ReadLine();

//            if (input?.ToLower() == "exit" || input == "")
//                break;

//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("you Write this " + input + "\n");
//            Console.ResetColor();
//        }
//    }
//}



//using System;
//using System.Threading;

//class Program
//{
//    static object consoleLock = new object(); // لحماية الطباعة

//    static void Main()
//    {
//        // نبدأ 3 ملفات في نفس الوقت
//        Thread t1 = new Thread(() => DownloadFile("File 1"));
//        Thread t2 = new Thread(() => DownloadFile("File 2"));
//        Thread t3 = new Thread(() => DownloadFile("File 3"));

//        t1.Start();
//        t2.Start();
//        t3.Start();

//        // ننتظر انتهاءهم كلهم
//        t1.Join();
//        t2.Join();
//        t3.Join();

//        lock (consoleLock)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine("\n✅ All downloads finished!");
//            Console.ResetColor();
//        }
//    }

//    static void DownloadFile(string fileName)
//    {
//        Random rand = new Random();

//        int progress = 0;

//        while (progress < 100)
//        {
//            Thread.Sleep(rand.Next(100, 500)); // سرعة تحميل عشوائية

//            progress += rand.Next(5, 15); // تقدم عشوائي
//            if (progress > 100) progress = 100;

//            lock (consoleLock)
//            {
//                Console.WriteLine($"[{fileName}] Downloaded: {progress}%");
//            }
//        }

//        lock (consoleLock)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine($"[{fileName}] ✅ Download complete!");
//            Console.ResetColor();
//        }
//    }
//}


//int counter = 0;

//object myLock = new object();

//void SafeIncrement()
//{
//    for (int i = 0; i < 1000; i++)
//    {
//        lock (myLock)
//        {
//            counter++;
//        }
//    }
//}

//Thread thread1 = new Thread(SafeIncrement);
//Thread thread2 = new Thread(SafeIncrement);
//thread1.Start();
//thread2.Start();
//thread1.Join();
//thread2.Join();
//Console.WriteLine(counter);
//ThreadPool.QueueUserWorkItem(_ =>
//{
//    Console.WriteLine("I'm in the pool!");
//});
//Console.WriteLine(ThreadPool.ThreadCount);

//var task = Task.Run(() =>
//{
//    Thread.Sleep(1000);
//    return "Result from background";
//});

//Console.WriteLine("Doing other things...");

//string result = task.Result; // ينتظر لما المهمة تخلص
//Console.WriteLine(result);




//string longText = "900000000";
//long x =Convert.ToInt64(longText);
//Console.WriteLine(x);

//string floatText = "5.440001";
//float x2 = Convert.ToSingle(floatText);
//Console.WriteLine(x2);
//x2++;
//Console.WriteLine(x2);

//bool  bool1 = false;
//Boolean bool2 = true;
//Console.WriteLine(bool1);
//Console.WriteLine(bool2);
//int age = 24;
//age++;
//age += 1;
//age = age + 1;





















//Console.Write("Enter the length of array:");
//int length= int.Parse(Console.ReadLine());
//int[] numbers= new int[length];

//Console.WriteLine("Enter the elements of array");
//for (int i = 0; i < length; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("-----------Array Elements------------");
//for (int i = 0; i < length; i++)
//{
//    if (i == length - 1)
//    {
//        Console.Write($"{numbers[i]}");
//    }
//    else
//    {
//        Console.Write($"{numbers[i]} - ");
//    }

//}
//Console.WriteLine();
//Console.WriteLine("---- Or ----");
//Console.WriteLine(string.Join(" - ", numbers));
//Console.WriteLine("-----------Reversed Array------------");
//for (int i = length - 1; i >= 0; i--)
//{
//    if (i == 0)
//    {
//        Console.Write($"{numbers[i]}");
//    }
//    else
//    {
//        Console.Write($"{numbers[i]} - ");
//    }
//}
//Console.WriteLine();
//Console.WriteLine("---- Or ----");
//Console.WriteLine(string.Join(" - ", numbers.Reverse()));
//Console.WriteLine("---------Sorted Array---------");
//Console.Write("Enterh number for search:");
//int search = int.Parse(Console.ReadLine());
//int indexOf = Array.IndexOf(numbers, search);
////Console.WriteLine(indexOf);
//string res = (indexOf == -1) ? "Element Not Found" : $"{indexOf}";
//Console.WriteLine($"first index of {search} : {res} ");
//int lastIndexOf = Array.LastIndexOf(numbers, search);
//string result = (lastIndexOf == -1) ? "Element Not Found" : $"{lastIndexOf}";
//Console.WriteLine($"last index of {search} : {result}");

//Array.Sort(numbers);

//Console.WriteLine(string.Join(" - ", numbers));
//Array.Reverse(numbers);
//Console.WriteLine(string.Join(" - ", numbers));

//int[] sortedArray = new int[length];
//Array.Copy(
//    numbers, sortedArray, length);
//Console.WriteLine(string.Join("  ", sortedArray));
//Console.WriteLine($@"
//Sum: {numbers.Sum()}
//Average: {numbers.Average()}
//Maximum: {numbers.Max()}
//Minimum: {numbers.Min()}
//");
//int position = Array.IndexOf(numbers, search);
//string resultF = (position == -1) ? "Element Not Found" : $"{position}";
//Console.WriteLine($"Index of {search} after sorting :{resultF}");
//Array.Clear(sortedArray, 0, 3);
//foreach (int i in sortedArray)
//{
//    Console.Write($"{i} ");
//}

//numbers.Contains(30);
//int[] nums = { 11, 22, 33, 44, 55, 66 };
//bool Found = nums.Contains(30);
//Console.WriteLine(Found);
//int Even=Array.Find(nums, number => number % 2 == 0);
//Console.WriteLine(Even);
//int[] Evennum = Array.FindAll(nums, num => num % 2 == 0);
//foreach (var item in Evennum)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
//Console.WriteLine(nums.Any(number => number > 90));

//Console.WriteLine(nums.All(number => number > 50));






















//List<string> studentsName = new List<string>() 
//{
//    "Basma",
//    "Nada", 
//    "Sama" 
//};

//studentsName.Add("Haitham");
//studentsName.Add("Osama");
//studentsName.Insert(3, "Yassin");
//studentsName.InsertRange(4, ["Mohammed", "Gawaher"]);
//foreach (string s in studentsName)
//{
//    Console.Write($"{s} ");
//}
//Console.WriteLine();

//studentsName.Remove("Sama");
//studentsName.RemoveAt(0);
//studentsName.Contains(studentsName[0]);//bool


//Console.WriteLine("Enter the number of Students");
//int count = int.Parse(Console.ReadLine());














//List<string> studentsName = new List<string>();

//do
//{



//    Console.WriteLine("Choose Option:");
//    Console.WriteLine($@"0.Exit
//1.Add.
//2.AddRange.
//3.Insert.
//4.InsertRange.
//5.Search By Name.
//6.Remove.
//7.RemoveAt.
//8.Print.");
//    string studentName = "";
//    string search = "";
//    int numOfStudent = 0;
//    List<string> InsertedNames = new List<string>();

//   bool option =int.TryParse(Console.ReadLine(), out int opt);
//    switch (opt)
//    {
//        case 0:
//            return;
//        case 1:

//            Console.WriteLine("Enter the Students Names : ");
//                studentName = Console.ReadLine();
//                studentsName.Add(studentName);
//            break;
//        case 2:
//            Console.Write("How many student will be add? ");
//            numOfStudent=int.Parse(Console.ReadLine());

//            for (int i = 0; i < numOfStudent; i++)
//            {
//                Console.Write($"Enter the student of {(studentsName.Count)} ");
//                studentsName.Add(Console.ReadLine());
//            }
//            break;
//        case 3:
//            Console.Write("Enter the index of Student: ");
//            int In= int.Parse(Console.ReadLine());
//            if (In < 0 || In > studentsName.Count)
//            {
//                Console.WriteLine("Invalid index!");
//                break;
//            }
//            Console.Write("Enter the Student Name: ");
//            studentName = Console.ReadLine();
//            studentsName.Insert(In,studentName);
//            break;
//        case 4:
//            Console.Write("Enter the index of Student: ");
//            int In2 = int.Parse(Console.ReadLine());
//            if (In2 < 0 || In2 > studentsName.Count)
//            {
//                Console.WriteLine("Invalid index!");
//                break;
//            }
//            Console.Write("How many Students will be add? ");
//            numOfStudent= int.Parse(Console.ReadLine());

//            for (int i = 0;i < numOfStudent; i++)
//            {
//                Console.Write($"Enter student number {i+In2+1} ");
//                Console.Write("Enter the Student Name: ");
//                InsertedNames.Add(Console.ReadLine());

//            }

//            studentsName.InsertRange(In2, [..InsertedNames]);
//            break;
//        case 5:
//            Console.Write("Enter the search word: ");
//            search = Console.ReadLine();
//            int index = studentsName.IndexOf(search);
//            if (index != -1)
//            {
//                Console.WriteLine($"The position of {search} is {index + 1}");
//            }
//            else
//            {
//                Console.WriteLine("Not Found!");
//            }
//            break;

//        case 6:
//            Console.WriteLine("Enter the Deleted Name : ");
//            search=Console.ReadLine();
//            if (studentsName.Contains(search))
//            {
//                studentsName.Remove(search);
//                Console.WriteLine("Deleted Successfully");
//            }


//                break;
//        case 7:
//            Console.WriteLine("Enter the position of the Deleted element : ");
//            int pos = int.Parse(Console.ReadLine());
//            if (pos >= 0 && pos < studentsName.Count)
//            {
//                studentsName.RemoveAt(pos);
//                Console.WriteLine("Deleted Successfully");
//            }
//            else
//            {
//                Console.WriteLine("Out Of Range!");
//            }
//            break;
//        case 8:
//            for(int i = 0; i < studentsName.Count; i++)
//            {
//                Console.Write($"Student {i+1} : {studentsName[i]} ");
//            }

//            Console.WriteLine();
//            Console.WriteLine(string.Join(" - ", studentsName));
//            break;
//        default:
//            Console.WriteLine("Invalid Option");
//            break;
//    }

//}
//while(true);


//List<int> nums = new List<int> { 10, 51, 90, 73, 30, 41, 60, 21, 80, 101 };

//// 1. هل 30 موجود؟
//Console.WriteLine(nums.Contains(30)); // True

//// 2. أول رقم أكبر من 50
//Console.WriteLine(nums.Find(n => n > 50)); // 51

//// 3. كل الأرقام الزوجية
//List<int> evens = nums.FindAll(n => n % 2 == 0);
//Console.WriteLine(string.Join(" ", evens)); // 10 90 30 60 80

//// 4. هل فيه أي رقم أكبر من 100؟
//Console.WriteLine(nums.Any(n => n > 100)); // True

//// 5. هل كل الأرقام أكبر من 50؟
//Console.WriteLine(nums.All(n => n > 50)); // False








//Stack<string> stack = new Stack<string>();

//while (true)
//{
//    Console.WriteLine("\n--- Stack Menu ---");
//    Console.WriteLine("1. Push (Add)");
//    Console.WriteLine("2. Pop (Remove top)");
//    Console.WriteLine("3. Peek (Top element)");
//    Console.WriteLine("4. Is Empty?");
//    Console.WriteLine("5. Count");
//    Console.WriteLine("6. Print Stack");
//    Console.WriteLine("0. Exit");
//    Console.Write("Enter choice: ");
//    string choice = Console.ReadLine();
//    switch (choice)
//    {
//        case "1":
//            Console.Write("Enter the Element: ");
//            string Value = Console.ReadLine();
//            stack.Push(Value);
//            Console.WriteLine($"{Value}Added successfully!");
//            break;
//        case "2":
//            if (stack.Count > 0)
//            {
//                Console.Write(stack.Pop());
//                Console.WriteLine(" Removed Successfully!");
//            }else
//            {
//                Console.WriteLine("Stack is empty!");
//            }
//            break;
//        case "3":
//            if (stack.Count > 0)
//            {
//                Console.WriteLine($"Top Element is {stack.Peek()}");
//            }
//            else
//            {
//                Console.WriteLine("Stack is empty!");
//            }
//            break;
//        case "4":
//            Console.WriteLine(stack.Count==0 ? "Stack is empty" : "Stack Not Empty");
//            break;
//        case "5":
//            Console.WriteLine($"The Count of Elements inside stack is : {stack.Count}");
//            break;
//        case "6":
//            if (stack.Count > 0)
//            {
//                Console.WriteLine("Stack elements:");
//                foreach (string s in stack)
//                    Console.WriteLine($"{s} ");
//            }
//            else
//            {
//                Console.WriteLine("Stack is empty!");

//            }
//            break;
//        case "0":
//            return;
//        default:
//            Console.WriteLine("Invalid input!");
//            break;

//    }
//}



















//Queue<string> queue = new Queue<string>();

//while (true)
//{
//    Console.ForegroundColor = ConsoleColor.Magenta;
//    Console.WriteLine("\n--- Queue Menu ---");
//    Console.WriteLine("1. Enqueue (Add)");
//    Console.WriteLine("2. Dequeue (Remove top)");
//    Console.WriteLine("3. Peek (Top element)");
//    Console.WriteLine("4. Is Empty?");
//    Console.WriteLine("5. Count");
//    Console.WriteLine("6. Print Queue");
//    Console.WriteLine("0. Exit");
//    Console.Write("Enter choice: ");
//    Console.ForegroundColor = ConsoleColor.White;
//    string choice = Console.ReadLine();
//    switch (choice)
//    {
//        case "1":
//            Console.Write("Enter the Element: ");
//            string Value = Console.ReadLine();
//            queue.Enqueue(Value);
//            Console.WriteLine($"{Value} Added successfully!");
//            break;
//        case "2":
//            if (queue.Count > 0)
//            {
//                Console.Write(queue.Dequeue());
//                Console.WriteLine(" Removed Successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Queue is empty!");
//            }
//            break;
//        case "3":
//            if (queue.Count > 0)
//            {
//                Console.WriteLine($"Top Element is {queue.Peek()}");
//            }
//            else
//            {
//                Console.WriteLine("Queue is empty!");
//            }
//            break;
//        case "4":
//            Console.WriteLine(queue.Count == 0 ? "Queue is empty" : "Queue Not Empty");
//            break;
//        case "5":
//            Console.WriteLine($"The Count of Elements inside Queue is : {queue.Count}");
//            break;
//        case "6":
//            if (queue.Count > 0)
//            {
//                Console.WriteLine("Queue elements:");
//                foreach (string s in queue)
//                    Console.WriteLine($"{s} ");
//            }
//            else
//            {
//                Console.WriteLine("Queue is empty!");

//            }
//            break;
//        case "0":
//            return;
//        default:
//            Console.WriteLine("Invalid input!");
//            break;

//    }
//}











//var linkedList = new LinkedList<string>();
//linkedList.AddLast("Nada");
//linkedList.AddFirst("Ahmed");
//linkedList.AddLast("Omar");


//var nadaNode = linkedList.Find("Nada");
//if (nadaNode != null)
//{
//    linkedList.AddAfter(nadaNode, "Basma");
//}


//if (nadaNode != null)
//{
//    linkedList.AddBefore(nadaNode, "Sama");
//}


//foreach (var item in linkedList)
//{
//    Console.WriteLine(item);
//}
//linkedList.Remove("Basma");
//linkedList.RemoveFirst();
//linkedList.RemoveLast();
//Console.WriteLine($@"{linkedList.First()}
//{linkedList.Last()}
//{linkedList.Count()}");

//foreach (var item in linkedList)
//{
//    Console.WriteLine(item);
//}








//LinkedList<string> linkedList = new LinkedList<string>();

//do
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("\n------- LinkedList ---------");
//    Console.WriteLine($@"1.AddFirst
//2.AddLast.
//3.AddAfter.
//4.AddBefore.
//5.Remove Value.
//6.RemoveFirst.
//7.RemoveLast
//8.Display First Node.
//9.Display Last Node.
//10.Print Linked List Elements.
//11.Count.
//0.Exit.");
//    int choice=int.Parse(Console.ReadLine());
//    Console.ForegroundColor = ConsoleColor.White;

//    switch (choice) 
//    { 
//        case 1:
//            Console.Write("Enter the first Element: ");
//            linkedList.AddFirst(Console.ReadLine());
//            Console.WriteLine("First Element Added Successfully!");
//            break;
//        case 2:
//            Console.Write("Enter the last Element: ");
//            linkedList.AddLast(Console.ReadLine());
//            Console.WriteLine("Last Element Added Successfully!");
//            break;
//        case 3:
//            Console.Write("Enter the Node: ");
//            var searchnode=linkedList.Find(Console.ReadLine());

//            if (searchnode != null)
//            {
//                Console.Write("Enter the New Value: ");
//                linkedList.AddAfter(searchnode, Console.ReadLine());
//                Console.WriteLine(" Added Successfully!");
//            }
//            break;
//        case 4:
//            Console.Write("Enter the Node: ");
//             searchnode = linkedList.Find(Console.ReadLine());

//            if (searchnode != null)
//            {
//                Console.WriteLine("Enter the New Value to Add Before:");
//                linkedList.AddBefore(searchnode, Console.ReadLine());
//                Console.WriteLine(" Added Successfully!");
//            }
//            break;
//        case 5:
//            Console.Write("which Node  what do you want to Delete: ");
//            string DeleteElement = Console.ReadLine();
//            if (linkedList.Find(DeleteElement) != null)
//            {
//                linkedList.Remove(DeleteElement);
//                Console.WriteLine($"Node {DeleteElement} Deleted Successfully!");

//            }
//            break;
//        case 6:
//            if(linkedList.Count > 0)
//            {

//                Console.WriteLine($"First Element ({linkedList.First}) Removed Successfully!");
//                linkedList.RemoveFirst();
//            }

//            break;
//        case 7:
//            if (linkedList.Count > 0)
//            {
//                linkedList.RemoveLast();
//                Console.WriteLine($"Last Element ({linkedList.Last}) Removed Successfully!");
//            }
//            break;
//        case 8:
//            if (linkedList.Count > 0)
//            {
//                Console.WriteLine($"First Element : {linkedList.First}");
//            }
//            break;
//        case 9:
//            if (linkedList.Count > 0)
//            {
//                Console.WriteLine($"First Element : {linkedList.Last}");
//            }
//            break;
//        case 10:
//            foreach (var item in linkedList)
//            {
//                Console.WriteLine($"{item} ");
//            }
//            break;
//        case 11:
//            if (linkedList.Count > 0)
//                Console.WriteLine($"The Count of Nodes {linkedList.Count}");
//            break;
//        case 0:
//            return;
//        default:    
//            break;
//    }


//}while (true);








//LinkedList<string> linkedList = new LinkedList<string>();

//do
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("\n------- LinkedList ---------");
//    Console.WriteLine($@"1. AddFirst
//2. AddLast
//3. AddAfter
//4. AddBefore
//5. Remove by Value
//6. RemoveFirst
//7. RemoveLast
//8. Display First Node
//9. Display Last Node
//10. Print All Elements
//11. Count
//0. Exit");
//    Console.ForegroundColor = ConsoleColor.White;

//    Console.Write("Enter your choice: ");
//    int choice = int.Parse(Console.ReadLine());

//    switch (choice)
//    {
//        case 1:
//            Console.Write("Enter the first Element: ");
//            linkedList.AddFirst(Console.ReadLine());
//            Console.WriteLine("First Element Added Successfully!");
//            break;

//        case 2:
//            Console.Write("Enter the last Element: ");
//            linkedList.AddLast(Console.ReadLine());
//            Console.WriteLine("Last Element Added Successfully!");
//            break;

//        case 3:
//            Console.Write("Enter the Node to search: ");
//            var searchNode = linkedList.Find(Console.ReadLine());
//            if (searchNode != null)
//            {
//                Console.Write("Enter the New Value to Add After: ");
//                linkedList.AddAfter(searchNode, Console.ReadLine());
//                Console.WriteLine("Added Successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Node not found.");
//            }
//            break;

//        case 4:
//            Console.Write("Enter the Node to search: ");
//            searchNode = linkedList.Find(Console.ReadLine());
//            if (searchNode != null)
//            {
//                Console.Write("Enter the New Value to Add Before: ");
//                linkedList.AddBefore(searchNode, Console.ReadLine());
//                Console.WriteLine("Added Successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Node not found.");
//            }
//            break;

//        case 5:
//            Console.Write("Enter the Value you want to Delete: ");
//            string deleteElement = Console.ReadLine();
//            if (linkedList.Remove(deleteElement))
//            {
//                Console.WriteLine($"Node '{deleteElement}' Deleted Successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Node not found.");
//            }
//            break;

//        case 6:
//            if (linkedList.Count > 0)
//            {
//                Console.WriteLine($"First Element '{linkedList.First.Value}' Removed Successfully!");
//                linkedList.RemoveFirst();
//            }
//            else
//            {
//                Console.WriteLine("LinkedList is empty.");
//            }
//            break;

//        case 7:
//            if (linkedList.Count > 0)
//            {
//                Console.WriteLine($"Last Element '{linkedList.Last.Value}' Removed Successfully!");
//                linkedList.RemoveLast();
//            }
//            else
//            {
//                Console.WriteLine("LinkedList is empty.");
//            }
//            break;

//        case 8:
//            if (linkedList.Count > 0)
//            {
//                Console.WriteLine($"First Element: {linkedList.First.Value}");
//            }
//            else
//            {
//                Console.WriteLine("LinkedList is empty.");
//            }
//            break;

//        case 9:
//            if (linkedList.Count > 0)
//            {
//                Console.WriteLine($"Last Element: {linkedList.Last.Value}");
//            }
//            else
//            {
//                Console.WriteLine("LinkedList is empty.");
//            }
//            break;

//        case 10:
//            if (linkedList.Count > 0)
//            {
//                Console.WriteLine("LinkedList Elements:");
//                foreach (var item in linkedList)
//                {
//                    Console.WriteLine($"- {item}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("LinkedList is empty.");
//            }
//            break;

//        case 11:
//            Console.WriteLine($"Count: {linkedList.Count}");
//            break;

//        case 0:
//            return;

//        default:
//            Console.WriteLine("Invalid choice.");
//            break;
//    }

//} while (true);





















//var dict = new Dictionary<int, string>();
//dict.Add(1, "Nada");
//dict.Add(2, "Ahmed");

//Console.WriteLine(dict[1]); // Nada

//foreach (var item in dict)
//{
//    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//}
//Console.WriteLine("------------------------------------");

//dict.TryGetValue(1, out var value);
//Console.WriteLine(value);
//foreach (var item in dict.Keys)
//{
//    Console.WriteLine($"{item} ");
//}
//Console.WriteLine("------------------------------------");
//foreach (var item in dict.Values)
//{
//    Console.WriteLine($"{item} ");
//}

























//Dictionary<string, double> StudentGrades = new Dictionary<string, double>();

//do
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine($@"------- Student Grades System -------
//1. Add Student and Grade
//2. Update Student Grade
//3. Remove Student
//4. Search for Student
//5. Display All Students and Grades
//6. Display Class Average
//7. Display Highest and Lowest Grades
//0. Exit
//");
//    Console.ForegroundColor = ConsoleColor.White;
//    Console.Write("Enter Your option: ");

//    if (!int.TryParse(Console.ReadLine(), out int option))
//    {
//        Console.WriteLine("Invalid input. Please enter a number.");
//        continue;
//    }

//    Console.WriteLine(); // فاصل مرئي

//    switch (option)
//    {
//        case 1:
//            Console.Write("Enter the Student Name: ");
//            string studentName = Console.ReadLine();
//            Console.Write("Enter the Student Grade: ");
//            if (double.TryParse(Console.ReadLine(), out double studentGrade))
//            {
//                if (!StudentGrades.ContainsKey(studentName))
//                {
//                    StudentGrades.Add(studentName, studentGrade);
//                    Console.WriteLine("Student Added Successfully!");
//                }
//                else
//                {
//                    Console.WriteLine("Student already exists.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Invalid grade.");
//            }
//            break;

//        case 2:
//            Console.Write("Enter the Student Name to update: ");
//            string updateName = Console.ReadLine();
//            if (StudentGrades.ContainsKey(updateName))
//            {
//                Console.Write("Enter the new grade: ");
//                if (double.TryParse(Console.ReadLine(), out double newGrade))
//                {
//                    StudentGrades[updateName] = newGrade;
//                    Console.WriteLine("Grade updated successfully!");
//                }
//                else
//                {
//                    Console.WriteLine("Invalid grade.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Student not found.");
//            }
//            break;

//        case 3:
//            Console.Write("Enter the Student Name to remove: ");
//            string removeName = Console.ReadLine();
//            if (StudentGrades.Remove(removeName))
//                Console.WriteLine("Student removed successfully.");
//            else
//                Console.WriteLine("Student not found.");
//            break;

//        case 4:
//            Console.Write("Enter the Student Name to search: ");
//            string searchName = Console.ReadLine();
//            if (StudentGrades.TryGetValue(searchName, out double foundGrade))
//                Console.WriteLine($"Student: {searchName} | Grade: {foundGrade}");
//            else
//                Console.WriteLine("Student not found.");
//            break;

//        case 5:
//            Console.WriteLine("------ All Students ------");
//            if (StudentGrades.Count == 0)
//                Console.WriteLine("No students available.");
//            else
//            {
//                foreach (var s in StudentGrades)
//                    Console.WriteLine($"Name: {s.Key} | Grade: {s.Value}");
//            }
//            break;

//        case 6:
//            if (StudentGrades.Count == 0)
//                Console.WriteLine("No grades to calculate average.");
//            else
//            {
//                double avg = StudentGrades.Values.Average();
//                Console.WriteLine($"Class Average: {avg:F2}");
//            }
//            break;

//        case 7:
//            if (StudentGrades.Count == 0)
//                Console.WriteLine("No grades available.");
//            else
//            {
//                double max = StudentGrades.Values.Max();
//                double min = StudentGrades.Values.Min();
//                Console.WriteLine($"Highest Grade: {max}");
//                Console.WriteLine($"Lowest Grade: {min}");
//            }
//            break;

//        case 0:
//            Console.WriteLine("Exiting... Goodbye!");
//            return;

//        default:
//            Console.WriteLine("Invalid option. Please choose between 0 and 7.");
//            break;
//    }

//    Console.WriteLine("\nPress Enter to continue...");
//    Console.ReadLine();
//    Console.Clear();

//} while (true);





//Dictionary<string,double> Products = new Dictionary<string,double>();
//do
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine("\n------------- Store Products Price System -------------");
//    Console.WriteLine($@"1.Add Product.
//2.Update Product Price.
//3.Remove Product.
//4.Search For Product.
//5.Dispaly All Products.
//6.Display Expensive Product.
//7.Display Cheap Product.
//0.Exit.");

//    Console.ForegroundColor = ConsoleColor.White;
//    Console.Write("Enter Your Choice: ");
//    int Choice=int.Parse(Console.ReadLine());
//    switch (Choice)
//    {
//        case 0:
//            return;
//        case 1:

//            Console.Write("Enter The Product Name :");
//           string productName= Console.ReadLine();
//            Console.Write("Enter The Product Price :");
//            double productPrice=Double.Parse(Console.ReadLine());
//            if (!Products.ContainsKey(productName))
//            {
//                Products.Add(productName, productPrice);

//                Console.ForegroundColor = ConsoleColor.Green;
//                Console.WriteLine("Product Added Successfully!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;

//                Console.WriteLine("Product already exists.");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            break;
//        case 2:
//            Console.Write("Enter The Product Name For Search:");
//            string Search = Console.ReadLine();
//            if (Products.ContainsKey(Search))
//            {
//                Console.Write("Enter The New Price :");
//                Products[Search] = double.Parse(Console.ReadLine());
//                Console.ForegroundColor = ConsoleColor.Blue;
//                Console.WriteLine("Product Updated Successfully!");
//                Console.ForegroundColor = ConsoleColor.White;

//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Product Not Exist!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            break;
//        case 3:
//            Console.Write("Enter The Product Name For Delete:");
//            string Deleted = Console.ReadLine();
//            if (Products.ContainsKey(Deleted))
//            {
//               Products.Remove(Deleted);

//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Product Deleted Successfully!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Product Not Exist!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            break;
//        case 4:
//            Console.Write("Enter The Product Name For Search:");
//             Search = Console.ReadLine();
//            if (Products.ContainsKey(Search))
//            {


//                Console.ForegroundColor = ConsoleColor.Gray;
//                Console.WriteLine($"Product Name is : {Search} | Product Price is : {Products[Search]} " );
//                Console.ForegroundColor = ConsoleColor.White;

//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("Product Not Exist!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            break;
//        case 5:
//            if(Products.Count >0)
//            {
//                Console.WriteLine("-------------- All Products --------------");
//                foreach (var item in Products)
//                {
//                    Console.ForegroundColor = ConsoleColor.Gray;
//                    Console.WriteLine($"Product Name is : {item.Key} | Product Price is : {item.Value} ");
//                    Console.ForegroundColor = ConsoleColor.White;
//                }
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("No Products Founded!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }

//            break;
//        case 6:
//            if(Products.Count> 0)
//            {
//                var getPrice = Products.Values;
//                double max = getPrice.Max();
//                Console.ForegroundColor = ConsoleColor.Yellow;
//                Console.WriteLine($"The Max  Price is : {max}  ");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//              else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("No Products Founded!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            break;
//        case 7:
//            if(Products.Count> 0) {
//                var getPrice = Products.Values;
//                double min = getPrice.Min();
//                Console.ForegroundColor = ConsoleColor.Yellow;
//                Console.WriteLine($"The Min  Price is : {min}  ");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            else
//            {
//                Console.ForegroundColor = ConsoleColor.Red;
//                Console.WriteLine("No Products Founded!");
//                Console.ForegroundColor = ConsoleColor.White;
//            }
//            break;

//        default:
//            break;
//    }
//}
//while (true);






























//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static Dictionary<string, double> products = new Dictionary<string, double>()
//    {
//        {"Laptop", 20000},
//        {"Mouse", 300},
//        {"Keyboard", 800},
//        {"Monitor", 5000},
//        {"Headphones", 1500}
//    };

//    static Queue<string> customersQueue = new Queue<string>();
//    static Dictionary<string, Stack<string>> purchaseHistory = new Dictionary<string, Stack<string>>();
//    static List<string> topSelling = new List<string>();
//    static LinkedList<string> displayedProducts = new LinkedList<string>(products.Keys); // منتجات تظهر حاليًا في الواجهة

//    static void Main()
//    {
//        while (true)
//        {
//            Console.WriteLine("\n=== Mini Store System ===");
//            Console.WriteLine("1. Add Customer to Queue");
//            Console.WriteLine("2. Serve Next Customer");
//            Console.WriteLine("3. Show Top Selling Products");
//            Console.WriteLine("4. Show Displayed Products");
//            Console.WriteLine("5. Exit");
//            Console.Write("Choose: ");
//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    AddCustomer();
//                    break;
//                case "2":
//                    ServeCustomer();
//                    break;
//                case "3":
//                    ShowTopSelling();
//                    break;
//                case "4":
//                    ShowDisplayedProducts();
//                    break;
//                case "5":
//                    return;
//                default:
//                    Console.WriteLine("Invalid choice.");
//                    break;
//            }
//        }
//    }

//    static void AddCustomer()
//    {
//        Console.Write("Enter customer name: ");
//        string name = Console.ReadLine();
//        customersQueue.Enqueue(name);
//        Console.WriteLine($"{name} added to the queue.");
//    }

//    static void ServeCustomer()
//    {
//        if (customersQueue.Count == 0)
//        {
//            Console.WriteLine("No customers in queue.");
//            return;
//        }

//        string customer = customersQueue.Dequeue();
//        Console.WriteLine($"\nServing {customer}...");

//        purchaseHistory[customer] = new Stack<string>();

//        while (true)
//        {
//            Console.WriteLine("Available Products:");
//            foreach (var p in products)
//                Console.WriteLine($"{p.Key}: {p.Value} EGP");

//            Console.WriteLine("Choose product to buy or type 'undo' or 'done':");
//            string input = Console.ReadLine();

//            if (input == "done")
//                break;
//            else if (input == "undo")
//            {
//                if (purchaseHistory[customer].Count > 0)
//                {
//                    string removed = purchaseHistory[customer].Pop();
//                    Console.WriteLine($"Removed last purchase: {removed}");
//                }
//                else
//                {
//                    Console.WriteLine("Nothing to undo.");
//                }
//            }
//            else if (products.ContainsKey(input))
//            {
//                purchaseHistory[customer].Push(input);
//                topSelling.Add(input);
//                Console.WriteLine($"Added {input} to {customer}'s purchases.");
//            }
//            else
//            {
//                Console.WriteLine("Invalid product.");
//            }
//        }

//        Console.WriteLine($"\n{customer}'s final purchases:");
//        foreach (var item in purchaseHistory[customer].Reverse())
//            Console.WriteLine($"- {item}");
//    }

//    static void ShowTopSelling()
//    {
//        Console.WriteLine("\nTop Selling Products:");

//        var grouped = topSelling
//            .GroupBy(p => p)
//            .OrderByDescending(g => g.Count())
//            .Take(5);

//        foreach (var group in grouped)
//            Console.WriteLine($"{group.Key}: Sold {group.Count()} times");
//    }

//    static void ShowDisplayedProducts()
//    {
//        Console.WriteLine("\nCurrently Displayed Products:");
//        foreach (var product in displayedProducts)
//            Console.WriteLine(product);
//    }
//}







/*
 * 
 * :

🛍️ سيناريو: متجر إلكتروني مصغّر
🧠 هدف التمرين:
نتعلم استخدام:

Dictionary لتخزين المنتجات وأسعارها

Queue لطابور الزبائن

Stack لتخزين عمليات الشراء الخاصة بكل زبون (undo)

List لعرض المنتجات الأكثر مبيعًا (top-selling)

LinkedList كمخزن مرن للمنتجات المعروضة حاليًا



=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 1
Enter customer name: Sama
Sama added to the queue.

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 1
Enter customer name: Nada
Nada added to the queue.

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 4

Currently Displayed Products:
Laptop
Mouse
Keyboard
Monitor
Headphones

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 2

Serving Sama...
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Laptop
Added Laptop to Sama's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Mouse
Added Mouse to Sama's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
undo
Invalid product.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
undo
Removed last purchase: Mouse
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Headphones
Added Headphones to Sama's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
done

Sama's final purchases:
- Laptop
- Headphones

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 3

Top Selling Products:
Laptop: Sold 1 times
Mouse: Sold 1 times
Headphones: Sold 1 times

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 2

Serving Nada...
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Keyboard
Added Keyboard to Nada's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Laptop
Added Laptop to Nada's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Mouse
Added Mouse to Nada's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
done

Nada's final purchases:
- Keyboard
- Laptop
- Mouse

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 3

Top Selling Products:
Laptop: Sold 2 times
Mouse: Sold 2 times
Headphones: Sold 1 times
Keyboard: Sold 1 times

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose: 4

Currently Displayed Products:
Laptop
Mouse
Keyboard
Monitor
Headphones

=== Mini Store System ===
1. Add Customer to Queue
2. Serve Next Customer
3. Show Top Selling Products
4. Show Displayed Products
5. Exit
Choose:

*/


var products = new Dictionary<string, double>()
{
    {"Laptop", 20000},
    {"Mouse", 300},
    {"Keyboard", 800},
    {"Monitor", 5000},
    {"Headphones", 1500}
};
var customers = new Queue<string>();
 Dictionary<string, Stack<string>> purchaseHistory = new Dictionary<string, Stack<string>>();
 List<string> topSelling = new List<string>();
 LinkedList<string> displayedProducts = new LinkedList<string>(products.Keys);

do
{
    Console.WriteLine("\n=== Mini Store System ===");
    Console.WriteLine("1. Add Customer to Queue");
    Console.WriteLine("2. Serve Next Customer");
    Console.WriteLine("3. Show Top Selling Products");
    Console.WriteLine("4. Show Displayed Products");
    Console.WriteLine("5. Exit");
    Console.Write("Choose: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddCustomer();
            break;
        case "2":
             ServeCustomer();
            break;
        case "3":
             ShowTopSelling();
            break;
        case "4":
            ShowDisplayedProducts();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

} while (true);

void ShowDisplayedProducts()
{
    Console.WriteLine("----------Currently Displayed Products:----------");
    //foreach (var product in products.Keys)
    //{
    //    Console.WriteLine($"Product Name : {product}");
    //}
    foreach (var item in displayedProducts)
    {
        Console.WriteLine($"{item}");
    }
}
void AddCustomer()
{
    Console.Write("Enter The Customer Name : ");
    string newCustomer = Console.ReadLine();
    customers.Enqueue(newCustomer);
    Console.WriteLine($"{newCustomer} Added Successfully to the queue!");
}
void ServeCustomer()
{
    // عشان اعمل serve محتاج ايه 
    /*
     * احدد العميل customer   peek()
     * اخزن order بتاعه باسمه  stack عشان اقدر اعمل undo بس هربط ازاي customer ب order 
     * done dequeue()
     * undo  pop()
     * 
     * 
     * 
     * 
Serving Sama...
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Laptop
Added Laptop to Sama's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Mouse
Added Mouse to Sama's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
undo
Invalid product.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
undo
Removed last purchase: Mouse
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
Headphones
Added Headphones to Sama's purchases.
Available Products:
Laptop: 20000 EGP
Mouse: 300 EGP
Keyboard: 800 EGP
Monitor: 5000 EGP
Headphones: 1500 EGP
Choose product to buy or type 'undo' or 'done':
done

Sama's final purchases:
- Laptop
- Headphones
     * 
     * */
    // if no one in queue
    if (customers.Count == 0)
    {
        Console.WriteLine("No Customers Founded!");
    }
    else
    {
        Console.WriteLine($"{customers.Peek()} Serving.....");
        Stack<string> orderForCustomer = new Stack<string>();
        bool result = true;
        do
        {
            Console.WriteLine(" Available Products: ");
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key} : {product.Value}");
            }

            Console.WriteLine("----------Choose Product or type undo or done----------");

            var res = Console.ReadLine();
            if (products.ContainsKey(res))
            {
                orderForCustomer.Push(res);
                Console.WriteLine($"Added {res} to {customers.Peek()}'s purchases.\r\n");

                result = true;
            }
            else if (res.ToLower() == "undo")
            {
                if (orderForCustomer.Count > 0)
                {
                    string removedItem = orderForCustomer.Pop();
                    Console.WriteLine($"Removed last purchase: {removedItem}");
                }
                else
                {
                    Console.WriteLine("Nothing to undo.");
                }
                result = true;
            }
            else if (res.ToLower() == "done")
            {
                purchaseHistory.Add(customers.Peek(), orderForCustomer);
                topSelling.AddRange([.. orderForCustomer]);
                Console.WriteLine($"{customers.Peek()}'s final purchases: ");
                foreach (var order in orderForCustomer.Reverse())
                {
                    Console.WriteLine($"- {order}");
                }
                customers.Dequeue();
                result = false;

            }
            else
            {
                Console.WriteLine("Invalid product.");
            }
        } while (result);
    }
}
void ShowTopSelling()
{
    //    Top Selling Products:
    //Laptop: Sold 2 times
    //Mouse: Sold 2 times
    //Headphones: Sold 1 times
    //Keyboard: Sold 1 times
    if (topSelling.Count > 0)
    {
        var numberOfElemnts = new Dictionary<string, int>();
        foreach (var product in topSelling)
        {
            if (numberOfElemnts.ContainsKey(product))
            {
                numberOfElemnts[product] += 1;
            }
            else
            {
                numberOfElemnts.Add(product, 1);
            }
        }
        numberOfElemnts.Order();
        Console.WriteLine("Top Selling Products: ");
        
            foreach (var item in numberOfElemnts)
            {
                Console.WriteLine($"{item.Key}: Sold {item.Value} times");
            }
        
    }
    else
    {
        Console.WriteLine("No Orders Yet!");
    }
}