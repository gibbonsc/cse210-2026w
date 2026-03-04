class Pig : Animal
{
    public Pig(string name) : base(name)
    {
        
    }
    override public void MakeNoise()
    {
        Console.WriteLine($"{_name} says: Oink");
    }
}