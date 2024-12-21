

namespace RestaurantPosMAUI.Data
{
    public class Oreder
    {
        public long Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalItemsCount { get; set; }
        public decimal TotalAmountPaid { get; set; }

        public string PaymentMode { get; set; } //Cash Or Credit Card// Online

    }
}