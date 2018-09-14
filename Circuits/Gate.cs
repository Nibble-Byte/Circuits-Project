using System;
using System.Collections.Generic;
using System.Text;

namespace Circuits
{
    abstract class Gate
    {
        protected int left;
        protected int top;
        protected bool selected = false;

        public Gate()
        {

        }

        public abstract bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }
    }
}
