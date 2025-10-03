namespace ConsoleApp2
{
    // 1.
    public class Box<T>
    {
        private List<T> _values = new List<T>();

        public void Add(T value)
        {
            _values.Add(value);
        }
    }

    // 2. 
    public class Animal
    {
        protected string _name;
        public void MakeSound()
        {
            Console.WriteLine("Making sound...");
        }
    }

    public class Bear : Animal
    {
        public void PrintInfo()
        {
            base.MakeSound();
            Console.WriteLine($"Name: {base._name}");
        }
    }
    
    // 3. 
    public class Mammal
    {
        protected string _name;
        public virtual void MakeSound()
        {
            Console.WriteLine("Making sound...");
        }
    }

    public class Dolphin : Mammal
    {
        public override void MakeSound()
        {
            Console.WriteLine("KEk kek kek...");
        }
        // overload
        public void PrintInfo()
        {
            MakeSound();
            Console.WriteLine($"Name: {base._name}");
        }
        // overload
        public void PrintInfo(string message)
        {
            Console.WriteLine(message);
        }
    }

    // 5.
    public abstract class BasicBox
    {
        protected List<int> _values = new List<int>();

        public abstract void Add(int value);

        public virtual void PrintData()
        {
            foreach (int value in _values)
            {
                Console.WriteLine(value);
            }
        }
    }

    public interface IPrintable
    {
        void PrintInfo();
    }

    public class FullBox : BasicBox, IPrintable
    {
        public override void Add(int value)
        {
            _values.Add(value);
        }

        public void PrintInfo()
        {
            Console.WriteLine("Info...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.
            Box<int> box = new Box<int>();
            box.Add(1);

            // 3.
            Mammal m = new Dolphin();
            
        }
    }
}
