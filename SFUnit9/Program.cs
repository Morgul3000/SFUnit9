using System;
using System.Collections.Generic;

namespace SFUnit9
{
    internal class Program
    {
        static Students student;
        static void Main(string[] args)
        {
            student = new Students();
            student.studentsEvent += HandleSort;
            student.GetArrayStudents(5);                     //Инициализация листа фамилий студентов
              
            try 
            {
               student.ReadNumber();
            }
            catch (ArgumentException) 
            {
                Console.WriteLine("Ошибка. Цифра должна быть 1 или 2.");
            }
        }
        static void HandleSort(int number)                   //Реализация обработчика события
        {
            switch (number) 
            {
                case 1: student.GetSortArray();              //Отработка метода GetSortArray - сортировка (А - Я)
                    break;
                case 2: student.GetReversArray();            //Отработка метода GetReversArray - сортировка (Я - А)
                    break ;
            }
        }
    }
}
