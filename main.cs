using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            switch (a) 
            {
                case "+":
                    Console.WriteLine("You enter +");
                    break;

                case "-":
                    Console.WriteLine("You enter -");

                    break;

                default:

                    Console.WriteLine("I dont know");

                    break;
             }
             /*
             текст для нової гілки перщого коміту feature/firstCommitToMain
             */
        }
    }
}