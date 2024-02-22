using System;
using System.Threading;

namespace Program
{
    public class Timer
    {
        public void Method(Action function, int t)
        {
            new Thread(() =>
            {
                while (true)
                {
                    function.Invoke();
                    Thread.Sleep(TimeSpan.FromSeconds(t));
                }
            }).Start();
        }
    }
    
    internal abstract class Program
    {
        static void Main()
        {
            Timer timer = new Timer();
            
            timer.Method(() => { Console.WriteLine("RED");}, 2);
            timer.Method(() => { Console.WriteLine("GREEN");}, 4);
        }
    }
}