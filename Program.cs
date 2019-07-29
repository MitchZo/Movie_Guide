using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie> {
                new Movie("Toy Story", "Animated"),
                new Movie("Nightmare on Elm Street","Horror"),
                new Movie("Training Day","Drama"),
                new Movie("Interstellar","SciFi"),
                new Movie("12 Angry Men","Drama"),
                new Movie("The Lion King","Animated"),
                new Movie("Alien","SciFi"),
                new Movie("Jurassic Park","Horror"),
                new Movie("Guess Who's Coming to Dinner","Drama"),
                new Movie("Charlie and the Chololate Factory","Horror")
            };
            string response = "";

            bool runAgain = true;
            while (runAgain)
            {
                bool isValid = false;
                while (!isValid)
                {
                    Console.Clear();
                    response = GetUserInput("Welcome to MovieFone! Select one of the options below to view the movies playing in your area!\n1. Animated\n2. Drama\n3. Horror\n4. Scifi");
                    if (Validator.Int(response))
                    {
                        isValid = true;
                        if (isValid)
                        {
                            isValid = Validator.IsInRange(int.Parse(response), 1, 4);
                        }
                    }
                    else if ((response.ToLower() == "animated") || (response.ToLower() == "horror") || (response.ToLower() == "drama") || (response.ToLower() == "scifi"))
                        isValid = true;
                    else
                        isValid = false;
                }
                switch (response.ToLower())
                {
                    case
                    "1":
                    case
                    "animated":
                        ListMoviesBy("Animated", movieList);
                        break;
                    case
                        "2":
                    case
                        "drama":
                        ListMoviesBy("Drama", movieList);
                        break;
                    case
                    "3":
                    case
                        "horror":
                        ListMoviesBy("Horror", movieList);
                        break;
                    case
                    "4":
                    case
                        "scifi":
                        ListMoviesBy("SciFi", movieList);
                        break;

                }
                isValid = false;
                while (!isValid)
                {
                    response = GetUserInput("\nWould you like to see other movies playing in your area?");
                    isValid = Validator.YesNo(response);
                }
                if (response.ToLower() == "yes" || response.ToLower() == "y")
                {
                    runAgain = true;
                }
                else
                {
                    runAgain = false;
                }
            }
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
        public static void ListMoviesBy(string filterCategory, List<Movie> movies)
        {
            Console.Clear();
            Console.WriteLine(filterCategory.ToUpper() + "\n");
            foreach (Movie movie in movies)
            {
                if (movie.Category == filterCategory)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
    }
}

