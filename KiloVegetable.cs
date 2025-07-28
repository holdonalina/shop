public class KiloVegetable : Vegetable
{
    private double Kilograms;

    public KiloVegetable(string name, decimal basePrice, double kilograms)
    {
        Name = name;
        BasePrice = basePrice;
        Kilograms = kilograms;
    }

    public override decimal GetPrice() => BasePrice * (decimal)Kilograms;

    public override string GetInfo() =>
        $"{Name}: {Kilograms} kg, {BasePrice:C}/kg, total: {GetPrice():C}";
}