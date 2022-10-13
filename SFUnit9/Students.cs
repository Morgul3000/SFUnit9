using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFUnit9
{
    internal class Students
    {
        public delegate void StudentsDelegate(int number);
        public event StudentsDelegate studentsEvent;

        private List<string> nameList = new List<string>();

        public void GetArrayStudents(int x)                       //Инициализация листа фамилий студентов
        {
            nameList = new List<string>(x);
            int num = 0;

            for (int i = 0; i < 5; i++)
            {
                num++;
                Console.WriteLine($"Введите фамилию студента номер {num}:");
                nameList.Add(Console.ReadLine());
            }
            Console.WriteLine();
        }

        public void ReadNumber()                                  //Метод получения варианта сортировки листа
        {
            int number;

            Console.WriteLine("Введите номер сортировки: 1(А-Я) или 2(Я-А).");

            while (!int.TryParse(Console.ReadLine(), out number))        //Проверка на ввод числового значения
            {
                Console.WriteLine("Некорректные данные! Введите число 1 или 2.");
            }

            if (number != 1 && number != 2) throw new ArgumentException();        //Проверка на корректный ввод значения

            studentsEvent?.Invoke(number);
        }
        public void GetSortArray()                                            //GetSortArray - сортировка (А - Я)
        {
            nameList.Sort();

            Console.WriteLine();
            Console.WriteLine("Сортировка (А - Я)");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }
        public void GetReversArray()                          //GetReversArray - сортировка (Я - А)
        {
            nameList.Sort();
            nameList.Reverse();

            Console.WriteLine();
            Console.WriteLine("Сортировка (Я - А)");
            foreach (string name in nameList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
