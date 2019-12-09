namespace ApplicationCore.Entities
{
    public class DetailBill
    {
        public int Id { get; set; }

        public int Id_Product { get; set; }

        public int Amount { get; set; }

        public decimal Price { get; set; }
    }
}