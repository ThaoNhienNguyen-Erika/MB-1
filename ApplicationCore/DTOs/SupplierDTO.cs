namespace ApplicationCore.DTOs
{
    public class SupplierDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }
        
        public string Email { get; set; }

        public AddressDTO address { get; set; }
    }
}