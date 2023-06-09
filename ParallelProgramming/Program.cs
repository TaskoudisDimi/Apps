


namespace ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK CLASS
            //string text1 = "Hello World Test 1";
            //string text2 = "Test 2";
            //var task = new Task<int>(TextLength, text1);
            //task.Start();
            //Task<int> task2 = Task.Factory.StartNew<int>(TextLength, text2);

            //Console.WriteLine($"Length of {text1} is {task.Result}");
            //Console.WriteLine($"Length of {text2} is {task2.Result}");

            //CANCEL TASK

            //var cts = new CancellationTokenSource();
            //var token = cts.Token;


            //token.Register(() =>
            //{
            //    Console.WriteLine("Cancellation has been requested");
            //});

            //var t = new Task(() =>
            //{
            //    int i = 0;
            //    while (true)
            //    {
            //        token.ThrowIfCancellationRequested();
            //        Console.WriteLine($"{i++}\t");   
            //    }
            //}, token);
            //t.Start();

            //Task.Factory.StartNew(() =>
            //{
            //    token.WaitHandle.WaitOne();
            //    Console.WriteLine("Wait handle released, cancelation was requested");
            //});
            //Console.ReadLine();
            //cts.Cancel();

            //Another way to cancel a token
            //var planned = new CancellationTokenSource();
            //var preventative = new CancellationTokenSource();
            //var emergency = new CancellationTokenSource();

            //var paranoid = CancellationTokenSource.CreateLinkedTokenSource(planned.Token, preventative.Token, emergency.Token);

            //Task.Factory.StartNew(() =>
            //{
            //    int i = 0;
            //    while (true)
            //    {
            //        paranoid.Token.ThrowIfCancellationRequested();
            //        Console.WriteLine($"{i++}\t");
            //        Thread.Sleep(1000);
            //    }
            //}, paranoid.Token);

            //Console.ReadLine();
            //emergency.Cancel();

            //WAITING FOR TIME TO PASS
            //The SpinWait is more efficient from Thread.Sleep(1000)


            //var cts = new CancellationTokenSource();
            //var token = cts.Token;

            //var t = new Task(() =>
            //{
            //    Console.WriteLine("Press any key to disarm; You have 5 seconds");
            //    bool result = token.WaitHandle.WaitOne(5000);
            //    Console.WriteLine(result ? "Bomb disarmed" : "Boom!!!");
            //},token);
            //t.Start();
            //Console.ReadKey();
            //cts.Cancel();

            //var cts = new CancellationTokenSource();
            //var token = cts.Token;
            //var t = new Task(() =>
            //{
            //    Console.WriteLine("I take 5 seconds.");
            //    for(int i = 0; i < 10; i++)
            //    {
            //        token.ThrowIfCancellationRequested();
            //        Thread.Sleep(1000);
            //    }
            //    Console.WriteLine("I'm done.");
            //},token);
            //t.Start();

            //Task t2 = Task.Factory.StartNew(() => Thread.Sleep(3000), token);

            //Task.WaitAny(new[] { t, t2 }, 4000, token);

            //Console.WriteLine($"Task t status is {t.Status}");
            //Console.WriteLine($"Task t2 status is {t2.Status}");

            //EXCEPTION HANDLING

            var t = Task.Factory.StartNew(() =>
            {
                throw new InvalidOperationException("Can't do this!") { Source = "t"};
            });
            var t2 = Task.Factory.StartNew(() =>
            {
                throw new AccessViolationException("Can't access this!") { Source = "t2" };
            });
            try
            {
                Task.WaitAll(t, t2);
            }
            catch (AggregateException ae)
            {
                //foreach(var a in ae.InnerExceptions)
                //{
                //    Console.WriteLine($"Exception {a.GetType()} from {a.Source}");
                //}
                ae.Handle(e =>
                {
                    if (e is InvalidOperationException)
                    {
                        Console.WriteLine("Invalid op!");
                        return true;
                    }
                    else return false;
                });
            }

            Console.WriteLine("Main Program done!");
            Console.ReadKey();

        }


        public static int TextLength(object o)
        {
            Console.WriteLine($"\nTask with id {Task.CurrentId} proccessing object {o}");
            return o.ToString().Length;
        }
        public static void Write(object o)
        {
            int i = 1000;
            while (i-- > 0)
            {
                Console.Write(o);
            }
        }
        public static void Write(char c)
        {
            int i = 1000;
            while (i  -- > 0)
            {
                Console.Write(c);
            }
        }

    }
}


