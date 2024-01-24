namespace RestaurantManegmentSystem.Models
{
    public class Restaurant: BaseEntity
    {
        public Restaurant()
        {
            Branchs = new();
        }

       

        public string Address { get; set; }
        public string Phone { get; set; }

        public List<Branch> Branchs { get; set; }

    }
}
