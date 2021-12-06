using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace base1_Lesson18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите строку, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы ");
            string mystr = Console.ReadLine();
            //string mystr = "У(п[п]р{р}а)в[в]ф";
            if (Scobki(mystr))
            {
                Console.WriteLine(" Скобки расставлены успешно");
            }
            else
            {
                Console.WriteLine(" Скобки расставлены ошибочно");
            }
            Console.ReadKey();
        }
        static bool Scobki(string str)
        {
            Stack<char> st = new Stack<char>();
            string a = "[{(]})";
           
            foreach (var i in str)
            {
                int f = a.IndexOf(i);

                if (f >= 0 && f <= 2)
                    st.Push(i);

                if (f > 2)
                {
                    if (st.Count == 0 || st.Pop() != a[f - 3])
                        return false;
                }
            }

            if (st.Count != 0)
                return false;

            return true;
        }
    }
}
