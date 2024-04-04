namespace ComputerStore.Class
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string Address { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
