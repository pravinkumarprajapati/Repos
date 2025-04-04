﻿using ConcurrencyControl;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        ThreadHelperClass serverClass = new();
        var result = string.Empty ;
        Thread thread1 = new Thread(new ThreadStart(() =>
                {
                    Console.WriteLine("Thread started.");
                    result= serverClass.Display();
                    Console.WriteLine("Thread completed.");
                }
        ));
        thread1.Start();
        bool IsThreadCompleted = false;
        // Wait for the thread to complete  
        while (!IsThreadCompleted)
        {
            if (thread1.ThreadState == ThreadState.Stopped)
            {
                IsThreadCompleted = true;
                Console.WriteLine($"Thread has completed. {result}");
            }
        }
        string result1 =   serverClass.DisplayAsync().Result;
        Console.WriteLine("Async method completed.");
        Console.ReadLine();
    }   
}