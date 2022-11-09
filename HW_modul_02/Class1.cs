using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_02
{
    internal class Class1
    {
        int[] A1 = new int[5];
        float[,] B1 = new float[3,4];

        public Class1(int[] A, float[,] B)
        {
            A1 = A;
            B1 = B;
        }

        public void Print()
        {
            for (int i = 0; i < A1.Length; i++)
            {
                Console.Write("{0}", A1[i]);
            }
            Console.WriteLine("");

            for (int j = 0; j < 3; j++)
            {
                for (int r = 0; r < 4; r++)
                {
                    Console.Write($"{B1[j,r]}");
                }
            }
            Console.WriteLine();

            Menu menu = new Menu();
            Console.WriteLine(" Нажмите любую клавишу чтобы вернуться в меню: ");
            Console.ReadKey();
            Console.Clear();
            menu.Menu1();
        }
    }
}
