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

public class MainEntry
{
    public static void Main(String[] args)
    {
        Animal myDog = new Dog();
        Animal myCat = new Cat();
        MakeAnimalSound(myDog);
        MakeAnimalSound(myCat);        
    }

    static void MakeAnimalSound(Animal animal)
    {
        animal.Sound();   
    }

}