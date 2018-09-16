using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Circuits
{
    abstract class Gate
    {        
        protected int left;
        protected int top;
        protected bool selected = false;
        protected const int WIDTH = 40;
        protected const int HEIGHT = 40;
        protected const int GAP = 10;
        protected Brush selectedBrush = Brushes.Red;
        protected Brush normalBrush = Brushes.LightGray;
        protected List<Pin> pins = new List<Pin>();
        
        /// <summary>
        /// Indicates whether this gate is the current one selected.
        /// </summary>        
        public virtual bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

        /// <summary>
        /// True if the given (x,y) position is roughly
        /// on top of this gate.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public virtual bool IsMouseOn(int x, int y)
        {
            if (left <= x && x < left + WIDTH && top <= y && y < top + HEIGHT)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void Draw(Graphics paper)
        {

        }

        public virtual void MoveTo(int x, int y)
        {

        }

        public int Left
        {
            get { return left; }
        }

        public int Top
        {
            get { return top; }
        }

        public List<Pin> Pins
        {
            get { return pins; }
        }
    }
}
