using System;

namespace Delegate_Lambda_Anonymous
{
    class Program
    {
        public delegate int CalculateDiff(int x, int y);
        delegate void TestDelegate(string s);

        static void Main(string[] args)
        {
            TestDelegate testDelA = new TestDelegate(x => Console.WriteLine(x)); //ez a classic delegate deklarálás named function-nal, c# 2.0-nál már lehet incline code-dal
                                                                                 //is (ezt hívják anonymous function-nak) és lambda-val is helyettesíteni, lásd 14. és 15. sorok
            Func<int, int, int> fn = (x, y) => x * y;
            Func<int, int, int> fn2 = delegate (int x, int y) { return x + y; };
            CalculateDiff fn3 = (x, y) => x - y;
            CalculateDiff fn4 = delegate (int x, int y) { return x * 2 + y * 2; };

            testDelA("valami");
            Console.WriteLine("Az eredmény fn: " + fn(2, 3));
            Console.WriteLine("Az eredmény fn2: " + fn2(2, 3));
            Console.WriteLine("Az eredmény fn3: " + fn3(5, 2));
            Console.WriteLine("Az eredmény fn4: " + fn4(5, 2));
        }
    }
}
