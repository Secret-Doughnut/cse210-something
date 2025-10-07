using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

public class Address
{
    private static string _BuildingNumber = "";
    private static string _Street = "";
    private static string _City = "";
    private static string _State = "";
    private static string _Country = "";
    private static string _WholeAddress = "";


    public Address()
    {

    }

    public Address(string address)
    {
        AddressSpliter(address);
    }

    private void AddressSpliter(string address)
    {
        string[] strings = address.Split(",", StringSplitOptions.TrimEntries);

        _BuildingNumber = strings[0];
        _Street = strings[1];
        _City = strings[2];
        _State = strings[3];
        _Country = strings[4];
        _WholeAddress = address;
    }

    public bool SameCountryCheck()
    {
        bool Check = false;

        if (_Country == "USA")
        {
            Check = true;
        }

        return Check;
    }
}