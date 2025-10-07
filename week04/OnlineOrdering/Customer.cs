public class Customer
{
    Address address1 = new Address();
    private string _Name = "";


    public Customer(string customername)
    {
        _Name = customername;
    }

    public bool SameCountryCheck()
    {
        bool Check = address1.SameCountryCheck();

        return Check;
    }
}