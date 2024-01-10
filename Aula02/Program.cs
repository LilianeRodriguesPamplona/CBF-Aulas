using System;

namespace Aula02
{
    class Program
    {
        private const int Index = 0;

        static void Main(string[] args)
        {
            System.Console.WriteLine("CFB Cursos");
            if(args.GetLength(0)>0){
            System.Console.WriteLine(args.GetValue(0));
            }
        }
    }
}
