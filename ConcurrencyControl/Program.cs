
using ConcurrencyControl;

ServerClass serverClass = new ServerClass();

Thread thread1 = new Thread(new ThreadStart(serverClass.Display));
thread1.Start();
ThreadState state = thread1.ThreadState;
Console.WriteLine($"Thread state : {state}");

Console.WriteLine("Hello, World!");
