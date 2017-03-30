using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005UmwandlungDezimalInDual
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int dezimal = Convert.ToInt16(Console.ReadLine());
                String dual = "";
                while (dezimal > 0)
                {
                    dual = (dezimal % 2) + dual;
                    dezimal = dezimal / 2;
                }
                Console.WriteLine("Dualzahl: {0}", dual);
                Console.WriteLine("Möchten Sie noch eine Zahl umwandeln? (ja/nein)");
            } while (Console.ReadLine() == "ja");
        }
    }
}
