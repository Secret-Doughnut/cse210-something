using System;

class Program
{
    static void Main(string[] args)
    {
        RNGMachine rng1 = new RNGMachine();
        Product product1 = new Product();

        List<(int, int)> shoppinglist = rng1.ShoppingListMaker();
        string address = rng1.AddressRandomizer();
        string name = rng1.NameRandomizer();


        foreach (var item in shoppinglist)
        {
            product1.ProductSorter(item);
        }

        Address address1 = new Address(address);
        Customer customer1 = new Customer(name);

        bool check = customer1.SameCountryCheck();
        List<string> itemname = product1.GetItemName();
        List<decimal> listofprices = product1.GetListOfPrices();

        Order order1 = new Order(shoppinglist, itemname);
        Order order2 = new Order(name, address);
        Order order3 = new Order(listofprices, check);
    }
}