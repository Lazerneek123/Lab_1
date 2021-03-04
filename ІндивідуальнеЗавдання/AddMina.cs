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
    class AddMina : Button
    {
        Form form1 = new Form();        
        private Random random = new Random();

        public void CreateMina(Form form, int x, int y, int w, int h)
        {
            Button mina = new Button();

            mina.Location = new Point(x, y);
            mina.Size = new Size(w, h);
            mina.FlatStyle = FlatStyle.Flat;
            mina.Click += mine_MouseClickElement;
            mina.Name = "mine";
            form.Controls.Add(mina);
            form1 = form;           
        }

        private void mine_MouseClickElement(object sender, EventArgs e)
        {
            /*foreach (Control control in form1.Controls)
            {
                if (form1.Controls[2] is Button)
                {
                    control.Text = "Міна";

                }

            }*/

            int k2 = 0;

            for(int i = 7; i <= 15; i++)
            {
                int k = random.Next(0, 2);
                
                if (k == 0)
                {
                    form1.Controls[i].Text = "Пусто";
                }
                else
                {
                    form1.Controls[i].Text = "Міна";
                    k2++;
                }

            }

            
            Application.OpenForms[0].Controls[0].Text = "      Statistic \n \nПоле: 9х9 \nМін: " + k2 + "\nВільних клітинок: " + (9 - k2) + "\nВи вибрали клітинку: " + ((sender as Button).TabIndex - 16);
            
            if (form1.Controls[7].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[8].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[10].Text == "Міна")
                {
                    k++;
                }

                form1.Controls[7].Text = "" + k;
            }


            if (form1.Controls[15].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[14].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[12].Text == "Міна")
                {
                    k++;
                }

                form1.Controls[15].Text = "" + k;
            }

            if (form1.Controls[8].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[7].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[9].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[11].Text == "Міна")
                {
                    k++;
                }

                form1.Controls[8].Text = "" + k;
            }

            if (form1.Controls[9].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[8].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[12].Text == "Міна")
                {
                    k++;
                }                

                form1.Controls[9].Text = "" + k;
            }

            if (form1.Controls[10].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[7].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[11].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[13].Text == "Міна")
                {
                    k++;
                }

                form1.Controls[10].Text = "" + k;
            }

            if (form1.Controls[11].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[10].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[12].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[8].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[14].Text == "Міна")
                {
                    k++;
                }

                form1.Controls[11].Text = "" + k;
            }

            if (form1.Controls[12].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[9].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[11].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[15].Text == "Міна")
                {
                    k++;
                }
                

                form1.Controls[12].Text = "" + k;
            }

            if (form1.Controls[13].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[10].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[14].Text == "Міна")
                {
                    k++;
                }                

                form1.Controls[13].Text = "" + k;
            }

            if (form1.Controls[14].Text != "Міна")
            {
                int k = 0;

                if (form1.Controls[13].Text == "Міна")
                {
                    k++;
                }

                if (form1.Controls[11].Text == "Міна")
                {
                    k++;
                }
                if (form1.Controls[15].Text == "Міна")
                {
                    k++;
                }

                form1.Controls[14].Text = "" + k;
            }
            
        }

    }
}
