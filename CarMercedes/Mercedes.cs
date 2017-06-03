using System;
using CarContract;

namespace CarMercedes
{
    [Car(Name="Mercedes", Color=CarColor.Blue, Price=48000)]    
    public class Mercedes : ICarContract
    {
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}
