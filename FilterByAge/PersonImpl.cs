using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterByAge
{
    public static class PersonImpl
    {
        public static Predicate<Person> FilterByAge(string condition, int age)
        {
            return condition switch
            {
                "younger" => p => p.Age < age,
                "older" => p => p.Age >= age,
                _ => null!
            };
        }
    }
}
