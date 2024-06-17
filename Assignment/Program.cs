// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Inheritance and Method Overriding
class Animal
{

    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }


    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    static void Main(string[] args)
    {
        // Inheritance and Method Overriding
        Animal animal = new Animal();
        animal.MakeSound(); // Prints "Some generic sound"

        Dog dog = new Dog();
        dog.MakeSound(); // Prints "Bark"

        Cat cat = new Cat();
        cat.MakeSound(); // Prints "Meow"
    }
}
