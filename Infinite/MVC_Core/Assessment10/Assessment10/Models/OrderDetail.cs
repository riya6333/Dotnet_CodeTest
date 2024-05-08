using Microsoft.Build.Tasks.Deployment.Bootstrapper;

namespace Assessment10.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? Quantity { get; set; }
        public float? Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
