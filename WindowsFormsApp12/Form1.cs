using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            label3.Text = " ";
            string[] pismena = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string text = textBox1.Text;
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            text = text.ToLower();
            string[] slova = text.Split(' ');
            textBox1.Text = text;
            if (text.Contains('_'))
            {
                label2.Text = "Ještě jsi nezkusil tyto písmena:";
                for (int i = 0; i < 26; i++)
                {
                    if (text.Contains(pismena[i]))
                    {

                    }
                    else
                    {
                        Button tlacitko = new Button();
                        tlacitko.Height = 50;
                        tlacitko.Width = 50;
                        tlacitko.Text = pismena[i];
                        tlacitko.BackColor = Color.DarkOrange;
                        tlacitko.Font = new Font("Impact", 15);
                        tlacitko.ForeColor = Color.Black;
                        flowLayoutPanel1.Controls.Add(tlacitko);
                        label3.Text += pismena[i] + " ";
                    }
                }
            }
            else 
            {
                label2.Text = "Slova neobsahují žádná vynechaná písmena";
            }
        }
    }
}
