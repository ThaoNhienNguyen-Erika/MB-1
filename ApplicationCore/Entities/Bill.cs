
using System;
using ApplicationCore.Interfaces;

namespace ApplicationCore.Entities
{
    public class Bill : IAggregateRoot
    {
        public int Id { get; set; }

        public int Id_Customer { get; set; }

        public int Id_Manager { get; set; }

        public DateTime Date { get; set; }

        public int Total { get; set; }
    }
}