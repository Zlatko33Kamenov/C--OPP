namespace FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());

            List<Person> people = new();
            for (int i = 0; i < numberOfPeople; i++)
            {
                var data = Console.ReadLine()
                           .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people.Add(new Person(data[0], int.Parse(data[0])));
            }
            var condition = Console.ReadLine();
            var years = int.Parse(Console.ReadLine());

            Predicate<Person> filterByAge = PersonHelper.FilterByAge(condition, years);
            List<Person> filteredByAge = people.FindAll(filterByAge);

            var format = Console.ReadLine();
            Action<Person> printBy = PersonHelper.PrintPerson(format);

            filteredByAge.ForEach(PersonHelper.PrintPerson);
        }
    }
}
