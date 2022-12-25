using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate : ICalculatorBase
    {


        public double FirstNum { get; set; }
        public double SecondNum { get; set; }
        public string Option { get; set; }

        bool Check = false;
        string Opt;

        public void FirstNumMethod(double Num)
        {
            FirstNum = Num;

        }

        public virtual void GetOption()
        { 
            do
            {
                Opt = Console.ReadLine();

                switch (Opt)
                {

                    case "+":
                       Check= true;
                        Option = Opt;
                        break;

                    case "-":
                        Check= true;
                        Option = Opt;
                        break;

                    case "*":
                        Check= true;
                        Option = Opt;
                        break;

                    case "/":
                        Check= true;
                        Option = Opt;
                        break;

                    default:
                        Console.WriteLine("\t\tWrong Option!!!");
                        break;
                }
            } while (Check!=true);



        }
        public void SecondNumMethod(double Num)
        {
            SecondNum = Num;
        }


        public void Calculation()
        {
            if (Option == "+")
            {
                Console.WriteLine($"Your Result:   {FirstNum + SecondNum}");
            }
            else if (Option == "-")
            {
                Console.WriteLine($"Your Result:   { FirstNum - SecondNum}");
            }
            else if (Option == "*")
            {
                Console.WriteLine($"Your Result:   {FirstNum * SecondNum}");
            }
            else
            {
                Console.WriteLine($"Your Result:   {FirstNum / SecondNum}");
            }
        }

    }


}
