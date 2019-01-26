using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_GlenSadler
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Added Temporarily so that we return to the 
            // Main Menu at this stage of develpment 
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void numericWidthEvent(object sender, EventArgs e)
        {
            //numericWidth.Minimum = 24;
            //numericWidth.Maximum = 96;
            if (int.TryParse(numericWidth.Text, out int WidthInput) == true)
            {
                if (WidthInput < Desk.MINWIDTH || WidthInput > Desk.MAXWIDTH)
                {
                    MessageBox.Show($"The width must be between {Desk.MINWIDTH} and {Desk.MAXWIDTH} inches inclusive");
                    numericWidth.Text = String.Empty;
                    numericWidth.BackColor = Color.Red;
                    numericWidth.Focus();
                }
                else
                {
                    numericWidth.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(numericWidth.Text, out WidthInput) == false && numericWidth.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                numericWidth.Text = String.Empty;
                numericWidth.BackColor = Color.Red;
                numericWidth.Focus();
            }
            else
            {
                numericWidth.BackColor = System.Drawing.SystemColors.Window;
            }

        }

        private void numericWidth_Keypress(object sender, KeyPressEventArgs e)
        {
            //numericWidth.Minimum = 24;
            //numericWidth.Maximum = 96;
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                numericWidth.BackColor = Color.Red;
                numericWidth.Focus();
            }
            else
            {
                numericWidth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void numericDepthEvent(object sender, EventArgs e)
        {
            //numericWidth.Minimum = 12;
            //numericWidth.Maximum = 48;
            if (int.TryParse(numericDepth.Text, out int DepthInput) == true) {
                if (DepthInput < Desk.MINDEPTH || DepthInput > Desk.MAXDEPTH)
                {
                    MessageBox.Show($"The width must be between {Desk.MINDEPTH} and {Desk.MAXDEPTH} inches inclusive");
                    numericDepth.Text = String.Empty;
                    numericDepth.BackColor = Color.Red;
                    numericDepth.Focus();
                }
                else
                {
                    numericDepth.BackColor = System.Drawing.SystemColors.Window;
                }
            }
            else if (int.TryParse(numericDepth.Text, out DepthInput) == false && numericDepth.Text.Length != 0)
            {
                MessageBox.Show("Please enter a number");
                numericDepth.Text = String.Empty;
                numericDepth.BackColor = Color.Red;
                numericDepth.Focus();
            }
            else
            {
                numericDepth.BackColor = System.Drawing.SystemColors.Window;
            }
        }

        private void numericDepth_Keypress(object sender, KeyPressEventArgs e)
        {
            //numericDepth.Minimum = 12;
            //numericDepth.Maximum = 48;
            if (Char.IsControl(e.KeyChar) == false && Char.IsDigit(e.KeyChar) == false)
            {
                MessageBox.Show("Please enter a number");
                e.Handled = true;
                numericDepth.BackColor = Color.Red;
                numericDepth.Focus();
            }
            else
            {
                numericDepth.BackColor = System.Drawing.SystemColors.Window;
            }
        }
    }
}
