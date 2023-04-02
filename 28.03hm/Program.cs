using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._03hm
{
    abstract class CombatUnit
    {
        public string name { get; set; }
        public string speed { get; set; }
        public string power { get; set; }
        abstract public void Show();
    }

    class Shturm : CombatUnit
    {
        public Shturm()
        {
            name = "Штурмовики";
            speed = "50";
            power = "-19";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class Dgadai : CombatUnit
    {
        public Dgadai()
        {
            name = "Джедаии";
            speed = "100";
            power = "10000";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class Droid : CombatUnit
    {
        public Droid()
        {
            name = "Дроиды";
            speed = "25";
            power = "100";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class Padvan : CombatUnit
    {
        public Padvan()
        {
            name = "Падаваны";
            speed = "50";
            power = "50";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }

    class Cap : CombatUnit
    {
        public Cap()
        {
            name = "Кап";
            speed = "120";
            power = "100";
        }
        public override void Show()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Power: {power}");
        }
    }


    class CombatFactory
    {
        List<Tuple<Shturm, string>> combats = new List<Tuple<Shturm, string>>();

        public CombatFactory(params CombatUnit[] cu)
        {
            foreach (var elem in cu)
            {
                combats.Add(new Tuple<Shturm, string>(new Shturm(), elem.name));
            }
        }
        public void Show()
        {
            var count = combats.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var c in combats)
            {
                Console.WriteLine(c.Item2);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }
}