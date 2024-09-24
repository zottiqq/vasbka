using System;
namespace Calculator
{
    class Osnov
    {
        public void pls(double one_, double two_)
        {
            Console.WriteLine(one_ + two_);
        }
        public void minus(double one_, double two_)
        {
            Console.WriteLine(one_ - two_);
        }
        public void ymn(double one_, double two_)
        {
            Console.WriteLine(one_ * two_);
        }
        public void del(double one_, double two_)
        {
            if ((one_ == 0) || (two_ == 0))
            { 
                Console.WriteLine("Ошибка");
            }
            else 
            {
                Console.WriteLine(one_ / two_);
            }
        }
    }
}
