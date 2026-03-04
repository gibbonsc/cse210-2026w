class Program
{
    static void Main(string[] args)
    {
        List<Animal> myAnimals = new List<Animal>();
        myAnimals.Add( new Pig("Porkrind"));
        myAnimals.Add( new Dog("Oliver"));
        myAnimals.Add( new Fox("Ylvis"));
        // myAnimals.Add( new Animal("Bro. Gibbons")); // can't make abstract object

        foreach (Animal critter in myAnimals)
        {
            critter.MakeNoise();
        }

        // Animal myAnimal = new Animal("Gary");
        // myAnimal.MakeNoise();
        // Pig myPig = new Pig("Bacon");
        // myPig.MakeNoise();
        // Dog myDog = new Dog("Oliver");
        // myDog.MakeNoise();
    }
}
