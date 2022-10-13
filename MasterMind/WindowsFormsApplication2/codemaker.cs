using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class codemaker : Form
    {
        public static string[] cmarr=new string[4];
        public codemaker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            GetColour(button1);
        }

        private void codemaker_Load(object sender, EventArgs e)
        {
         
        }
        public void GetColour(Button b)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Enabled = false;
                b.BackColor = Color.Red;
                radioButton1.Checked = false;
            }
            if (radioButton2.Checked)
            {
                radioButton2.Enabled = false;
                b.BackColor = Color.Green;
                radioButton2.Checked = false;
            }
            if (radioButton3.Checked)
            {
                radioButton3.Enabled = false;
                b.BackColor = Color.Yellow;
                radioButton3.Checked = false;
            }
            if (radioButton4.Checked)
            {
                radioButton4.Enabled = false;
                b.BackColor = Color.Blue;
                radioButton4.Checked = false;
            }
            if (radioButton5.Checked)
            {
                radioButton5.Enabled = false;
                b.BackColor = Color.Purple;
                radioButton5.Checked = false;
            }
            if (radioButton6.Checked)
            {
                radioButton6.Enabled = false;
                b.BackColor = Color.Maroon;
                radioButton6.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            GetColour(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            GetColour(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            GetColour(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            cmarr[0] = StoreColour(button1);
            cmarr[1] = StoreColour(button2);
            cmarr[2] = StoreColour(button3);
            cmarr[3] = StoreColour(button4);
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Close();
        }
        public string StoreColour(Button but)
        {
            string scolour = "";
            if (but.BackColor == Color.Red)
            {
                scolour = "red";
            }
            else if (but.BackColor == Color.Green)
            {
                scolour = "green";
            }
            else if (but.BackColor == Color.Yellow)
            {
                scolour = "yellow";
            }
            else if (but.BackColor == Color.Blue)
            {
                scolour = "blue";
            }
            else if (but.BackColor == Color.Purple)
            {
                scolour = "purple";
            }
            else if (but.BackColor == Color.Maroon)
            {
                scolour = "maroon";
            }
            else
            {
                scolour = "none1";
            }
            return scolour;
        }

    }
}
