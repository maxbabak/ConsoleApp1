using ConsoleApp1.DAL;
using ConsoleApp1.Entities;
using ConsoleApp1.Services;
using System;
using System.ComponentModel.Design;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var start = new MenuService();

            while (true)
            {
                //  case "1":
                //    var students = context.Students.ToList();
                //    foreach (var student in students)
                //    {
                //        Console.WriteLine($"Name: {student.Name} \t Description: {student.Description}");
                //    }
                //    break;
                //case "2":
                //    Console.Write("Введіть ім'я студента: ");
                //    string name = Console.ReadLine();
                //    Console.Write("Введіть опис студента: ");
                //    string description = Console.ReadLine();

                //    var newStudent = new Student { Name = name, Description = description };
                //    context.Students.Add(newStudent);
                //    context.SaveChanges();
                //    Console.WriteLine("Студент доданий успішно!");
                //    break;
                //case "3":
                //    Console.Write("Введіть ID студента, якого хочете видалити: ");
                //    if (int.TryParse(Console.ReadLine(), out int id))
                //    {
                //        var studentToRemove = context.Students.Find(id);
                //        if (studentToRemove != null)
                //        {
                //            context.Students.Remove(studentToRemove);
                //            context.SaveChanges();
                //            Console.WriteLine("Студента видалено успішно!");
                //        }
                //        else
                //        {
                //            Console.WriteLine("Студента з таким ID не знайдено!");
                //        }
                //    }
                //    else
                //    {
                //        Console.WriteLine("Некоректний ID!");
                //    }
                //    break;
                //case "4":
                //    running = false;
                //    break;
                //default:
                //    Console.WriteLine("Некоректний вибір! Спробуйте ще раз.");
                //    break;
                //}
                start.Menu();

            }
        }
    }
}

