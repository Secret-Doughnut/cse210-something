using System.Reflection.Emit;

public class Order
{
    private List<(int ProductID, int Quantities)> ShoppingList = new List<(int ProductID, int Quantities)>();
    private List<decimal> ListOfPrices = new List<decimal>();
    private List<string> ItemName = new List<string>();
    private List<string> OrderHistory = new List<string>();

    private string _CustomerName = "";
    private string _CustomerAddress = "";
    private bool _Check = true;
    private decimal _TotalPrice = 0;


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
        //This will call both PackingLabel and ShippingLabel
        //And merge it together for OrderHistory.
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
            Console.WriteLine(item);
        }
        
        foreach (var item in ItemName)
            {
                Console.WriteLine(item);
                Console.WriteLine($"This is packing label! {PaperLabel}");
                PaperLabel += $"\n{item}";
            }

        Console.WriteLine(PaperLabel);

        return PaperLabel;
    }

    private string ShippingLabel()
    {
        return "";
    }


}