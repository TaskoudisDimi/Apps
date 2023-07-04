
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Microsoft.Diagnostics.Runtime.Utilities;
using System.Collections.Concurrent;

namespace ParallelProgramming
{
    public class Program
    {

        public static void Main(string[] args)
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

            #region DATA SHARING AND SYNCHRONIZATION

            #region SpinLock
            //var tasks = new List<Task>();

            //var ba = new BankAccount();

            //SpinLock sl = new SpinLock();

            //for (int i = 0; i < 10; i++)
            //{
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        for (int j = 0; j < 1000; j++)
            //        {
            //            var lockTaken = false;
            //            try
            //            {
            //                sl.Enter(ref lockTaken);
            //                ba.Deposit(100);
            //            }
            //            finally
            //            {
            //                if (lockTaken) sl.Exit();
            //            }
            //        }
            //    }));
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        for (int j = 0; j < 1000; j++)
            //        {
            //            var lockTaken = false;
            //            try
            //            {
            //                sl.Enter(ref lockTaken);
            //                ba.WithDraw(100);
            //            }
            //            finally
            //            {
            //                if (lockTaken) sl.Exit();
            //            }
            //        }
            //    }));

            //}
            //Task.WaitAll(tasks.ToArray());
            //Console.WriteLine($"Final balance is {ba.Balance}");

            ////SpinLock Example
            //LockRecursion(5);
            #endregion

            #region Mutex
            //var tasks = new List<Task>();
            //var ba = new BankAccount();
            //var ba2 = new BankAccount();

            //Mutex mutex = new Mutex();
            //Mutex mutex2 = new Mutex();


            //for (int i = 0; i < 10; i++)
            //{
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        for (int j = 0; j < 1000; j++)
            //        {
            //            bool haveLock = mutex.WaitOne();
            //            try
            //            {
            //                ba.Deposit(1);
            //            }
            //            finally
            //            {
            //                if (haveLock) mutex.ReleaseMutex();
            //            }
            //        }
            //    }));
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        for (int j = 0; j < 1000; j++)
            //        {
            //            bool haveLock = mutex2.WaitOne();
            //            try
            //            {
            //                ba2.Deposit(1);
            //            }
            //            finally
            //            {
            //                if (haveLock) mutex2.ReleaseMutex();
            //            }
            //        }
            //    }));
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        for (int j = 0; j < 1000; j++)
            //        {
            //            bool havelock = WaitHandle.WaitAll(new[] { mutex, mutex2 });
            //            try
            //            {
            //                ba.Transfer(ba2, 1);
            //            }
            //            finally
            //            {
            //                if (havelock)
            //                {
            //                    mutex.ReleaseMutex();
            //                    mutex2.ReleaseMutex();
            //                }
            //            }
            //        }
            //    }));
            //}
            //Task.WaitAll(tasks.ToArray());
            //Console.WriteLine($"Final balance ba is {ba.Balance}");
            //Console.WriteLine($"Final balance ba2 is {ba2.Balance}");
            #endregion

            #region ReadLock WriteLock
            //int x = 0;
            //var tasks = new List<Task>();
            //for(int i = 0; i < 10; i++)
            //{
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        padlock.EnterReadLock();
            //        Console.WriteLine($"Entered read lock, x = {x}");
            //        Thread.Sleep(5000);
            //        padlock.ExitReadLock();
            //        Console.WriteLine($"Exited read lock, x = {x}");

            //    }));
            //}
            //try
            //{
            //    Task.WaitAll(tasks.ToArray());

            //}
            //catch(AggregateException ae)
            //{
            //    ae.Handle(e =>
            //    {
            //        Console.WriteLine(e);
            //        return true;
            //    });

            //}
            //while (true)
            //{
            //    Console.ReadKey();
            //    padlock.EnterWriteLock();
            //    Console.WriteLine("Write lock acquired");
            //    int newValue = random.Next(10);
            //    x = newValue;
            //    Console.WriteLine($"Set x =  {x}");
            //    padlock.ExitWriteLock();
            //    Console.WriteLine("Write lock released");
            //}
            #endregion

