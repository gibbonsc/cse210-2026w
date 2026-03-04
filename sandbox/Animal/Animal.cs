abstract class Animal
{
    protected string _name;

    public Animal(string n)
    {
        _name = n;
    }

    abstract public void MakeNoise();
}
