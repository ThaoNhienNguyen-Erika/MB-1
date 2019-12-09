using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Supplier : IAggregateRoot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Phone { get; set; }
        
        public string Email { get; set; }

        public Address address { get; set; }
    }
}