using System;

public abstract class Animal
{
    public abstract void Sound();
}
public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    } 
}

public class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();
        MakeAnimalSound(dog);
        MakeAnimalSound(cat);        
    }

    static void MakeAnimalSound(Animal animal)
    {
        animal.Sound();   
    }
}