            //Summary
            //lock keyword
            //Typically locks on an existing object, Best to make a new object to lock on
            //Monitor.Enter()/Exit()
            //Blocks until a lock is available

            //Useful for automically changing low-level primitives
            //Interlock.Increment()/Decrement()
            //Interlock.Add()
            //Exchange()/CompareExchange()


            //A sping lock wastes CPU cucles without yielding
            //Enter() to take, Exit() to release
            //Lock recursion = ability to enter a lock twice on the same thread
            //SpinLock doesn't support lock recursion
            //Owner tracking helps keep a record of thread that acquied the lock 

            //Mutex
            //A waithandle-derived synchronization primitive
            //WaitOne() to acquire 
            //ReleaseMutex() -> release
            //Mutex.WaitAll() -> to acquire several
            //Global/named Mutexs are shared between procceses

            //Read-Writer Locks
            //A reader-writer can lock for reading or writing
            //Suports lock recursion
            //Supports upgradeability

            #endregion


            #region Concurrent Collections

            #region Concurrent Dictionary
            //Task.Factory.StartNew(AddParis).Wait();
            //AddParis();
            //capitals["Russia"] = "Leningrand";
            //capitals.AddOrUpdate("Russia", "Moscow", (k, old) => old + "--> Moscow");
            //Console.WriteLine($"The capital of Russia is {capitals["Russia"]}");


            //var capOfSweden = capitals.GetOrAdd("Sweden", "Sctocholm");
            //Console.WriteLine($"The capital of Sweden is {capOfSweden}");

            //const string toRemove = "Russia";
            //string removed;
            //var didRemove = capitals.TryRemove(toRemove, out removed);
            //if (didRemove)
            //{
            //    Console.WriteLine($"We just removed {removed}");
            //}
            //else
            //{
            //    Console.WriteLine($"Failed to remove the capital of {toRemove}");
            //}

            //foreach (var kv in capitals)
            //{
            //    Console.WriteLine($" - {kv.Value} is the capital of {kv.Key}");
            //}
            #endregion

            #region Concurrent Queue
            //var q = new ConcurrentQueue<int>();
            //q.Enqueue(1);
            //q.Enqueue(2);

            //int result;
            //if(q.TryDequeue(out result))
            //{
            //    Console.WriteLine($"Removed element {result}");
            //}
            //if(q.TryPeek(out result))
            //{
            //    Console.WriteLine($"Front element is {result}");
            //}
            #endregion

            #region Concurrent Stack
            //var stack = new ConcurrentStack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //int result;
            //if(stack.TryPeek(out result))
            //{
            //    Console.WriteLine($"{result} is on top");
            //}
            //if (stack.TryPop(out result))
            //{
            //    Console.WriteLine($"Popped {result}");
            //}
            //var items = new int[5];
            //if (stack.TryPopRange(items, 0, 5) > 0)
            //{
            //    var text = string.Join(", ", items.Select(i => i.ToString()));
            //    Console.WriteLine($"Popped these items {text}");
            //}

            #endregion

            #region Concurrent Bag

            //var bag = new ConcurrentBag<int>();
            //var tasks = new List<Task>();
            //for(int i = 0; i < 10; i++)
            //{
            //    var i1 = i;
            //    tasks.Add(Task.Factory.StartNew(() =>
            //    {
            //        bag.Add(i1);
            //        Console.WriteLine($"{Task.CurrentId} has added {i1}");
            //        int result;
            //        if(bag.TryPeek(out result))
            //        {
            //            Console.WriteLine($"{Task.CurrentId} has peeked the value {result}");
            //        }

            //    }));
            //    Task.WaitAll(tasks.ToArray());

