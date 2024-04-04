namespace ComputerStore.Class
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int OrderCount { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
