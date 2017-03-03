using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Cat
    {
        public delegate void NotifyEventHandle();

        public event NotifyEventHandle NotifyEvent;

        public void Notify()
        {
            if (NotifyEvent != null)
            {
                Console.WriteLine("Cat is crying");
                NotifyEvent();
            }
        }
    }
}