            //    int last;
            //    if(bag.TryTake(out last))
            //    {
            //        Console.WriteLine($"I got {last}");
            //    }
            //}
            #endregion

            #region Producer-Consumer Pattern
            //Task.Factory.StartNew(ProductAndConsume, cts.Token);
            //Console.ReadKey();
            //cts.Cancel();

            #endregion


            #region Summary
            //Concurrent collections use TryXxx() method, return a bool inndicating success
            //Optimized for multithreaded use, Some ops (Count) can block and make collection slow
            //ConcurrentBag/Queue/Stack
            //A BlockingCollection is a wrapper around one of the IProducerConsumerCollection classes
            //Provides blocking and bounding capabilities

            #endregion

            #endregion

            #region Task Coordination
            //Getting multiple tasks to execute in a particular order

            #region Continuations
            //var task = Task.Factory.StartNew(() => "Task 1");
            //var task2 = Task.Factory.StartNew(() => "Task 2");
            ////var task3 = Task.Factory.ContinueWhenAll(new[] { task, task2 },
            ////    tasks =>
            ////    {
            ////        Console.WriteLine("Tasks completed:");
            ////        foreach (var t in tasks)
            ////            Console.WriteLine(" - " + t.Result);
            ////        Console.WriteLine("All tasks done!");
            ////    });
            //var task3 = Task.Factory.ContinueWhenAny(new[] { task, task2 },
            //    t =>
            //    {
            //        Console.WriteLine("Tasks completed:");
            //        Console.WriteLine(" - " + t.Result);
            //        Console.WriteLine("All tasks done!");
            //    });
            //task3.Wait();
            #endregion

            #region Child Tasks
            //var parent = new Task(() =>
            //{
            //    var child = new Task(() =>
            //    {
            //        Console.WriteLine("Child task starting");
            //        Thread.Sleep(3000);
            //        Console.WriteLine("Child task finishing");
            //        //throw new Exception();
            //    }, TaskCreationOptions.AttachedToParent);

            //    var completionHandler = child.ContinueWith(t =>
            //    {
            //        Console.WriteLine($"Hooray, task {t.Id}'s state is {t.Status}");
            //    }, TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnRanToCompletion);

            //    var failHandler = child.ContinueWith(t =>
            //    {
            //        Console.WriteLine(value: $"Oops, task {t.Id}'s state is {t.Status}");
            //    }, TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnFaulted);

            //    child.Start();
            //});
            //parent.Start();
            //try
            //{
            //    parent.Wait();
            //}
            //catch
            //{

            //}

            #endregion

            #region Barrier 
            //var water = Task.Factory.StartNew(Water);
            //var cup = Task.Factory.StartNew(Cup);
            //var tea = Task.Factory.ContinueWhenAll(new[] { water, cup }, tasks =>
            //{
            //    Console.WriteLine("Enjoy your cup of tea.");
            //});
            //tea.Wait();
            #endregion

            #region CountDown Event

            //for (int i = 0; i < taskCount; i++)
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            //        Console.WriteLine($"Entering task {Task.CurrentId}");
            //        Thread.Sleep(random.Next(1000));
            //        cte.Signal();
            //        Console.WriteLine($"Exiting task {Task.CurrentId}");
            //    });
            //}

            //var finalTask = Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine($"Waiting for other tasks to complete in {Task.CurrentId}");
            //    cte.Wait();
            //    Console.WriteLine($"All tasks completed");
            //});
            //finalTask.Wait();


            #endregion

            #region ManualResetEventsSlim AutoResetEvent

            //var evt = new ManualResetEventSlim();

            //Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("Boiling water");
            //    evt.Set();
            //});

            //var makeTea = Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("Waiting for water..");
            //    evt.Wait();
            //    Console.WriteLine("Here is your tea");
            //});
            //makeTea.Wait();

            //var evt2 = new AutoResetEvent(false); //false
            //Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("Boiling water");
            //    evt2.Set(); //true
            //});

