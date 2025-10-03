using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterByAge
{
    public static class PersonHelper
    {
        public static Func<string, int, Predicate<Person>> filter = PersonImpl.FilterByAge;

        public static Action<Person> PrintPerson(string format)
        {
            return format switch
            {
                "name" => p => Console.WriteLine(p.Name),
                "age" => p => Console.WriteLine(p.Age),
                "name age" => Console.WriteLine,
                _ => null!
            };
        }
    }
}
