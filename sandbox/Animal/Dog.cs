class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        
    }
    override public void MakeNoise()
    {
        Console.WriteLine($"{_name} says: Woof");
    }
}