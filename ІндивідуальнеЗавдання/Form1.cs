using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ІндивідуальнеЗавдання
{
    public partial class Miner : Form
    {
        public Miner()
        {
            InitializeComponent();
        }
     
        private AddMina addMina = new AddMina();
        private PictureBox pictureBox1 = new PictureBox();

        private Button[,] minas = new Button[3, 3];
        

        private void Miner_Load(object sender, EventArgs e)
        {            
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    minas[i, j] = new Button();
                    minas[i, j].Location = new Point(80 + (60 * i), 150 + (60 * j));
                    minas[i, j].Size = new Size(60, 60);
                    minas[i, j].FlatStyle = FlatStyle.Flat;
                    minas[i, j].MouseClick += mine_MouseClickElement;
                    minas[i, j].Name = "mine";
                    Controls.Add(minas[i, j]);

                }
            }

            CreatePictureBox();            
        }

        private Random random = new Random();

        private void mine_MouseClickElement(object sender, MouseEventArgs e)
        {                        
            int x = ((sender as Button).Location.X - 80) / 60;
            int y = ((sender as Button).Location.Y - 150) / 60;

            int k = random.Next(0, 5);

            if (k == 0)
            {
                minas[x, y].Text = "Міна";
                Application.OpenForms[0].BackColor = Color.Red;
            }

            if (k == 1)
            {
                minas[x, y].Text = "1";
                Application.OpenForms[0].BackColor = Color.Lime;
            }

            if (k == 2)
            {
                minas[x, y].Text = "2";
                Application.OpenForms[0].BackColor = Color.Blue;
            }

            if (k == 3)
            {
                minas[x, y].Text = "3";
                Application.OpenForms[0].BackColor = Color.Yellow;
            }

            if (k == 4)
            {
                minas[x, y].Text = "4";
                Application.OpenForms[0].BackColor = Color.Gray;
            }

        }


        private void CreatePictureBox()
        {
            pictureBox1.BackColor = Color.FromArgb(51, 51, 76);
            pictureBox1.Location = new Point(56, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 264);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            Controls.Add(pictureBox1);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void collapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {               
                    minas[i, j].Text = "";
                    
                }
            }
            Application.OpenForms[0].BackColor = Color.FromArgb(34, 36, 49);
        }
    }
}
