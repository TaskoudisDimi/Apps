


namespace ParallelProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TASK CLASS
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
            //var t = Task.Factory.StartNew(() =>
            //{
            //    throw new InvalidOperationException("Can't do this!") { Source = "t"};
            //});
            //var t2 = Task.Factory.StartNew(() =>
            //{
            //    throw new AccessViolationException("Can't access this!") { Source = "t2" };
            //});
            //try
            //{
            //    Task.WaitAll(t, t2);
            //}
            //catch (AggregateException ae)
            //{
            //    //foreach(var a in ae.InnerExceptions)
            //    //{
            //    //    Console.WriteLine($"Exception {a.GetType()} from {a.Source}");
            //    //}
            //    ae.Handle(e =>
            //    {
            //        if (e is InvalidOperationException)
            //        {
            //            Console.WriteLine("Invalid op!");
            //            return true;
            //        }
            //        else return false;
            //    });
            //}



            //SUMMARY
            //Create Task with 2 ways:
            ////1)
            //var t = new Task(() =>
            //{
            //    Console.WriteLine("Test");
            //});
            //t.Start();

            ////2)
            //Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("Test");
            //});

            //Tasks can be passed an object
            //Tasks can return values: new Task<T>, task.Result
            //Tasks can report their State: task.IsCompleted, task.IsFaulted, etc.

            //Cancellation
            //Cancellation is supported via CancellationTokenSource, which returns a CancellationToken token = cts.Token
            //The Token is passed into the function Task.Factory.StartNew(() => {},token);
            //To cancel -> cts.Cancel()
            //Task can check with token.IsCancellationRequested or token.ThrowIfCancellationRequested()

            //Waiting for Time to Pass
            //1) Thread.Sleep() 2)token.WaitHangle.WaitOne() -> return a bool indicating whether cancellation was requested in the time period specified
            //Thread.SpinWait()
            //SpinWait.SpinUntil(()=>{}) Spin waiting does not give up the thread's turn
            //Waiting for Single task
            //task.Wiat(optional timeout)
            //Waiting for several tasks
            //Task.WaitAll(t, t2)
            //Task.WaitAAny(t, t2)

            //Console.WriteLine("Main Program done!");
            //Console.ReadKey();

            #endregion

            //DATA SHARING AND SYNCHRONIZATION

            var tasks = new List<Task>();
            var ba = new BankAccount();
            for(int i = 0; i < 10; i++)
            {
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        ba.Deposit(100);
                    }
                }));
                tasks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        ba.WithDraw(100);
                    }
                }));
                
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine($"Final balance is {ba.Balance}");


        }
        #region TASK CLASS
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
        #endregion

    }

    public class BankAccount 
    {
        public object padLock = new object();
        public int Balance { get; private set; }

        public void Deposit(int amount)
        {
            lock(padLock)
            {
                Balance += amount;
            }
        }
        public void WithDraw(int amount)
        {
            lock (padLock)
            {
                Balance -= amount;
            }
        }

    }

}