            //var makeTea2 = Task.Factory.StartNew(() =>
            //{
            //    Console.WriteLine("Waiting for water..");
            //    evt2.WaitOne(); //false
            //    Console.WriteLine("Here is your tea");
            //    var ok = evt2.WaitOne(1000);
            //    if (ok)
            //    {
            //        Console.WriteLine("Enjoy your tea");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No tea for you");
            //    }
            //});
            //makeTea2.Wait();


            #endregion

            #region SemaSphoreSlim

            //var sema = new SemaphoreSlim(2, 10);

            //for (int i = 0; i < 20; i++)
            //{
            //    Task.Factory.StartNew(() =>
            //    {
            //        Console.WriteLine($"Entering task {Task.CurrentId}");
            //        sema.Wait(); //Release Count

            //        Console.WriteLine($"Entering task {Task.CurrentId}");

            //    });
            //}

            //while(sema.CurrentCount <= 2)
            //{
            //    Console.WriteLine($"Semaphore count {sema.CurrentCount}");
            //    Console.ReadKey();
            //    sema.Release(2);
            //}

            #endregion

            #endregion

            #region Parallel Loops

            #region Parallel Invoke/For/Foreach

            //var a = new Action(() => Console.WriteLine($"First {Task.CurrentId}"));
            //var b = new Action(() => Console.WriteLine($"Second {Task.CurrentId}"));
            //var c = new Action(() => Console.WriteLine($"Third {Task.CurrentId}"));

            //Parallel.Invoke(a, b, c);

            //Parallel.For(1, 11, i =>
            //{
            //    Console.WriteLine($"{i * i}\t");
            //});

            //string[] words = { "oh", "what", "a", "night" };
            //Parallel.ForEach(words, word =>
            //{
            //    Console.WriteLine($"{word} has length {word.Length} (task {Task.CurrentId})");
            //});

            //Parallel.ForEach(Range(1, 20, 3), Console.WriteLine); 

            #endregion

            #region Breaking, Cancellations, Exceptions
            //try
            //{
            //    Demo();

            //}
            //catch
            //{

            //}
            #endregion

            #region Thread Local Storage

            //int sum = 0;
            //Parallel.For(1, 1001, () => 0, (x, state, tls) =>
            //{
            //    tls += x;
            //    Console.WriteLine($"Task {Task.CurrentId} has sum {tls}");
            //    return tls;
            //},
            //partialSum =>
            //{
            //    Console.WriteLine($"Partial value of task {Task.CurrentId} is {partialSum}");
            //    Interlocked.Add(ref sum, partialSum);
            //});
            //Console.WriteLine($"Sum of 1...100 = {sum}");



            #endregion

            #region Partiotioning

            //var summary = BenchmarkRunner.Run<Program>();
            //Console.WriteLine(summary);

            #endregion

            #endregion

            #region Parallel LINQ

            #region AsParallel and ParallelQuery

            //PLINQ is parallel LINQ
            //const int count = 50;
            //var items = Enumerable.Range(1, count).ToArray();
            //var results = new int[count];
            //items.AsParallel().ForAll(x =>
            //{
            //    int newValue = x * x * x;
            //    Console.WriteLine($"{newValue} ({Task.CurrentId})\t");
            //    results[x - 1] = newValue;

            //});
            //Console.WriteLine();
            //Console.WriteLine();

            //foreach (var i in results)
            //{
            //    Console.WriteLine($"{i}\t");
            //}
            //Console.WriteLine();

            //var cubes = items.AsParallel().AsOrdered().Select(x => x * x * x);
            //foreach (var i in cubes)
            //{
            //    Console.WriteLine($"{i}\t");
            //}
            //Console.WriteLine();

            #endregion

            #region Cancellation and Exception

            //var cts = new CancellationTokenSource();

            //var items = ParallelEnumerable.Range(1, 20);
            //var results = items.WithCancellation(cts.Token).Select(i =>
            //{

