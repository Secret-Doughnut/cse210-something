using System.Formats.Asn1;
using System.Transactions;

public class Product
{
    Dictionary<int, (string StoreItem, decimal ItemPrice)> ProductCatalog = new Dictionary<int, (string StoreItem, decimal ItemPrice)>
    {
        [014] = ("Sewing Needles", 0.79m),
        [121] = ("Peanut Butter", 3.21m),
        [123] = ("Banana", 0.50m),
        [200] = ("Birthday Candles", 1.20m),
        [493] = ("Jelly Beans", 1.00m),
        [532] = ("Canned Olives", 1.57m),
        [619] = ("Hammer", 15.31m),
        [742] = ("That new video game", 60.00m),
        [905] = ("Store Window", 5000.21m),
        [999] = ("The Store Itself?!", 999999.99m)
    };

    List<string> ItemName = new List<string>();
    List<decimal> ListOfPrices = new List<decimal>();


    public void ProductSorter((int, int) shoppinglist)
    {
        var iteminfo = ProductCatalog[shoppinglist.Item1];
        ItemName.Add($"{shoppinglist.Item1}: {iteminfo.Item1}");

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