using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Example2
{
    public interface Iterator
    {
        void First();
        void Next();
        bool IsDone();
        object CurrentItem();
    }
}
