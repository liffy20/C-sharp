using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompoundInterestCalc
{
   public class Calc


    {

      public static  Calc c = new Calc();

   public static String P;
     public static   String R;
    public static    String M;
      
        static public bool isPValid(string P)
        {
            bool isPValid = true;
            Double dubP;
            dubP = Convert.ToDouble(P);

            if (string.IsNullOrWhiteSpace(P) || (dubP < 0) )
            {
                isPValid = false;

            }
            return isPValid;
        }
       static public bool isRValid(string R)
        {
            bool isRValid = true;
            double dubR;
            dubR = Convert.ToDouble(R);

            if (string.IsNullOrWhiteSpace(R) || (dubR < 0))
            {
                isRValid = false;

            }
            return isRValid;
        
        }

       static public bool isMValid(string M)
        {

            
            bool isMValid = true;
            Double dubM;
            dubM = Convert.ToDouble(M);

            if (string.IsNullOrWhiteSpace(M) || (dubM < 1))
            {
                isMValid = false;

            }
            return isMValid;
        }


        static public double MonthlyPayment(double dubP, double dubR, double dubM)
        {
            double NewerR = 0;

            NewerR = ((dubR / 100) / 12);


            double A = 0;

            double num, denom, opnum, opdenom;

            opnum = 1 + NewerR;
            num = Math.Pow(opnum, dubM);
            opdenom = 1 + NewerR;
            denom = Math.Pow(opdenom, dubM);

            A = dubP * ((NewerR * num) / (denom - 1));

            double storeddouble;
            storeddouble = Math.Round(A, 2);
            return storeddouble;
        }

        static public void ShowResult(double finalmonthlypay, double dubR, double DubM)
        {
            string monthly, rate, months;
            monthly = Convert.ToString(finalmonthlypay);
           months = Convert.ToString(dubR);
            rate = Convert.ToString(DubM);

            MessageBox.Show("Your monthly payments will be " + monthly + "  with an interest rate of " + rate + "% " + "compounded monthly for a period of " + months + " months.");
        }
















    }
}
