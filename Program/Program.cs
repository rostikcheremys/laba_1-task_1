using System;
using System.Threading;

namespace Program
{
    public delegate void MyDelegate(string text, int t);

    static class Timer
    {
        public static void Method(string text, int t)
        {
            new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine(text);
                    Thread.Sleep(TimeSpan.FromSeconds(t));
                }
            }).Start();
        }
    }
    
    internal abstract class Program
    {
        static void Main()
        {
            MyDelegate myDelegate = Timer.Method;
            
            myDelegate.Invoke("RED", 1);
            myDelegate.Invoke("YELLOW", 5);
        }
    }
}