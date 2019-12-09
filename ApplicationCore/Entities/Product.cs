using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Product : IAggregateRoot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }        
    }
}