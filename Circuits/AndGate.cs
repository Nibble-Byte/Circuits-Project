using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace Circuits
{
    /// <summary>
    /// This class implements an AND gate with two inputs
    /// and one output.
    /// </summary>
    class AndGate : Gate
    {
        public AndGate(int x, int y) : base()
        {
            pins.Add(new Pin(this, true, 20));
            pins.Add(new Pin(this, true, 20));
            pins.Add(new Pin(this, false, 20));
            MoveTo(x, y); // move the gate and position the pins
        }        

        public override void Draw(Graphics paper)
        {
            Brush brush;
            if (selected)
            {
                brush = selectedBrush;
            }
            else
            {
                brush = normalBrush;
            }
            foreach (Pin p in pins)
            {
                p.Draw(paper);
            }
            
            paper.FillEllipse(brush, left, top, WIDTH, HEIGHT);
            paper.FillRectangle(brush, left, top, WIDTH / 2, HEIGHT);
        }

        public override void MoveTo(int x, int y)
        {
            Debug.WriteLine("pins = " + pins.Count);
            left = x;
            top = y;
            // must move the pins too
            pins[0].X = x - GAP;
            pins[0].Y = y + GAP;
            pins[1].X = x - GAP;
            pins[1].Y = y + HEIGHT - GAP;
            pins[2].X = x + WIDTH + GAP;
            pins[2].Y = y + HEIGHT / 2;
        }
    }
}
