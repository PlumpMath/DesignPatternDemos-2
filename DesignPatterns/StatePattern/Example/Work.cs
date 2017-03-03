using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Example
{
    public class Work
    {
        private State _state;
        public Work()
        {
           
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Start()
        {
            _state.Start(this);
        }

        public void Cancel()
        {
            _state.Cancel(this);
        }
    }
}
