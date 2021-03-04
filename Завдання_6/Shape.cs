using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_6
{
    public class Shape : PictureBox
    {
        private PictureBox pictureBox1 = new PictureBox();

        public void ClolorPictureBox(Form form)
        {
            pictureBox1.Name = "rectangle";
            pictureBox1.MouseMove += mouse_Move;
            pictureBox1.MouseLeave += mouse_Leave;
            pictureBox1.Location = new Point(300, 160);
            pictureBox1.Size = new Size(215, 112);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.BackColor = Color.Green;
            form.Controls.Add(pictureBox1);
        }

        private void mouse_Leave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }
    }
}
