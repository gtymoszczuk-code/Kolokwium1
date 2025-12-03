public class Present
{
    public string PersonName { get; set; }
    public string GiftName { get; set; }
    public decimal Price { get; set; }

    public Present(string personName, string giftName, decimal price)
    {
        PersonName = personName;
        GiftName = giftName;
        Price = price;
    }
}