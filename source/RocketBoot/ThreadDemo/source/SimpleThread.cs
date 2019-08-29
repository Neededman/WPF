using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadDemo.source
{
    public class SimpleThread
    {
        public Thread ThreadNoParam { get; set; }
        public Thread ThreadWithParam { get; set; }
        public void CreateThreadNoParam()
        {
            this.ThreadNoParam = new Thread(new ThreadStart(Speak));
            this.ThreadNoParam.Start();
        }

        public void CreateThreadWithParam(object word)
        {
            this.ThreadWithParam = new Thread(new ParameterizedThreadStart(SpeakWithParam));
            this.ThreadWithParam.Start(word);
        }

        public void SpeakWithParam(object word)
        {
            Console.WriteLine(word);
        }

        public void Speak()
        {
            Console.WriteLine("Hello, Thread Without Param !");
        }
    }
}
