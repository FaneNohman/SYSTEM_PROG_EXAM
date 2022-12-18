using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SystemPorgramExam
{
    internal class ParallelHi
    {
        public static void SayHello()
        {
            CancellationTokenSource cancelSource = new CancellationTokenSource();
            CancellationToken token = cancelSource.Token;

            //cancelation

            //new Task(() =>
            //{
            //    Thread.Sleep(400);
            //    cancelSource.Cancel();
            //}).Start();

            Task[] tasks = new Task[3];
            for(int i=0; i< tasks.Length; i++) {
                tasks[i] = new Task(() => {
                    Thread.Sleep(1000);
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("Canceled");
                        return;
                    }
                    Console.WriteLine("Hi ItStep");
                },token);
                tasks[i].Start();
            }
            if (token.IsCancellationRequested)
            {
                cancelSource.Dispose();
            }
            else
            {
                Task.WaitAll(tasks);

            }
        }
    }
}
