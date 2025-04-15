public class Customer
{
    private string _nameCustomer;
    private Address _address;

    public Customer(string nameCustomer, Address address)
    {
        _nameCustomer = nameCustomer;
        _address = address;
    }
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }
    public string GetName()
    {
        return _nameCustomer;
    }

    public Address GetAddress()
    {
        return _address;
    }

}