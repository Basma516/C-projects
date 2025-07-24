while (true)
{
    Console.WriteLine(">>");
    var input = Console.ReadLine().Trim();
    int Whitespaceindex = input.IndexOf(' ');
    string command = input.Substring(0, Whitespaceindex).ToLower();
    string path = input.Substring(Whitespaceindex + 1).Trim();
    if (command == "list")
    {
        string[] dirs = Directory.GetDirectories(path);
        string[] files = Directory.GetFiles(path);
        foreach (var item in dirs)
        {
            Console.WriteLine($"[Dir]       {item}");
        }
        foreach (var item in files)
        {
            Console.WriteLine($"[File]      {item}");
        }
    }
    if (command == "create")
    {
        File.Create(path);
    }
    if (command == "mkdir")
    {
        Directory.CreateDirectory(path);
    }
    if (command == "rmdir")
    {
        if (Directory.Exists(path))
        {
            Directory.Delete(path);
        }
        else if(File.Exists(path)) 
        {
            File.Delete(path);
        }
    }
    if (command == "read")
    {
        if (File.Exists(path))
        {
            var content = File.ReadAllBytes(path);
            Console.WriteLine($"{content}");
        }
    }
    if (command == "info")
    {
        if (File.Exists(path)) {
            var fileInfo = new FileInfo(path);
            Console.WriteLine($"Directory:{fileInfo.Name}");
            Console.WriteLine($"{fileInfo.CreationTime}");
            Console.WriteLine($"{fileInfo.LastWriteTime}");
            Console.WriteLine($"{fileInfo.Length}");
        }
        else if (Directory.Exists(path)) {
            var dirInfo=new DirectoryInfo(path);
            Console.WriteLine($"Directory:{dirInfo.Name}");
            Console.WriteLine($"{dirInfo.CreationTime}");
            Console.WriteLine($"{dirInfo.LastWriteTime}");
            //Console.WriteLine($"{}");
        }
        else
        {
            Console.WriteLine("Invalid Path!");
        }
        if (command == "exit")
        {
            break;
        }
    }
}