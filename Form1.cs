using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Form1 : Form
    {
        //set up random number
        Random randomNum = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void eightBallButton_Click(object sender, EventArgs e)
        {
            //set up variable to store number
            int number;
            //pick random number
            number = randomNum.Next(1, 7);
            //give response for each number
            switch(number)
            {
                case 1:
                    outputLabel.Text = "No";
                    break;
                case 2:
                    outputLabel.Text = "Unlikely";
                    break;
                case 3:
                    outputLabel.Text = "Yes";
                    break;
                case 4:
                    outputLabel.Text = "Certainly";
                    break;
                case 5:
                    outputLabel.Text = "Impossible";
                    break;
                case 6:
                    outputLabel.Text = "Very Doubtful";
                    break;
            }
        }
    }
}
