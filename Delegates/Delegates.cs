using System;

namespace DotnetTutorials.Delegates
{
    public delegate void WorkPerformedHandler(int hours, string workType);
    public delegate void WorkCompletedHandler(string workType);

    public class Worker
    {
        public void DoWork(
            int hours,
            string workType,
            WorkPerformedHandler workPerformedHandler,
            WorkCompletedHandler workCompletedHandler)
        {
            for (int i = 0; i < hours; i++)
            {
                Thread.Sleep(1000);

                workPerformedHandler(i + 1, workType);
            }            
            workCompletedHandler(workType);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Worker worker = new Worker();

            worker.DoWork(
                5,
                "Coding",
                WorkProgress,
                WorkCompleted);

            Console.ReadLine();
        }

        public static void WorkProgress(int hours, string workType)
        {
            Console.WriteLine(hours == 1
                ? $"{hours} hour of {workType} completed."
                : $"{hours} hours of {workType} completed.");
        }
        public static void WorkCompleted(string workType)
        {
            Console.WriteLine($"{workType} work has been completed!");
        }
    }
}