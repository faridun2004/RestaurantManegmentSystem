namespace RestaurantManegmentSystem.Models
{
    public class Branch: BaseEntity
    {
        public Branch()
        {
            Workers = new();
        }
        public string Address { get; set; }
        public List<Worker> Workers { get; set; }

    }
}
