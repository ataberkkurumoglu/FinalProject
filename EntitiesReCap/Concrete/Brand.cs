using EntitiesReCap.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesReCap.Concrete
{
    public class Brand:IEntityReCap
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
