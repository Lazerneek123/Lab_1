using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();             
        }
        private bool n = true;

        private void DestroyLabels_Click(object sender, EventArgs e)
        {
            /*if (n == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Controls.RemoveAt(0);
                }
                n = false;
            }*/

            /*foreach(Control control in this.Controls)
            {
                if (control is Label)
                {
                    
                    control.Hide();
                    
                }

            } */


            Controls.OfType<Label>().ToList().ForEach((label) => { label.Dispose(); });
        

        }
    }
}
