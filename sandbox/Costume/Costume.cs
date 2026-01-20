namespace Costume;

class Costume
{
    // attributes
    public string _headGear;
    public string _shirt;
    public string _pants;
    public string _accessories;
    public string _footwear;

    // behaviors
    public void OutputReport()
    {
        string result;
        result = $"Head covering: {_headGear}, Upper garment: {_shirt},\n";
        result += $"Lower garment: {_pants}, Footwear: {_footwear},\n";
        result += $"Accessories: {_accessories}\n";
        Console.WriteLine(result);
    }
}