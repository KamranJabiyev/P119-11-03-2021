using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //Person p1 = new Person();
            //Person p2 = new Person();
            //Console.WriteLine(p1.Id);
            //Console.WriteLine(p2.Id);
            #endregion

            #region Abstract - can't get instance,contains abstract method and property
            //Eagle eagle = new Eagle();
            //Shark shark = new Shark();

            //string word = "";
            //ShowHowEat(eagle);
            //ShowHowEat(shark);
            //Person person = new Person();
            //Car car = new Car();
            //ShowHowMove(car);
            //ShowHowMove(person);
            #endregion

            #region Sealed - class - can't get inheretance
            SoftwareDeveloper sd = new SoftwareDeveloper();
            sd.Knowledge();
            #endregion
    }

        static void ShowHowMove(IMove obj)
        {
            obj.Move();
        }

        static void ShowHowEat(Animal animal)
        {
            animal.Eat();
        }
    }

    #region Sealed - class - can't get inheretance
    abstract class Person
    {
        public virtual void Knowledge()
        {
            Console.WriteLine("Nothing");
        }
    }

    class Engineer:Person
    {
        public sealed override void Knowledge()
        {
            Console.WriteLine("little bit");
        }
    }
    sealed class SoftwareDeveloper: Engineer
    {
        //public override void Knowledge()
        //{
        //    Console.WriteLine("ooooo");
        //}
    }

    //class Test:SoftwareDeveloper
    //{

    //}
    #endregion

    #region Abstract - cann't get instance,contains abstract method and property

    //INTERFACE - cann't get instance,methods not required body and access modifiers(after 8th version),
    //class can be implement more than one interface
    interface IMove
    {
        void Move();

        public void Test()
        {
            Console.WriteLine("Salam");
        }
    }
    class Car:IMove
    {
        public void Move()
        {
            Console.WriteLine("Move as Car");
        }
    }

    interface ISee
    {
        void See();
    }

    class X
    {

    }

    //class Person : X,IMove,ISee
    //{
    //    public void Move()
    //    {
    //        Console.WriteLine("Move as Person");
    //    }

    //    public void See()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    abstract class Animal
    {
        public abstract int MyProperty { get; set; }
        public abstract void Eat();

        public virtual void Live()
        {
            Console.WriteLine("Live as Animal");
        }
    }

    abstract class Bird:Animal
    {
        public abstract void Fly();
    }

    class Eagle : Bird
    {
        public override int MyProperty { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }

    abstract class Fish : Animal
    {
        public abstract void Swim();
    }

    class Shark : Fish
    {
        public override int MyProperty { get; set; }

        public override void Eat()
        {
            Console.WriteLine("Eat as Shark");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim as Shark");
        }

        public override void Live()
        {
            Console.WriteLine("Live as kishi kimi");
        }
    }

    
    #endregion

    #region Task
    //class Person
    //{
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public int Id { get; }

    //    private static int counter = 0;

    //    public Person()
    //    {
    //        counter++;
    //        Id = counter;
    //    }


    //}
    #endregion
}
