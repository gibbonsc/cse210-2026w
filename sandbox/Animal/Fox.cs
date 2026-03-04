class Fox : Animal
{
    public Fox(string name) : base(name)
    {
        
    }
    override public void MakeNoise()
    {
        Console.WriteLine($"{_name} says: Hati Hati Hati-ho");
    }
}