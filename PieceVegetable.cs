public class PieceVegetable : Vegetable
{
    private int Quantity;

    public PieceVegetable(string name, decimal basePrice, int quantity)
    {
        Name = name;
        BasePrice = basePrice;
        Quantity = quantity;
    }

    public override decimal GetPrice() => BasePrice * Quantity;

    public override string GetInfo() =>
        $"{Name}: {Quantity} pcs, {BasePrice:C}, total: {GetPrice():C}";
}