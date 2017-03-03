using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Example
{
    public class PendingState : State
    {
        public override void Start(Work work)
        {
            work.State = new RunningState();
        }

        public override void Cancel(Work work)
        {
            throw new NotImplementedException();
        }
    }
}
