using Dio.Series.Entities;
using Dio.Series.Enumerators;
using Dio.Series.Infrastructure.Repositories;
using System;
using System.Collections.Generic;

namespace Dio.Series
{
    class Program
    {
        private static readonly SerieRepository SerieRepository = new SerieRepository();

        static void Main(string[] args)
        {
            var opt = UserOption();

            while(opt.ToLower() != "X".ToLower())
            {
                switch (opt)
                {
                    case "1":
                        List();
                        break;
                    case "2":
                        Add();
                        break;
                    case "c":
                    case "C":
                        Console.Clear();
                        break;
                    case "x":
                    case "X":
                        Environment.Exit(1);
                        break;
                }

                opt = UserOption();
            }
        }

        private static string UserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Hello!!! nice to see you here again");
            Console.WriteLine("Select an option:");
            Console.WriteLine("1 - List all series");
            Console.WriteLine("2 - Add a series");
            Console.WriteLine("3 - Update a series");
            Console.WriteLine("4 - Delete a series");
            Console.WriteLine("5 - See series details");
            Console.WriteLine("C - Clean up screen");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            string opt = Console.ReadLine();

            Console.WriteLine();
            
            return opt;
        }
    
        private static void List()
        {
            Console.WriteLine("List all");
            var list = SerieRepository.List();

            foreach (var serie in list)
            {
                Console.WriteLine($"#{serie.GetId()} - {serie.GetTitle()}");
            }
        }

        private static void Add()
        {
            Console.WriteLine();
            Console.WriteLine("Add new series");
            Console.Write("Title: ");
            var name = Console.ReadLine();
            foreach (var genre in Enum.GetValues(typeof(EnumGenre)))
            {
                Console.WriteLine($"{(int)genre} - {Enum.GetName(typeof(EnumGenre),genre)} ");
            }
            Console.Write("Genre: ");
            var type = (EnumGenre) Enum.Parse(typeof(EnumGenre),Console.ReadLine());
            Console.Write("Description: ");
            var description = Console.ReadLine();
            Console.Write("Rate: ");
            var rate = int.Parse(Console.ReadLine());
            Console.Write("Seasons: ");
            var seasons = int.Parse(Console.ReadLine());
            Console.Write("Released at: ");
            var released = int.Parse(Console.ReadLine());

            SerieRepository.Add(new Serie(SerieRepository.NextId(), name, description, type, rate, seasons, released));
        }
    }
}
