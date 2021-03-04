using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мишка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random(); 

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            /*int x = (sender as Button).Location.X;
            int y = (sender as Button).Location.Y;

            int r_x = random.Next(0, 821 - 100 - 40);
            int r_y = random.Next(0, 441 - 80 - 40);

            if (x >= 0 && x <= 820 - 100 - 40)
            {
                button1.Location = new Point(r_x, r_y);
            }

            if (y >= 0 && y <= 440 - 80 - 40)
            {
                button1.Location = new Point(r_x, r_y);
            } */
            
            button1.Left += e.X;
            button1.Top -= e.Y;

            int r_x = random.Next(0, 821 - 100 - 40);
            int r_y = random.Next(0, 441 - 80 - 40);

            if (button1.Left < 0 || button1.Left > 440 - 80)
            {
                button1.Left = r_x;
            }

            if (button1.Top < 0 || button1.Top > 820 - 100)
            {
                button1.Top = r_y;
            }


        }        
    }
}
