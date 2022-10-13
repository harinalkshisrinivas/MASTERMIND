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
    public partial class Form1 : Form
    {
        string[] firstguess = new string[4];
        string[] secondguess = new string[4];
        string[] thirdguess = new string[4];
        string[] fourthguess = new string[4];
        string[] fifthguess = new string[4];
        string[] sixthguess = new string[4];
        string[] seventhguess = new string[4];
        string[] eigthguess = new string[4];
        string[] ninethguess = new string[4];
        string[] tenthguess = new string[4];
        int guessround;
        int checkcount;
        string colour;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colour = "";
            checkcount = 0;
            guessround = 1;
            #region FalseButtons
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
            button26.Enabled = false;
            button27.Enabled = false;
            button28.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button36.Enabled = false;
            button37.Enabled = false;
            button38.Enabled = false;
            button39.Enabled = false;
            button40.Enabled = false;
            button41.Enabled = false;
            button42.Enabled = false;
            button43.Enabled = false;
            button44.Enabled = false;
            button45.Enabled = false;
            button46.Enabled = false;
            button47.Enabled = false;
            button48.Enabled = false;
            button49.Enabled = false;
            button50.Enabled = false;
            button51.Enabled = false;
            button52.Enabled = false;
            button53.Enabled = false;
            button54.Enabled = false;
            button55.Enabled = false;
            button56.Enabled = false;
            button57.Enabled = false;
            button58.Enabled = false;
            button59.Enabled = false;
            button50.Enabled = false;
            button61.Enabled = false;
            button62.Enabled = false;
            button63.Enabled = false;
            button64.Enabled = false;
            button65.Enabled = false;
            button66.Enabled = false;
            button67.Enabled = false;
            button68.Enabled = false;
            button69.Enabled = false;
            button70.Enabled = false;
            button71.Enabled = false;
            button72.Enabled = false;
            button73.Enabled = false;
            button74.Enabled = false;
            button75.Enabled = false;
            button76.Enabled = false;
            button77.Enabled = false;
            button78.Enabled = false;
            button79.Enabled = false;
            button80.Enabled = false;
            button60.Enabled = false;
            #endregion
            EnableButtons(guessround);
        }
        private void button41_Click(object sender, EventArgs e)
        {

            checkcount++;
            button41.Enabled = false;
            GetColour(button41);
            IsNextGuess(checkcount);
        }
     

        private void button42_Click(object sender, EventArgs e)
        {
            checkcount++;
            button42.Enabled = false;
            GetColour(button42);
            IsNextGuess(checkcount);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            checkcount++;
            button43.Enabled = false;
            GetColour(button43);
            IsNextGuess(checkcount);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            checkcount++;
            button44.Enabled = false;
            GetColour(button44);
            IsNextGuess(checkcount);
        }
        private void button45_Click(object sender, EventArgs e)
        {
            checkcount++;
            button45.Enabled = false;
            GetColour(button45);
            IsNextGuess(checkcount);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            checkcount++;
            button46.Enabled = false;
            GetColour(button46);
            IsNextGuess(checkcount);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            checkcount++;
            button47.Enabled = false;
            GetColour(button47);
            IsNextGuess(checkcount);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            checkcount++;
            button48.Enabled = false;
            GetColour(button48);
            IsNextGuess(checkcount);
        }
      

        private void button56_Click(object sender, EventArgs e)
        {
            checkcount++;
            button56.Enabled = false;
            GetColour(button56);
            IsNextGuess(checkcount);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
       

        private void button49_Click(object sender, EventArgs e)
        {
            checkcount++;
            button49.Enabled = false;
            GetColour(button49);
            IsNextGuess(checkcount);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            checkcount++;
            button50.Enabled = false;
            GetColour(button50);
            IsNextGuess(checkcount);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            checkcount++;
            button51.Enabled = false;
            GetColour(button51);
            IsNextGuess(checkcount);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            checkcount++;
            button52.Enabled = false;
            GetColour(button52);
            IsNextGuess(checkcount);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            checkcount++;
            button53.Enabled = false;
            GetColour(button53);
            IsNextGuess(checkcount);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            checkcount++;
            button54.Enabled = false;
            GetColour(button54);
            IsNextGuess(checkcount);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            checkcount++;
            button55.Enabled = false;
            GetColour(button55);
            IsNextGuess(checkcount);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            checkcount++;
            button57.Enabled = false;
            GetColour(button57);
            IsNextGuess(checkcount);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            checkcount++;
            button58.Enabled = false;
            GetColour(button58);
            IsNextGuess(checkcount);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            checkcount++;
            button59.Enabled = false;
            GetColour(button59);
            IsNextGuess(checkcount);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            checkcount++;
            button60.Enabled = false;
            GetColour(button60);
            IsNextGuess(checkcount);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            checkcount++;
            button61.Enabled = false;
            GetColour(button61);
            IsNextGuess(checkcount);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            checkcount++;
            button62.Enabled = false;
            GetColour(button62);
            IsNextGuess(checkcount);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            checkcount++;
            button63.Enabled = false;
            GetColour(button63);
            IsNextGuess(checkcount);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            checkcount++;
            button64.Enabled = false;
            GetColour(button64);
            IsNextGuess(checkcount);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            checkcount++;
            button65.Enabled = false;
            GetColour(button65);
            IsNextGuess(checkcount);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            checkcount++;
            button66.Enabled = false;
            GetColour(button66);
            IsNextGuess(checkcount);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            checkcount++;
            button67.Enabled = false;
            GetColour(button67);
            IsNextGuess(checkcount);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            checkcount++;
            button68.Enabled = false;
            GetColour(button68);
            IsNextGuess(checkcount);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            checkcount++;
            button69.Enabled = false;
            GetColour(button69);
            IsNextGuess(checkcount);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            checkcount++;
            button70.Enabled = false;
            GetColour(button70);
            IsNextGuess(checkcount);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            checkcount++;
            button71.Enabled = false;
            GetColour(button71);
            IsNextGuess(checkcount);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            checkcount++;
            button72.Enabled = false;
            GetColour(button72);
            IsNextGuess(checkcount);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            checkcount++;
            button73.Enabled = false;
            GetColour(button73);
            IsNextGuess(checkcount);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            checkcount++;
            button74.Enabled = false;
            GetColour(button74);
            IsNextGuess(checkcount);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            checkcount++;
            button75.Enabled = false;
            GetColour(button75);
            IsNextGuess(checkcount);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            checkcount++;
            button76.Enabled = false;
            GetColour(button76);
            IsNextGuess(checkcount);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            checkcount++;
            button77.Enabled = false;
            GetColour(button77);
            IsNextGuess(checkcount);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            checkcount++;
            button78.Enabled = false;
            GetColour(button78);
            IsNextGuess(checkcount);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            checkcount++;
            button79.Enabled = false;
            GetColour(button79);
            IsNextGuess(checkcount);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            checkcount++;
            button80.Enabled = false;
            GetColour(button80);
            IsNextGuess(checkcount);
        }
        public void EnableButtons(int guessround)
        {
            if (guessround == 1)
            {
                #region  1
                button41.Enabled = true;
                button42.Enabled = true;
                button43.Enabled = true;
                button44.Enabled = true;
                #endregion
            }
            if (guessround == 2)
            {
                #region  2
                button41.Enabled = false;
                button42.Enabled = false;
                button43.Enabled = false;
                button44.Enabled = false;
                button45.Enabled = true;
                button46.Enabled = true;
                button47.Enabled = true;
                button48.Enabled = true;
                #endregion
            }
            if (guessround == 3)
            {
                #region 3
                button45.Enabled = false;
                button46.Enabled = false;
                button47.Enabled = false;
                button48.Enabled = false;
                button49.Enabled = true;
                button50.Enabled = true;
                button51.Enabled = true;
                button52.Enabled = true;
                #endregion
            }
            if (guessround == 4)
            {
                #region 4
                button49.Enabled = false;
                button50.Enabled = false;
                button51.Enabled = false;
                button52.Enabled = false;
                button53.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                button56.Enabled = true;
                #endregion
            }
            if (guessround == 5)
            {
                #region 5
                button57.Enabled = true;
                button58.Enabled = true;
                button59.Enabled = true;
                button60.Enabled = true;
                button53.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                button56.Enabled = false;
                #endregion
            }
            if (guessround == 6)
            {
                #region 6
                button57.Enabled = false;
                button58.Enabled = false;
                button59.Enabled = false;
                button60.Enabled = false;
                button61.Enabled = true;
                button62.Enabled = true;
                button63.Enabled = true;
                button64.Enabled = true;
                #endregion
            }
            if (guessround == 7)
            {
                #region 7
                button61.Enabled = false;
                button62.Enabled = false;
                button63.Enabled = false;
                button64.Enabled = false;
                button65.Enabled = true;
                button66.Enabled = true;
                button67.Enabled = true;
                button68.Enabled = true;
                #endregion
            }
            if (guessround == 8)
            {
                #region 8
                button65.Enabled = false;
                button66.Enabled = false;
                button67.Enabled = false;
                button68.Enabled = false;
                button69.Enabled = true;
                button70.Enabled = true;
                button71.Enabled = true;
                button72.Enabled = true;
                #endregion
            }
            if (guessround == 9)
            {
                #region 9
                button69.Enabled = false;
                button70.Enabled = false;
                button71.Enabled = false;
                button72.Enabled = false;
                button73.Enabled = true;
                button74.Enabled = true;
                button75.Enabled = true;
                button76.Enabled = true;
                #endregion
            }
            if (guessround == 10)
            {
                #region 10
                button73.Enabled = false;
                button74.Enabled = false;
                button75.Enabled = false;
                button76.Enabled = false;
                button77.Enabled = true;
                button78.Enabled = true;
                button79.Enabled = true;
                button80.Enabled = true;
                #endregion
            }

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
        public bool IsContains(string a, string[] arr)
        {

            bool ans = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == a)
                {
                    ans = true;
                }
            }
            return ans;

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
                scolour = "none";
            }
            return scolour;
        }
        public void Hint(string[] arr, int checkcound)
        {
            string[] codemakerarr = codemaker.cmarr;
            int guesscount = 0;
            if (checkcound == 4)
            #region 1
            {
                for (int i = 0; i < codemakerarr.Length; i++)
                {

                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount++;
                            button1.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount++;
                            button2.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount++;
                            button3.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount++;
                            button4.BackColor = Color.Red;
                        }
                        if (guesscount % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                          
                        }

                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button1.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button2.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button3.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button4.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 8)
            #region 2
            {
                int guesscount2 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {

                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount2++;
                            button5.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount2++;
                            button6.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount2++;
                            button7.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount2++;
                            button8.BackColor = Color.Red;
                        }
                        if (guesscount2 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button5.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button6.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button7.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button8.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 12)
            #region 3
            {
                int guesscount3 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount3++;
                            button9.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount3++;
                            button10.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount3++;
                            button11.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount3++;
                            button12.BackColor = Color.Red;
                        }
                        if (guesscount3 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button9.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button10.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button11.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button12.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 16)
            #region 4
            {
                int guesscount4 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount4++;
                            button13.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount4++;
                            button14.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount4++;
                            button15.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount4++;
                            button16.BackColor = Color.Red;
                        }
                        if (guesscount4 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button13.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button14.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button15.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button16.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 20)
            #region 5
            {
                int guesscount5 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount5++;
                            button17.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount5++;
                            button18.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount5++;
                            button19.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount5++;
                            button20.BackColor = Color.Red;
                        }
                        if (guesscount5 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button17.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button18.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button19.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button20.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 24)
            #region 6
            {
                int guesscount6 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount6++;
                            button21.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount6++;
                            button22.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount6++;
                            button23.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount6++;
                            button24.BackColor = Color.Red;
                        }
                        if (guesscount6 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button21.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button22.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button23.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button24.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 28)
            #region 7
            {
                int guesscount7 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount7++;
                            button25.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount7++;
                            button26.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount7++;
                            button27.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount7++;
                            button28.BackColor = Color.Red;
                        }
                        if (guesscount7 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button25.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button26.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button27.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button28.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 32)
            #region 8
            {
                int guesscount8 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount8++;
                            button29.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount8++;
                            button30.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount8++;
                            button31.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount8++;
                            button32.BackColor = Color.Red;
                        }
                        if (guesscount8 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button29.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button30.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button31.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button32.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 36)
            #region 9
            {
                int guesscount9 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount9++;
                            button33.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount9++;
                            button34.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount9++;
                            button35.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount9++;
                            button36.BackColor = Color.Red;
                        }
                        if (guesscount9 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button33.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button34.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button35.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button36.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion
            else if (checkcound == 40)
            #region 10
            {
                int guesscount10 = 0;
                for (int i = 0; i < codemakerarr.Length; i++)
                {
                    if (arr[i] == codemakerarr[i])
                    {

                        if (i == 0)
                        {
                            guesscount10++;
                            button37.BackColor = Color.Red;
                        }
                        else if (i == 1)
                        {
                            guesscount10++;
                            button38.BackColor = Color.Red;
                        }
                        else if (i == 2)
                        {
                            guesscount10++;
                            button39.BackColor = Color.Red;
                        }
                        else if (i == 3)
                        {
                            guesscount10++;
                            button40.BackColor = Color.Red;
                        }
                        if (guesscount10 % 4 == 0)
                        {
                            MessageBox.Show("Yeah!!! Guessed");
                            IsWon();
                        }
                    }
                    else if (IsContains(arr[i], codemakerarr))
                    {

                        if (i == 0)
                        {
                            button37.BackColor = Color.Black;
                        }
                        if (i == 1)
                        {
                            button38.BackColor = Color.Black;
                        }
                        if (i == 2)
                        {
                            button39.BackColor = Color.Black;
                        }
                        if (i == 3)
                        {
                            button40.BackColor = Color.Black;
                        }
                    }
                }
            }
            #endregion


        }
        public void IsNextGuess(int cc)
        {
            if (cc % 4 == 0)
            {
                if (cc == 4)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    firstguess[0] = StoreColour(button41);
                    firstguess[1] = StoreColour(button42);
                    firstguess[2] = StoreColour(button43);
                    firstguess[3] = StoreColour(button44);
                    Hint(firstguess, cc);

                }
                else if (cc == 8)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    secondguess[0] = StoreColour(button45);
                    secondguess[1] = StoreColour(button46);
                    secondguess[2] = StoreColour(button47);
                    secondguess[3] = StoreColour(button48);
                    Hint(secondguess, cc);
                }
                else if (cc == 12)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    thirdguess[0] = StoreColour(button49);
                    thirdguess[1] = StoreColour(button50);
                    thirdguess[2] = StoreColour(button51);
                    thirdguess[3] = StoreColour(button52);
                    Hint(thirdguess, cc);
                }
                else if (cc == 16)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    fourthguess[0] = StoreColour(button53);
                    fourthguess[1] = StoreColour(button54);
                    fourthguess[2] = StoreColour(button55);
                    fourthguess[3] = StoreColour(button56);
                    Hint(fourthguess, cc);
                }
                else if (cc == 20)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    fifthguess[0] = StoreColour(button57);
                    fifthguess[1] = StoreColour(button58);
                    fifthguess[2] = StoreColour(button59);
                    fifthguess[3] = StoreColour(button60);
                    Hint(fifthguess, cc);
                }
                else if (cc == 24)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    sixthguess[0] = StoreColour(button61);
                    sixthguess[1] = StoreColour(button62);
                    sixthguess[2] = StoreColour(button63);
                    sixthguess[3] = StoreColour(button64);
                    Hint(sixthguess, cc);
                }
                else if (cc == 28)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    seventhguess[0] = StoreColour(button65);
                    seventhguess[1] = StoreColour(button66);
                    seventhguess[2] = StoreColour(button67);
                    seventhguess[3] = StoreColour(button68);
                    Hint(seventhguess, cc);
                }
                else if (cc == 32)
                {
                    eigthguess[0] = StoreColour(button69);
                    eigthguess[1] = StoreColour(button70);
                    eigthguess[2] = StoreColour(button71);
                    eigthguess[3] = StoreColour(button72);
                    Hint(eigthguess, cc);
                }
                else if (cc == 36)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    ninethguess[0] = StoreColour(button73);
                    ninethguess[1] = StoreColour(button74);
                    ninethguess[2] = StoreColour(button75);
                    ninethguess[3] = StoreColour(button76);
                    Hint(ninethguess, cc);
                }
                else if (cc == 40)
                {
                    guessround++;
                    EnableButtons(guessround);
                    EnableRadioButton();
                    ninethguess[0] = StoreColour(button77);
                    ninethguess[1] = StoreColour(button78);
                    ninethguess[2] = StoreColour(button79);
                    ninethguess[3] = StoreColour(button80);
                    Hint(tenthguess, cc);

                }
            }
        }
        public void EnableRadioButton()
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            radioButton4.Enabled = true;
            radioButton5.Enabled = true;
            radioButton6.Enabled = true;
        }
        public void IsWon()
        {
            codemaker cmform = new codemaker();
            this.Hide();
            cmform.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {

        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void button36_Click(object sender, EventArgs e)
        {

        }

        private void button37_Click(object sender, EventArgs e)
        {

        }

        private void button38_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button40_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
