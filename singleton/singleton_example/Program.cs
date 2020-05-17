using System;

namespace singleton_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Console.WriteLine(singleton.Info());
        }
    }
}
