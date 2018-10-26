using System;
namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("_in: ");
            var _in = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsFibonacci(_in));
            Console.ReadKey();
        }

        private static bool IsFibonacci(int _in)
        {
            var _prev = 0;
            var _this = 0;
            var _next = 1;

            for(;;)
            {
                if (_next > _in)
                    return false;
                if (_in == _next)
                    return true;
                _prev = _this;
                _this = _next;
                _next = _this + _prev;
            }
        }
    }
}
