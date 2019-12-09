namespace ApplicationCore.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }
        
        public string Email { get; set; }

        public AddressDTO address { get; set; }
    }
}