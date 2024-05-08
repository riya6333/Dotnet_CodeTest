namespace Assessment10.Models
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
      
       

        public virtual ICollection<Order> Orders { get; set; }
    }
}
