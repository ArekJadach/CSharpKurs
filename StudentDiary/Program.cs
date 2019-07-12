using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
           
            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 - 10 : ");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);

                if (rating == 0)
                {
                    break;
                }
                if (result)
                {
                    if (rating > 0 && rating <=10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba. Podaj wartość z zakresu 1 - 10");
                    }
                }
                
            }

            Console.WriteLine("Średnia twoich ocen to: " + diary.CalculateAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GiveMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GiveMinRating());
            Console.ReadKey();
        }   
    }
}
