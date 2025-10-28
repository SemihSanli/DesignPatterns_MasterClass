namespace ObserverDesignPattern.DAL.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountAmount { get; set; }
        public bool DiscountStatus{ get; set; }
    }
}
