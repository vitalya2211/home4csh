using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home4csh
{
    class Program
    {
        static void Main(string[] args)
        {/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит 
         число A в натуральную степень B.
         3, 5 -> 243 (3⁵)
         2, 4 -> 16
         Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        452 -> 11
        82 -> 10
        9012 -> 12
        Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
        6, 1, 33 -> [6, 1, 33]*/
            
            void foo1(int A, int B)
            {
                int temp = A;
                for (; B > 1; B--)
                { A *= temp; }
                Console.WriteLine(A);
            }
            int foo2(int A)
            {
                int temp = 0;
                if (A > 10)
                {

                    while (A != 0)
                    {
                        temp += A % 10;
                        A /= 10;
                    }

                }
                else temp = A;
                return temp;
            }
            void foo_arr(int[] Array)
            {
                Random rnd = new Random();
                for(int i=0;i<Array.Length;i++)
                    Array[i]= rnd.Next(0, 10);
            }
            void print_arr(int[] Array)
            {
                for (int i = 0; i < Array.Length; i++)
                    Console.Write(Array[i]+"\t");
            }
            int a, b,c=1;
            int[] array = new int[8];
            while (c != 0)
            {
                
                Console.WriteLine("выберите номер задачи:\n" +
                    "1.программа принимает два числа и возводит первое число в натуральную степень второго числа\n" +
                    "2.программа выдает сумму цифр введенного числа\n" +
                    "3.создание массива с рандомными элементами. размер массива = 8\n" +
                    "0.выход\n");
                c = Convert.ToInt32(Console.ReadLine());
                switch (c)
                {
                    case 1:
                        {
                            Console.Write("программа принимает на вход два числа и возводит первое в степень второго\n" +
                                "введите число А: ");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("введите число Б: ");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.Write(a + " в степени " + b + " = ");
                            foo1(a, b);
                            Console.WriteLine("\n для продолжения нажмите любую клавишу\n");
                            Console.ReadKey();
                        }
                        break;
                    case 2:
                        {
                            Console.Write("программа выдает сумму цифр в числе\n введите число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("сумма цифр числа  = " + foo2(a));
                            Console.WriteLine("для продолжения нажмите чего нибудь.");
                            Console.ReadKey();
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("создает массив из 8и рандомных элементов\n для продолжения нажмите кнопку");
                            foo_arr(array);
                            print_arr(array);
                            Console.WriteLine("\nжми клавишу\n");
                            Console.ReadKey();
                        }
                        break;
                    case 0:
                        break;
                    default:
                        {
                            Console.WriteLine("ошибка ввода, нажмите любую кнопку и попробуте снова");
                            Console.ReadKey();
                        }
                        break;
                        }
            }
            Console.WriteLine("спасибо за проверку");
            System.Threading.Thread.Sleep(2500);
        }
    }
}
