using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

public class ThreadManager
{
    private Thread queryThread;
    public event Action QueryCompleted;
    private AutoResetEvent queryCompletedEvent;

    public ThreadManager()
    {
        //queryCompletedEvent = new AutoResetEvent(false);
    }

    public void RunQueryInBackground()
    {
        if (queryThread != null && queryThread.IsAlive)
        {
            MessageBox.Show("Another query is already running. Please wait for it to finish.");
            return;
        }

        queryThread = new Thread(() =>
        {
            RunQuery();
            Console.WriteLine("Thread running");
            OnQueryCompleted();

            //// Signal the completion of the query
            //queryCompletedEvent.Set();

        });

        queryThread.Start();
    }

    private void RunQuery()
    {
        // Simulate a delay to represent the time taken by the actual database query
        Thread.Sleep(2000);
    }
    protected virtual void OnQueryCompleted()
    {
        QueryCompleted?.Invoke();
    }

    public void WaitForQueryCompletion()
    {
        queryCompletedEvent.WaitOne();
    }

}
