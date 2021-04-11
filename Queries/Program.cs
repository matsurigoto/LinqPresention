using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = new List<Game>
            {
                new Game { Title = "PC game A", Rating = 7.1f , Year = 2003 },
                new Game { Title = "PC game B", Rating = 5.0f , Year = 1999 },
                new Game { Title = "Mobile game A", Rating = 5.9f , Year = 2011 },
                new Game { Title = "Mobile game B", Rating = 9.3f , Year = 2007 },
                new Game { Title = "Html game A", Rating = 8.5f , Year = 2014 },
                new Game { Title = "Html game B", Rating = 6.1f , Year = 2018 }
            };

            //var query = games.Where(x => x.Year > 2005);

            //foreach (var game in query)
            //{
            //    Console.WriteLine($"{game.Title}");
            //}



            //------------------ Demo 2 ---------------------

                var query = games.Filter(x => x.Year > 2005)
                /*.Take(1)*/
                /*.ToList()*/
                /*.OrderBy(x => x.Year)*/;

            //Console.WriteLine(query.Count());
            

            //var enumerator = query.GetEnumerator();
            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine(enumerator.Current.Title);
            //}


            //var numbers = CustomLinq.Random().Where(n => n > 0.5).Take(10);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
        }
    }
}
