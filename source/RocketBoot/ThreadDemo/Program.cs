using System;
using System.Threading;
using ThreadDemo.source;

namespace ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleThread simpleThread = new SimpleThread();
            simpleThread.CreateThreadNoParam();
            simpleThread.CreateThreadWithParam("Hello, Thread With Param");
            int tid = simpleThread.ThreadNoParam.ManagedThreadId;
            Console.WriteLine(tid);
            ThreadState state = simpleThread.ThreadNoParam.ThreadState;
            Console.WriteLine(state);
        }
    }
}