            //    double result = Math.Log10(i);
            //    Console.WriteLine($"i = {i}, tid = {Task.CurrentId}");
            //    return result;
            //});
            //try
            //{
            //    foreach (var item in results)
            //    {
            //        if (item > 1)
            //            cts.Cancel();
            //        Console.WriteLine($"result = {item}");
            //    }
            //}
            //catch (AggregateException ae)
            //{
            //    ae.Handle(e =>
            //    {
            //        Console.WriteLine($"{e.GetType().Name}: {e.Message}");
            //        return true;
            //    });
            //}
            #endregion

            #region Merge Options

            //var numbers = Enumerable.Range(1,20).ToArray();
            //var results = numbers.AsParallel().WithMergeOptions(ParallelMergeOptions.NotBuffered).Select(x =>
            //{
            //    var result = Math.Log10(x);
            //    Console.WriteLine($"Produced {result}");
            //    return result;
            //});
            //foreach(var item in results)
            //{
            //    Console.WriteLine($"Consumed {item}");
            //}

            #endregion


            #region Custom Aggregation

            //var sum = Enumerable.Range(1, 1000).Sum();
            //var sum = Enumerable.Range(1,1000).Aggregate(0, (i, acc) => i + acc);

            //var sum = ParallelEnumerable.Range(1,1000).Aggregate(0, (partialSum,i) => partialSum += i,
            //    (total, subtotal) => total += subtotal, i=> i);

            //Console.WriteLine($"Sum = {sum}");

            #endregion

            #endregion

            #region Asynchronous Programming (Async/Await)



