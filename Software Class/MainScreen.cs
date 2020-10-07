using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Class
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void Testknop()
        {
                this.BackColor = Color.Blue
                System.Threading.Thread.Sleep(1000);
                this.BackColor = DefaultBackColor
        }        
        
        
        private void GreenBack_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;       //Make the BackColor from this(form) Green
            GreenBack.BackColor = Color.White;  //Make the BackColor from GreenBack White
        }

        private void GreenBack_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;  //Make the BackColor from this(form) DefaultBackColor
            GreenBack.BackColor = Color.Green;  //Make the BackColor from GreenBack Green
        }

        private void BlueBack_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;        //Make the BackColor from this(Form) Blue
            BlueBack.BackColor = Color.White;   //Make the BackColor from BlueBack White
            BlueBack.ForeColor = Color.Black;   //Make the ForeColor(Font) from BlueBack Black
        }

        private void BlueBack_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;  //Make the BackColor from this(form) DefaultBackColor
            BlueBack.BackColor = Color.Blue;    //Make the BackColor from BlueBack Blue
            BlueBack.ForeColor = Color.White;   //Make the ForeColor(Font) from BlueBack White
        }

        private void RedBack_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;         //Make the BackColor from this(form) Red
            RedBack.BackColor = Color.White;    //Make the BackColor from RedBack White
        }

        private void RedBack_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;  //Make the BackColor from this(form) DefaultBackColor
            RedBack.BackColor = Color.Red;      //Make the BackColor form RedBack Red
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbFirstNumber.Text) || String.IsNullOrEmpty(tbSecondNumber.Text))
            {
                MessageBox.Show("Typ wat in");  //Shows a MessageBox with "Typ wat in"
            }
            else
            {
                int FirstNumber;            //Makes FirstNumber a Interger
                int SecondNumber;           //Makes SecondNumber a Interger
                int EndResult;              //Makes EndResult a Interger

                FirstNumber = Convert.ToInt16(tbFirstNumber.Text);      //Converts tbFirstNumber to Interger
                SecondNumber = Convert.ToInt16(tbSecondNumber.Text);    //Converts tbSecondNumber to Interger
                switch (cbPlus.SelectedItem)
                {
                    case "plus":
                        EndResult = FirstNumber + SecondNumber;
                        tbEndResult.Text = EndResult.ToString();
                        break;

                    case "min":
                        EndResult = FirstNumber - SecondNumber;
                        tbEndResult.Text = EndResult.ToString();
                        break;

                    case "deel":
                        EndResult = FirstNumber / SecondNumber;
                        tbEndResult.Text = EndResult.ToString();
                        break;

                    case "keer":
                        EndResult = FirstNumber * SecondNumber;lol
                        tbEndResult.Text = EndResult.ToString();
                        break;

                    default:
                        MessageBox.Show("Geef een teken");
                        break;

                        for (int i = 0; i < 5; i++)
                        {
                            Trace.WriteLine("Test");
                        }

                }
            }
        }

        private void tLoop_Click(object sender, EventArgs e)
        {
            for (int Test = 20; Test >= 1; Test--)
            {
                string myString = Test.ToString();
                tTimer.Text = myString;
                this.Refresh();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}