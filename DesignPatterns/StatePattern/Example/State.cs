using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Example
{
    public abstract class State
    {
        public abstract void Start(Work work);
        public abstract void Cancel(Work work);
    }
}
