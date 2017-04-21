using System;

namespace VerySimpleTaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Bryan, again!");
            TaskManager manager = new TaskManager();
            manager.Run();
        }
    }
}
