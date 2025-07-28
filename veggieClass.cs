public abstract class Vegetable
{
    public string Name { get; protected set; }
    protected decimal BasePrice;

    public abstract decimal GetPrice();
    public abstract string GetInfo();
}