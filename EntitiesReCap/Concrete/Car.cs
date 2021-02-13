
using CoreReCap.EntitiesReCap;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesReCap.Concrete
{
    public class Car : IEntityReCap
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
