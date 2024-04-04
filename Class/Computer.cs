namespace ComputerStore.Class
{
    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public int Salary { get; set; }
        public int MarkaId { get; set; }
        public Marka Marka { get; set; }
    }
}
