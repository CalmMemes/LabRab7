using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabRab7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif

#if DEBUG
            var lala = new Class1(2, 5);
            lala.Cout(ConsoleColor.Cyan, ConsoleColor.Black);
#endif

#if !DEBUG

            var p1 = new Class1(4.5, 10.2);
            p1.Cout(ConsoleColor.Cyan, ConsoleColor.Black);

#endif

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif


        }
    }
}