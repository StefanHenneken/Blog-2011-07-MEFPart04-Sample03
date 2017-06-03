using System;
using System.ComponentModel.Composition;

namespace CarContract
{
    [MetadataAttribute]
    [AttributeUsage(AttributeTargets.Class)]
    public class CarAttribute : ExportAttribute
    {
        public CarAttribute()
            : base(typeof(ICarContract))
        {
            // set default values
            this.Name = "noName";
            this.Color = CarColor.Unkown;
            this.Price = 0;
        }

        public string Name { get; set; }
        public CarColor Color { get; set; }
        public uint Price { get; set; }
    }
}
