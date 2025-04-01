using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp1
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            var context = new AppDbContext();
            bool running = true;

            while (running)
            {
                Console.WriteLine("переглянути всіх студентів");
                Console.WriteLine("додати студента");
                Console.WriteLine("видалити студента");
                Console.WriteLine("знайти студента");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        var students = context.Students.ToList();
                        foreach (var student in students)
                        {
                            Console.WriteLine($"ID: {student.Id} | name: {student.Name} \t description: {student.Description}");
                        }
                        break;

                    case "2":
                        Console.Write("введіть студента: ");
                        string name = Console.ReadLine();
                        Console.Write("введіть студента2: ");
                        string description = Console.ReadLine();

                        var newStudent = new Student { Name = name, Description = description };
                        context.Students.Add(newStudent);
                        context.SaveChanges();
                        break;

                    case "3":
                        Console.Write("введіть ID студента, якого хочете видалити: ");

                        //var studentToRemove = context.Students.Find(id);
                        //        context.Students.Remove(studentToRemove);
                        //        context.SaveChanges();


                        break;
                    case "4":
                        //Console.Write("студента для пошуку: ");

                        break;

                }
            }
        }
    }
}
