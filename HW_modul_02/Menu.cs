using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


// я не могу разобраться с массивами)))))))
// массив B запоняется не дробными числами и выводиться в строку а не матрицей. не понимаю...
namespace HW_modul_02
{
    internal class Menu
    {
        public void Menu1() 
        {
            Console.WriteLine(" Модуль 2\n\n Меню\n");
            Console.Write(" Задание 1 - введите [1]\n Задание 2 - введите [2]\n Задание 3 - введите [3]\n" +
                " Задание 4 - введите [4]\n Задание 5 - введите [5]\n Задание 6 - введите [6]\n" +
                " Задание 7 - введите [7]\n\n Введите номер задания: ");

            char num = Console.ReadKey().KeyChar;

            switch(num)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("\n Задание 1.\n" +
                        " Объявить одномерный (5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B.\n" +
                        " Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов.\n" +
                        " Вывести на экран значения массивов: массива А в одну строку, массива В — в виде матрицы.\n" +
                        " Найти в данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов,\n" +
                        " общее произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В\n");
                    Console.Write(" Заполните массив любыми числами: ");

                    int[] A = new int[5];
                    float[,] B = new float[3,4];

                    Random random = new Random();

                    try
                    {
                      for(int i = 0; i < A.Length; i++)
                        {
                            A[i] = int.Parse(Console.ReadLine());
                        }

                      for(int j = 0; j < 3; j++)
                        {
                            for(int t = 0; t < 4; t++)
                            {
                                B[j, t] = random.Next(20);
                            }
                        }
                        Console.Write(" Нажмите любую клавишу чтобы продолжить: ");
                        Console.ReadLine();

                        Class1 class1 = new Class1(A, B);
                        class1.Print();

                    }
                    catch (Exception ex) 
                    {
                        Console.WriteLine(ex);
                    }

                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                case '5':
                    break;
                case '6':
                    break;
                case '7':
                    break;
                 default:
                    break;
            }
        }
    }
}
