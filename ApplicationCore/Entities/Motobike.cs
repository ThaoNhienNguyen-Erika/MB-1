namespace ApplicationCore.Entities
{
    public class Motobike : Product
    {
        public string Color { get; set; }

        public string Type { get; set; }
        
        public int Id_Supplier { get; set; }
    }
}