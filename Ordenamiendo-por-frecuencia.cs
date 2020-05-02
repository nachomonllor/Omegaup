//https://omegaup.com/arena/problem/Ordenamiendo-por-frecuencia/#problems/Ordenamiendo-por-frecuencia

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {



        public static List<int> ordenarPorFrecuencia(int[] arr)
        {

            Dictionary<int, int> frec = new Dictionary<int, int>();

            foreach (int item in arr)
            {
                if (frec.ContainsKey(item))
                {
                    frec[item]++;
                }
                else
                {
                    frec[item] = 1;
                }
            }

            var items = from pair in frec
                        orderby pair.Value descending , pair.Key ascending
                        select pair;


            List<int> res = new List<int>();
            foreach (var item in items)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    res.Add(item.Key);
                }
            }
            return res;

        }



        static void Main(string[] args)
        {

            //int[] arr = { 8, 7, 6, 8, 7, 8 };

            //List<int> res = ordenarPorFrecuencia(arr);

            //foreach (int item in res)
            //{
            //    Console.Write(item + " ");
            //}
            int n = int.Parse(Console.ReadLine().Trim());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), e => int.Parse(e));

            foreach (int item in ordenarPorFrecuencia(arr))
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();

        }



    }
}
