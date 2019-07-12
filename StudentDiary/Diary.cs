using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        //Stan (zmienne - pola)
        List<float> ratings = new List<float>();
        

        //Zachowania
        public void AddRating(float rating)
        {
            ratings.Add(rating);
        }

        //Oblicza średnią z ocen
        public float CalculateAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }

            avg = sum / ratings.Count();

            return avg;
        }

        //Zwraca najwyższą ocenę
        public float GiveMaxRating()
        {
            return ratings.Max();
        }

        //Zwraca najniższą ocenę
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
