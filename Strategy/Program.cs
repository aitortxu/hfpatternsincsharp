using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            Mallard mallard = new Mallard();
            DoSomething(mallard);

            Console.WriteLine("Spaniel");
            Spaniel spaniel = new Spaniel();
            DoSomething(spaniel);

            Console.WriteLine("Progeny");
            Spaniel progeny = new Spaniel();
            progeny.SetQuack(new QuackLikeMallard());
            DoSomething(progeny);

            Console.WriteLine("Rubber");
            Duck rubber = new RubberSpaniel();
            DoSomething(rubber);

            Console.ReadLine();
        }

        static void DoSomething(Duck myDuck)
        {
            Console.WriteLine("-------------------");
            myDuck.Swim();
            myDuck.DoFly();
            myDuck.DoQuack();
        }
    }
}
