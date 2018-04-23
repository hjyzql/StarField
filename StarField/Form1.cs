using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush starBrush;

            Random randGen = new Random();

            int x, y, size, r, g, b;

            for(int i = 0; i < 1000; i++)
            {
                x = randGen.Next(1, this.Width);
                y = randGen.Next(1, this.Height);
                size = randGen.Next(2, 10);

                r = randGen.Next(0, 256);
                g = randGen.Next(0, 256);
                b = randGen.Next(0, 256);
                starBrush = new SolidBrush(Color.FromArgb(r, g, b));

                formGraphics.FillEllipse(starBrush, x, y, size, size);
            }
        }
    }
}
