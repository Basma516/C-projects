
AlarmClock alarm=new AlarmClock();
Person person1 = new Person("Sama");
Person person2 = new Person("Basma");


alarm.AlarmRang += person1.WakeUp;
alarm.AlarmRang += person2.WakeUp;

alarm.Ring();


public class AlarmClock
{
    public delegate void AlarmHandler(string message);
    public event AlarmHandler AlarmRang;
    public void Ring()
    {
        Console.WriteLine("The Alarm is ringing....");
        AlarmRang?.Invoke("Wake Up!");
    }
}
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void WakeUp(string message)
        {
            Console.WriteLine($" {Name} heard the alarm : {message}");
        }
    }

