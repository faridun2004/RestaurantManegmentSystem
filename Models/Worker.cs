namespace RestaurantManegmentSystem.Models
{
    public class Worker: BaseEntity, ICanDoWork
    {
       
        
        public DateTimeOffset Birthday { get; set; }
        public required string Role { get; set; }
        public virtual void DoWork()

        {    
            Console.WriteLine("I am done " + GetType().Name);
        }
    }
}
