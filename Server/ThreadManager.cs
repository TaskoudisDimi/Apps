using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class ThreadManager
    {

        private Thread _thread;
        public void Start(Action action)
        {
            _thread = new Thread(() =>
            {
                action();
            });
            _thread.Start();
        }

        public void Stop()
        {
            if(_thread != null)
            {
                _thread.Abort();
                _thread = null;
            }
        }

        public bool IsRunning()
        {
            return _thread != null && _thread.IsAlive;
        }

    }
}
