using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculatorBase
    {
        public abstract void FirstNumMethod(double Num);
        public abstract void SecondNumMethod(double Num);
        public virtual void GetOption() 
        {
            
        }
        public abstract void Calculation();
    }
}
