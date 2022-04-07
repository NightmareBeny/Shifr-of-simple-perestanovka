using System;
using static System.Console;
using static System.Math;

namespace Shifr
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите шифруемое слово: ");
            string msg = ReadLine(); //шифруемое слово
            int m = 3; //кол-во столбцов в матрице
            var n = Convert.ToInt32(Round((double)msg.Length / 3)); //кол-во строк по-максимому
            var mass = new char[n, m]; //таблица для шифрования
            for (int i = 0, ink = 0; i < n; i++)
                for (int j = 0; j < m; j++, ink++)
                    try
                    {
                        mass[i, j] = msg[ink];
                    }
                    catch
                    {
                        mass[i, j] = ' ';
                    }
            Write("\nВаше зашифрованное слово: ");
            for (int j = 0; j < m; j++)
                for (int i = 0; i < n; i++)
                    Write(mass[i, j]);
            Write("\nРасшифровка слова: ");
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    Write(mass[i, j]);
            WriteLine('\n');
        }
    }
}