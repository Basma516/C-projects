string? response="";
List<string> tasks = new List<string>();
do
{
    Console.WriteLine("------------ To Do App-------------");
    Console.WriteLine("1.insert new task");
    Console.WriteLine("2.display all tasks");
    Console.WriteLine("3.delete a task");
    Console.WriteLine("4. Exit");
    int option = Convert.ToInt32(Console.ReadLine());


   
    if (option == 1)
    {
        Console.WriteLine("Enter your new Task");
        string? taskName = Console.ReadLine();
        
        tasks.Add(taskName);
        Console.WriteLine("Do You Want To Conyinue? Yes /No");
        response=Console.ReadLine();

    }
    else if (option == 2)
    {
       foreach(var task in tasks)
        {
            Console.WriteLine($"{task}");
        }
        Console.WriteLine("Do You Want To Conyinue? Yes /No");
        response = Console.ReadLine();
   
    }
    else if( option == 3)
    {
        Console.Write("Enter the name of removed task:");
        string? removedTask= Console.ReadLine();
        tasks.Remove(removedTask);
        if (tasks.Remove(removedTask))
        {
            Console.WriteLine("task removed successfully");
        }else
        {
            Console.WriteLine("task not found");
        }
    }
    else if (option == 4)
    {
        break;
    }
    else
    {
        Console.WriteLine("Not a valid option");
    }


} while (response == "y");


