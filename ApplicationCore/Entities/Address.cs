using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Address : IAggregateRoot
    {
        public string Number { get; set; }

        public string Street { get; set; }

        public string District { get; set; }
        
        public string City { get; set; }
    }
}