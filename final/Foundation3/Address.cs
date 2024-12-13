
public class Address
{
    private string street;
    private string city;
    private string state;
    private string zipCode;


    public Address(string addressStreet, string addressCity, string addressState, string addressZipCode)
    {

        street = addressStreet;
        city = addressCity;
        state = addressState;
        zipCode = addressZipCode;
    }

    public string GetAddress()
    {
        return $"{street}, {city}, {state} {zipCode}";
    }
}
