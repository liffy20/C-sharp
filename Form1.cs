using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundInterestCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Exception ex = new Exception("Only enter numeric values, not symbols or letters, or blanks");
            String ex1 = ex.ToString();

            String P = textBox1.Text;
            String R = textBox3.Text;
            String M = textBox2.Text;
            try
            {

                if (Calc.isPValid(P) && Calc.isRValid(R) && Calc.isMValid(M))
                {

                    double dubP, dubR, dubM;
                    dubP = Convert.ToDouble(P);
                    dubR = Convert.ToDouble(R);
                    dubM = Convert.ToDouble(M);

                    double finalmonthlypay;



                    finalmonthlypay = Calc.MonthlyPayment(dubP, dubR, dubM);
                    Calc.ShowResult(finalmonthlypay, dubM, dubR);




                }
                else
                {
                    MessageBox.Show("Please correct following possible errors:\n Please enter a principal amount number greater than 0\n Please enter an number of months of loan period that is equal or greater than one \n Please enter an interest percentage greater than 0, no need to convert to decimal form\n");
                }
            } catch 
            {

                MessageBox.Show(ex1);
            }


        }
    }
}
