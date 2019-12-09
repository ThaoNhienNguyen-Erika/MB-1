using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationCore.DTOs
{
    public class BillDTO
    {
        public int Id { get; set; }

        public int Id_Customer { get; set; }

        public int Id_Manager { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int Total { get; set; }
    }
}