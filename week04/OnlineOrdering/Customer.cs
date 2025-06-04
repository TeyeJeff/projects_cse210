using System;

public class Customer
{
    private string _name;
    private Address _address;


    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public void SetAdress(Address address)
    {
        _address = address;
    }

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }




}