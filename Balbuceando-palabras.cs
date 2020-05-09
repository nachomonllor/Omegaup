//https://omegaup.com/arena/problem/Balbuceando-palabras/#problems/Balbuceando-palabras


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("hola", "konnichiwa");
            dic.Add("comida", "shokumotsu");
            dic.Add("agua", "mizu");
            dic.Add("wc", "toire");
            dic.Add("tren", "densha");
            dic.Add("auxilio", "tasukete");


            string entrada = Console.ReadLine().Trim();
            if (dic.ContainsKey(entrada))
            {
                Console.WriteLine(dic[entrada]);
            }
            else
            {
                Console.WriteLine("palabra no encontrada");
            }


            Console.ReadLine();

        }

    }
}
