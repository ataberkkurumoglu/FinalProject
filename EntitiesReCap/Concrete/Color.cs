
using CoreReCap.EntitiesReCap;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntitiesReCap.Concrete
{
    public class Color:IEntityReCap
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
