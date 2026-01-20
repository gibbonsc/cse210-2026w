namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Costume detective = new Costume();
        detective._headGear = "fedora";
        detective._shirt = "trenchcoat";
        detective._pants = "slacks";
        detective._footwear = "wingtip shoes";
        detective._accessories = "magnifying glass";

        Costume nurse = new Costume();
        nurse._headGear = "surgical mask";
        nurse._shirt = "scrubs";
        nurse._pants = "scrubs";
        nurse._footwear = "orthopedic sneakers";
        nurse._accessories = "clipboard, stehoscope";

        Costume snorkeler = new Costume();
        snorkeler._headGear = "goggles";
        snorkeler._shirt = "wetsuit";
        snorkeler._pants = "wetsuit";
        snorkeler._footwear = "flippers";
        snorkeler._accessories = "snorkel";

        Costume cowboy = new Costume();
        cowboy._headGear = "cowboy hat";
        cowboy._shirt = "flannel button-up";
        cowboy._pants = "jeans";
        cowboy._footwear = "boots with spurs";
        cowboy._accessories = "leather gloves, lasso rope";

        Costume bagpiper = new Costume();
        bagpiper._headGear = "glengarry bonnet";
        bagpiper._shirt = "vest";
        bagpiper._pants = "tartan kilt";
        bagpiper._footwear = "ghillie brogues";
        bagpiper._accessories = "sporran, bagpipes";

        detective.OutputReport();
        nurse.OutputReport();
        snorkeler.OutputReport();
        cowboy.OutputReport();
        bagpiper.OutputReport();
    }
}
