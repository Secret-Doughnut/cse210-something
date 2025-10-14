public class RNGMachine
{
    private List<int> IDList = new List<int>
    {
        123,
        493,
        121,
        742,
        619,
        905,
        532,
        014,
        200,
        999
    };
    private List<string> AddressList = new List<string>
    {
        "742, Maple Street, Springfield, Illinois, USA",
        "19, Avenida de la Luna, Madrid, Comunidad de Madrid, Spain",
        "301, Cherry Blossom Lane, Kyoto, Kyoto, Japan",
        "88, Rue de Rivoli, Paris, Île-de-France, France",
    };
    private List<string> NameList = new List<string>
    {
        "Jessica",
        "Jennifer",
        "Salem",
        "Squid",
        "Sev",
        "Vill"
    };
    private List<string> ShoppingList = new List<string>();

    Random random = new Random();

    public List<(int ProductID, int Quantities)> ShoppingListMaker()
    {
        List<(int idcode, int quantityamount)> listid = new List<(int idcode, int quantityamount)>();
        int Countdown = 3;

        while (Countdown != 0)
        {
            int idcode = 0;
            int number = random.Next(0, 9);
            int quantityamount = random.Next(1, 6);
            idcode = IDList[number];

            Countdown -= 1;

            listid.Add((idcode, quantityamount));
        }

        return listid;
    }

    public string AddressRandomizer()
    {
        int number = random.Next(0, 3);
        string address = AddressList[number];
       
        return address;
    }

    public string NameRandomizer()
    {
        int number = random.Next(0, 5);
        string name = NameList[number];

        return name;
    }

    //public List<(int ProductID, int Quantities)> GetShoppingList()
    //{
    //
    //}
}