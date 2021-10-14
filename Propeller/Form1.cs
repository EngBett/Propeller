using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propeller
{
    public partial class Form1 : Form
    {
        List<Propeller> props;
        Brush circleBrush;

        double changeAmount = .05;

        public Form1()
        {
            InitializeComponent();
            props = new List<Propeller>();
            circleBrush = new SolidBrush(Color.Green);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                props.Add(new Propeller(new Point(200, 200), i * 2 * Math.PI / 10));
            }

            props[0].Revolution += Form1_Revolution;
            
            Graphics grp = this.CreateGraphics();
            foreach (Propeller prop in props)
            {
                prop.Draw(grp);
            }
        }

        private void Form1_Revolution(object sender, EventArgs e)
        {
            int numberOfRevolutions = int.Parse(tsslRevolutions.Text);
            numberOfRevolutions++;
            tsslRevolutions.Text = numberOfRevolutions.ToString();
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics grp = this.CreateGraphics();
            foreach (Propeller prop in props)
            {
                prop.Draw(grp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Propeller prop in props)
            {
                prop.Move(changeAmount);
            }
            this.Refresh();
        }

        private void tbTimerInterval_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = -tbTimerInterval.Value;
        }

        private void tbAmountMoved_Scroll(object sender, EventArgs e)
        {
            changeAmount = tbAmountMoved.Value / 100.0;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Propeller prop in props)
            {
                prop.Draw(e.Graphics);
            }
            e.Graphics.FillEllipse(circleBrush, new Rectangle(props[0].Middle.X - 10, props[0].Middle.Y - 10, 20, 20));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
