using System;
using System.Threading;
public class Multithreading
{
    public static void Thread1()
    {
        for (int value1 = 0; value1 <= 4; value1++)
        {
            Console.WriteLine("Thread one executing");
            if (value1 == 3)
            {
                Thread.Sleep(6000);
            }
        }
    }
    public static void Thread2()
    {
        for (int value2 = 0; value2 <= 4; value2++)
        {
            Console.WriteLine("Thread two executing");
        }
    }
    static public void Main()
    {
        Thread thread1 = new Thread(Thread1);
        Thread thread2 = new Thread(Thread2);
        thread1.Start();
        thread2.Start();
    }
}
