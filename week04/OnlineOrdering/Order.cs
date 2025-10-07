using System.Reflection.Emit;

public class Order
{
    private static List<(int ProductID, int Quantities)> ShoppingList = new List<(int ProductID, int Quantities)>();
    private static List<decimal> ListOfPrices = new List<decimal>();
    private static List<string> ItemName = new List<string>();
    private static List<string> OrderHistory = new List<string>();

    private static string _CustomerName = "";
    private static string _CustomerAddress = "";
    private static bool _Check = true;
    private static decimal _TotalPrice = 0;

    public Order()
    {

    }

    public Order(List<(int ProductID, int Quantities)> shoppinglist, List<string> itemname)
    {
        ShoppingList = shoppinglist;
        ItemName = itemname;
    }

    public Order(string customername, string customeraddress)
    {
        _CustomerName = customername;
        _CustomerAddress = customeraddress;
    }

    public Order(List<decimal> listofprices, bool samecountrycheck)
    {
        ListOfPrices = listofprices;
        _Check = samecountrycheck;
        TotalPackage();
    }

    private void TotalPackage()
    {
        TotalPriceCalulator();
        string FirstLabel = PackingLabel();
        string SecondLabel = ShippingLabel();
        string FinalLabel = $"{FirstLabel}\n\n{SecondLabel}";
        OrderHistory.Add(FinalLabel);
    }

    private void TotalPriceCalulator()
    {
        decimal ShippingFee = 5.00m;
        foreach (decimal item in ListOfPrices)
        {
            _TotalPrice += item;
        }

        if (_Check == false)
        {
            ShippingFee = 35.00m;
        }

        _TotalPrice += ShippingFee;
    }

    private string PackingLabel()
    {
        string PaperLabel = "";


        foreach (string item in ItemName)
        {
            PaperLabel += $"\n{item}";
        }

        PaperLabel += $"\n\nTotal Price: {_TotalPrice}";

        return PaperLabel;
    }

    private string ShippingLabel()
    {
        string PaperLabel = $"Deliver to {_CustomerName} at {_CustomerAddress}\nThank you for shopping with us!";

        return PaperLabel;
    }

    public List<string> GetOrderHistory()
    {
        return OrderHistory;
    }
}