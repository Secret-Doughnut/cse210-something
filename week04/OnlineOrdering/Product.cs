using System.Formats.Asn1;
using System.Transactions;

public class Product
{
    private Dictionary<int, (string StoreItem, decimal ItemPrice)> ProductCatalog = new Dictionary<int, (string StoreItem, decimal ItemPrice)>
    {
        [014] = ("Sewing Needles", 0.79m),
        [121] = ("Peanut Butter(s)", 3.21m),
        [123] = ("Banana(s)", 0.50m),
        [200] = ("Birthday Candles", 1.20m),
        [493] = ("Jelly Beans", 1.00m),
        [532] = ("Canned Olives", 1.57m),
        [619] = ("Hammer(s)", 15.31m),
        [742] = ("New video game(s)", 60.00m),
        [905] = ("Store Window(s)", 5000.21m),
        [999] = ("The Store(s) Itself?!", 999999.99m)
    };

    private List<string> ItemName = new List<string>();
    private List<decimal> ListOfPrices = new List<decimal>();


    public void ProductSorter((int, int) shoppinglist)
    {
        var iteminfo = ProductCatalog[shoppinglist.Item1];
        ItemName.Add($"{shoppinglist.Item1}: {shoppinglist.Item2} {iteminfo.Item1}");

        decimal Answer = ProductMath(iteminfo.Item2, shoppinglist.Item2);
        ListOfPrices.Add(Answer);
    }

    private decimal ProductMath(decimal price, decimal quantity)
    {
        decimal Answer = price * quantity;

        return Answer;
    }

    public List<string> GetItemName()
    {
        return ItemName;
    }

    public List<decimal> GetListOfPrices()
    {
        return ListOfPrices;
    }
}