            #endregion



        }
        //static ReaderWriterLockSlim padlock = new ReaderWriterLockSlim();
        //static Random random = new Random();
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
            while (i-- > 0)
            {
                Console.Write(c);
            }
        }
        #endregion

        #region SpinLock
        static SpinLock sl = new SpinLock();
        public static void LockRecursion(int x)
        {
            bool lockTaken = false;
            try
            {
                sl.Enter(ref lockTaken);
            }
            catch (LockRecursionException ex)
            {
                Console.WriteLine($"Exception is {ex}");
            }
            finally
            {
                if (lockTaken)
                {
                    Console.WriteLine($"Took a lock, x = {x}");
                    LockRecursion(x - 1);
                    sl.Exit();
                }
                else
                {
                    Console.WriteLine($"Failed to take a lock x = {x}");
                }
            }
        }
        #endregion

        #region Concurrent Collections

        #region Concurrent Dictionary

        ////the capitals could be calling from several threads
        //private static ConcurrentDictionary<string, string> capitals = new ConcurrentDictionary<string, string>();
        //private static void AddParis()
        //{
        //    bool success = capitals.TryAdd("France", "Paris");
        //    string who = Task.CurrentId.HasValue ? ("Task " + Task.CurrentId) : "Main Thread";
        //    Console.WriteLine($"{who} {(success ? "added" : "did not add")} the element");
        //}

        #endregion

        #region Producer-Consumer Pattern
        //static BlockingCollection<int> messages = 
        //    new BlockingCollection<int>(new ConcurrentBag<int>(), 10);
        //static CancellationTokenSource cts = new CancellationTokenSource();
        //static Random Random = new Random();

        //static void ProductAndConsume()
        //{
        //    var producer = Task.Factory.StartNew(RunProducer);
        //    var consumer = Task.Factory.StartNew(RunConsumer);
        //    try
        //    {
        //        Task.WaitAll(new[] { producer, consumer }, cts.Token);
        //    }
        //    catch
        //    {

        //    }
        //}
        //private static void RunProducer()
        //{
        //    while (true)
        //    {
        //        cts.Token.ThrowIfCancellationRequested();
        //        int i = Random.Next(100);
        //        messages.Add(i);
        //        Console.WriteLine($"+{i}\t");
        //        Thread.Sleep(Random.Next(1000));

        //    }
        //}
        //private static void RunConsumer()
        //{
        //    foreach(var item in messages.GetConsumingEnumerable())
        //    {
        //        cts.Token.ThrowIfCancellationRequested();
        //        Console.WriteLine($"-{item}\t");
        //        Thread.Sleep(Random.Next(1000));
        //    }
        //}

        #endregion


        #endregion

        #region Task Coordination

        #region Barrier 
        //static Barrier barrier = new Barrier(2, b =>
        //{
        //    Console.WriteLine($"Phase {b.CurrentPhaseNumber} is finished");
        //});

        //public static void Water()
        //{
        //    Console.WriteLine("Putting the kettle on (takes a bit longer)");
        //    Thread.Sleep(2000);
        //    barrier.SignalAndWait(); //Signal wait
        //    Console.WriteLine("Pouring water into cup");
        //    barrier.SignalAndWait();
        //    Console.WriteLine("Putting the kettle away");
        //}

        //public static void Cup()
        //{
        //    Console.WriteLine("Finding the nicest cup of tea (fast)");
        //    barrier.SignalAndWait(); //Signal wait
        //    Console.WriteLine("Adding tea.");
        //    barrier.SignalAndWait();
        //    Console.WriteLine("Adding sugar");
        //}
        #endregion

        #region CountDown Event

        //private static int taskCount = 5;
        //static CountdownEvent cte = new CountdownEvent(taskCount);
        //private static Random random = new Random();

        #endregion

        #endregion

        #region Parallel Loops

        #region Parallel Invoke/For/Foreach
        //public static IEnumerable<int> Range(int start, int end, int step)
        //{
        //    for (int i = 0; i < end; i+= step)
        //    {
        //        yield return i;
        //    }
        //}

        #endregion

        #region Breaking, Cancellations, Exceptions
        //public static void Demo()
        //{
        //    Parallel.For(0, 20, (int x, ParallelLoopState state) =>
        //    {
        //        Console.WriteLine($"{x} [{Task.CurrentId}]\t");
        //        if( x == 10)
        //        {
        //            //state.Stop();
        //            //state.Break();
        //            throw new Exception();
        //        }
        //    });
        //}
        #endregion

        #region Partiotioning

        //[Benchmark]
        //public void SquareEachValue()
        //{
        //    const int count = 100000;
        //    var values = Enumerable.Range(0, count);
        //    var results = new int[count];
        //    Parallel.ForEach(values, x => { results[x] = (int)Math.Pow(x, 2); });
        //}

        //[Benchmark]
        //public void SquareEachValueChunked()
        //{
        //    const int count = 100000;
        //    var values = Enumerable.Range(0, count);
        //    var results = new int[count];

        //    var part = Partitioner.Create(0, count, 10000);
        //    Parallel.ForEach(part, range =>
        //    {
        //        for (int i = range.Item1; i < range.Item2; i++)
        //        {
        //            results[i] = (int)Math.Pow(i, 2);
        //        }
        //    });
        //}

        #endregion

        #endregion

        #region Parallel LINQ




        #endregion

    }

    //public class BankAccount
    //{
    //    public object padLock = new object();
    //    private int balance;
    //    public int Balance { get { return balance; } private set { balance = value; } }

    //    public void Deposit(int amount)
    //    {
    //        //lock(padLock)
    //        //{
    //        //    Balance += amount;
    //        //}

    //        Interlocked.Add(ref balance, amount);
    //        //Thread.MemoryBarrier();
    //    }
    //    public void WithDraw(int amount)
    //    {
    //        //lock (padLock)
    //        //{
    //        //    Balance -= amount;
    //        //}
    //        Interlocked.Add(ref balance, -amount);

    //    }

    //    public void Transfer(BankAccount where, int amount)
    //    {
    //        Balance -= amount;
    //        where.Balance += amount;
    //    }

    //}

}


