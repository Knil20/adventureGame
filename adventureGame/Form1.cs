using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adventureGame
{
    public partial class Form1 : Form
    {
        int page = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;

            }
            else if (page == 3)
            {
                page = 9;

            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 11;
            }
            else if (page == 6)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 99;

            }
            else if (page == 8)
            {
                page = 99;

            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;

            }
            else if (page == 12)
            {
                page = 13;

            }
            else if (page == 13)
            {
                page = 4;

            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 16)
            {
                page = 20;
            }
            else if (page == 17)
            {
                page = 20;

            }
            else if (page == 18)
            {
                page = 99;

            }
            else if (page == 19)
            {
                page = 24;
            }
            else if (page == 20)
            {
                page = 22;
            }
            else if (page == 21)
            {
                page = 99;

            }
            else if (page == 22)
            {
                page = 20;

            }
            else if (page == 23)
            {
                page = 25;

            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 99;

            }
            else if (page == 28)
            {
                page = 99;

            }
            else if (page == 99)
            {
                page = 1;
            }
            
        }

        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 12;

            }
            else if (page == 3)
            {
                page = 5;

            }
            else if (page == 4)
            {
                page = 14;
            }
            else if (page == 5)
            {
                page = 7;
            }
            else if (page == 6)
            {
                page = 28;
            }
            else if (page == 7)
            {
                page = 99;

            }
            else if (page == 8)
            {
                page = 99;

            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;

            }
            else if (page == 12)
            {
                page = 21;

            }
            else if (page == 13)
            {
                page = 4;

            }
            else if (page == 14)
            {
                page = 15;
            }
            else if (page == 15)
            {
                page = 18;
            }
            else if (page == 16)
            {
                page = 19;
            }
            else if (page == 17)
            {
                page = 20;

            }
            else if (page == 18)
            {
                page = 99;

            }
            else if (page == 19)
            {
                page = 27;
            }
            else if (page == 20)
            {
                page = 23;
            }
            else if (page == 21)
            {
                page = 99;

            }
            else if (page == 22)
            {
                page = 20;

            }
            else if (page == 23)
            {
                page = 19;

            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 26;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 99;

            }
            else if (page == 28)
            {
                page = 99;

            }
            else if (page == 99)
            {
                page = 1;
            }
        }
    }
}
