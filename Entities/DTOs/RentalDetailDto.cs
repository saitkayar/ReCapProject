using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int Id { get; set; }
        public string CarBrand { get; set; }
        public int CarModel { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
 
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
