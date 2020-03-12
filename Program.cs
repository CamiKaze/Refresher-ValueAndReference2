using System;

namespace ValueAndReference2
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* value type: number will remain 1 because the variable in main, and the variable in
            the Increment method will work independent from one another. Stack - Copy of an object. */
            var number = 1;
            Increment(number);
            System.Console.WriteLine(string.Format("The value of number in main is {0}", number));

            /* The difference here is that a reference is going to be copied to the MakeOld method.
            Both the person in the main method, and the person that we have as a parameter to the MakeOld
            method will be pointing to the same object on the heap. Heap - Reference to an object. */
            var person = new Person(){ Age = 20 };
            MakeOld(person);
            System.Console.WriteLine(string.Format("The value of person.age on main is {0}", person.Age));
        }

        // The value gets incremented, but when it goes back to main, the value is immediately destroyed.
        public static void Increment(int number)
        {
            number += 10;
            System.Console.WriteLine(string.Format(string.Format("The value in the Increment method is {0}", number)));
        }

        // The value gets incremented in the reference, and therefore, the change is seen by other methods that access the value in the reference.
        public static void MakeOld(Person person)
        {
            person.Age += 10;
            System.Console.WriteLine(string.Format("The value in the MakeOld method is {0}", person.Age));
        }
    }
}
