using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propeller
{
    class Propeller
    {
        public event EventHandler<EventArgs> Revolution;

        public Point Middle { get; private set; }
        public double Length { get; private set; }
        public double Angle { get; private set; }
        public Pen Pen { get; private set; }
        public Pen BackgroundPen { get; private set; }

        public Propeller(Point middle, double angle)
        {
            Middle = middle;
            Length = 101;
            Angle = angle;
            Pen = new Pen(Color.Chocolate, 5);
            BackgroundPen = new Pen(SystemColors.Control, 5);
        }

        public void Draw(Graphics grp)
        {
            float height = (float)(Length * Math.Sin(Angle));
            float width = (float)(Length * Math.Cos(Angle));

            PointF endPoint = new PointF(Middle.X + width, Middle.Y + height);
            grp.DrawLine(Pen, Middle, endPoint);
        }

        public void Undraw(Graphics grp)
        {
            float height = (float)(Length * Math.Sin(Angle));
            float width = (float)(Length * Math.Cos(Angle));

            PointF endPoint = new PointF(Middle.X + width, Middle.Y + height);
            grp.DrawLine(BackgroundPen, Middle, endPoint);
        }

        public void Move(double amount)
        {
            Angle += amount;

            if (Angle >= 2 * Math.PI)
            {
                // Raise Revolution event
                object sender = this;
                EventArgs eventArgs = new EventArgs();

                // Reset the angle so it's smaller the 2 Pi
                Angle -= 2 * Math.PI;

                if (Revolution != null)
                {
                    Revolution(sender, eventArgs);
                }

            }
        }
    }
}
