using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Example
{
    public class RunningState : State
    {
        public override void Start(Work work)
        {
            work.State = new FinishedState();
        }

        public override void Cancel(Work work)
        {
            work.State = new CancelledState();
        }
    }
}
