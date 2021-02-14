using CoreReCap.EntitiesReCap;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesReCap.Concrete
{
    public class Rentals:IEntityReCap
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public int RentDate { get; set; }
        public int ReturnDate { get; set; }
    }
}
