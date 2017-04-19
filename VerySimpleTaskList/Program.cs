using System;

namespace VerySimpleTaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, Bryan!");
            TaskManager manager = new TaskManager();
            manager.Run();
        }
    }
}
