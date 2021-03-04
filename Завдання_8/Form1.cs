using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Завдання_8
{
    public partial class billingInfo : Form
    {
        private int amountAll = 0;

        private int amountCleaning = 45;
        private int amountCavityFilling = 65;
        private int amountX_Ray = 40;
        private int amountFluoride = 70;
        private int amountRootCanal = 20;
        private int amountBraces = 100;

        public billingInfo()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void collapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (fillInTheBlank1.Text == "Blank is full" && fillInTheBlank2.Text == "Blank is full" && fillInTheBlank3.Text == "Blank is full" && chooseCheckbox.Text == "Checkbox selected")
            {
                informationPanel.Text = "Name: " + textBox1.Text + "\nAddress: " + textBox2.Text + "\nPlan: " + textBox3.Text + "\n" + "\nCleaning: " + amountCleaning + "$" + "\nCavity Filling: " + amountCavityFilling + "$" + "\nX-Ray: " + amountX_Ray + "$" + "\nFluoride: " + amountFluoride + "$" + "\nRoot Canal: " + amountRootCanal + "$" + "\nBraces: " + amountBraces + "$" + "\n" + "\nTotal amount: " + amountAll + "$";
                
            }
            else
            {
                MessageBox.Show("Fill in all blanks!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                fillInTheBlank1.Text = "Fill in the blank!";
                fillInTheBlank1.ForeColor = Color.Red;
                fillInTheBlank1.Location = new Point(116, 93);
            }
            else
            {
                fillInTheBlank1.Text = "Blank is full";
                fillInTheBlank1.ForeColor = Color.Lime;
                fillInTheBlank1.Location = new Point(126, 93);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                fillInTheBlank2.Text = "Fill in the blank!";
                fillInTheBlank2.ForeColor = Color.Red;
                fillInTheBlank2.Location = new Point(116, 169);
            }
            else
            {
                fillInTheBlank2.Text = "Blank is full";
                fillInTheBlank2.ForeColor = Color.Lime;
                fillInTheBlank2.Location = new Point(126, 169);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                fillInTheBlank3.Text = "Fill in the blank!";
                fillInTheBlank3.ForeColor = Color.Red;
                fillInTheBlank3.Location = new Point(116, 240);
            }
            else
            {
                fillInTheBlank3.Text = "Blank is full";
                fillInTheBlank3.ForeColor = Color.Lime;
                fillInTheBlank3.Location = new Point(126, 240);
            }
        }

        private void cleaning_CheckedChanged(object sender, EventArgs e)
        {
            if (cleaning.Checked == true || cavityFilling.Checked == true || x_Ray.Checked == true || fluoride.Checked == true || rootCanal.Checked == true || braces.Checked == true)
            {
                chooseCheckbox.Text = "Checkbox selected";
                chooseCheckbox.ForeColor = Color.Lime;                
            }
            else
            {
                chooseCheckbox.Text = "Choose checkbox!";
                chooseCheckbox.ForeColor = Color.Red;                
            }

            if (cleaning.Checked == true)
            {
                amountAll += amountCleaning;
            }
            else
            {
                amountAll -= amountCleaning;
            }

        }

        private void cavityFilling_CheckedChanged(object sender, EventArgs e)
        {
            if (cleaning.Checked == true || cavityFilling.Checked == true || x_Ray.Checked == true || fluoride.Checked == true || rootCanal.Checked == true || braces.Checked == true)
            {
                chooseCheckbox.Text = "Checkbox selected";
                chooseCheckbox.ForeColor = Color.Lime;
            }
            else
            {
                chooseCheckbox.Text = "Choose checkbox!";
                chooseCheckbox.ForeColor = Color.Red;
            }

            if (cavityFilling.Checked == true)
            {
                amountAll += amountCavityFilling;
            }
            else
            {
                amountAll -= amountCavityFilling;
            }
        }

        private void x_Ray_CheckedChanged(object sender, EventArgs e)
        {
            if (cleaning.Checked == true || cavityFilling.Checked == true || x_Ray.Checked == true || fluoride.Checked == true || rootCanal.Checked == true || braces.Checked == true)
            {
                chooseCheckbox.Text = "Checkbox selected";
                chooseCheckbox.ForeColor = Color.Lime;
            }
            else
            {
                chooseCheckbox.Text = "Choose checkbox!";
                chooseCheckbox.ForeColor = Color.Red;
            }

            if (x_Ray.Checked == true)
            {
                amountAll += amountX_Ray;
            }
            else
            {
                amountAll -= amountX_Ray;
            }
        }

        private void fluoride_CheckedChanged(object sender, EventArgs e)
        {
            if (cleaning.Checked == true || cavityFilling.Checked == true || x_Ray.Checked == true || fluoride.Checked == true || rootCanal.Checked == true || braces.Checked == true)
            {
                chooseCheckbox.Text = "Checkbox selected";
                chooseCheckbox.ForeColor = Color.Lime;
            }
            else
            {
                chooseCheckbox.Text = "Choose checkbox!";
                chooseCheckbox.ForeColor = Color.Red;
            }

            if (fluoride.Checked == true)
            {
                amountAll += amountFluoride;
            }
            else
            {
                amountAll -= amountFluoride;
            }

        }

        private void rootCanal_CheckedChanged(object sender, EventArgs e)
        {
            if (cleaning.Checked == true || cavityFilling.Checked == true || x_Ray.Checked == true || fluoride.Checked == true || rootCanal.Checked == true || braces.Checked == true)
            {
                chooseCheckbox.Text = "Checkbox selected";
                chooseCheckbox.ForeColor = Color.Lime;
            }
            else
            {
                chooseCheckbox.Text = "Choose checkbox!";
                chooseCheckbox.ForeColor = Color.Red;
            }

            if (rootCanal.Checked == true)
            {
                amountAll += amountRootCanal;
            }
            else
            {
                amountAll -= amountRootCanal;
            }
        }

        private void braces_CheckedChanged(object sender, EventArgs e)
        {
            if (cleaning.Checked == true || cavityFilling.Checked == true || x_Ray.Checked == true || fluoride.Checked == true || rootCanal.Checked == true || braces.Checked == true)
            {
                chooseCheckbox.Text = "Checkbox selected";
                chooseCheckbox.ForeColor = Color.Lime;
            }
            else
            {
                chooseCheckbox.Text = "Choose checkbox!";
                chooseCheckbox.ForeColor = Color.Red;
            }

            if (braces.Checked == true)
            {
                amountAll += amountBraces;
            }
            else
            {
                amountAll -= amountBraces;
            }
        }
    }
}
