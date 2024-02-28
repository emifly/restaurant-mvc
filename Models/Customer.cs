public class Customer
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required List<string> PastOrders { get; set; }
}
