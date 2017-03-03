using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Example
{
    public class CancelledState : State
    {
        public override void Start(Work work)
        {
            throw new NotImplementedException();
        }

        public override void Cancel(Work work)
        {
            throw new NotImplementedException();
        }
    }
}
