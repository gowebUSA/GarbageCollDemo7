using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollDemo7
{
    class Calculator : IDisposable
    {
        private bool disposed = false;
        public int Divide(int first, int second)
        {
            return first / second;
        }
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }
        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }
        public void Dispose()               //added on page 332.
        {
            lock (this)
            {
                if (!disposed)
                {
                    Console.WriteLine("Calculator being disposed");
                }
                this.disposed = true;
                GC.SuppressFinalize(this);
            }
        }
        /*
        public void Dispose()                       //commented on page 332.
        {
            if (!this.disposed)                     //added on page 331.
            {
                Console.WriteLine("Calculator being disposed");
            }
            this.disposed = true;
            GC.SuppressFinalize(this);
        }
        */
    }
}
