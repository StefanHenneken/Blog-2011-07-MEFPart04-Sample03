using System;
using CarContract;

namespace CarBMW
{
    [Car(Name="BMW", Color=CarColor.Black, Price=55000)]
    public class BMW : ICarContract
    {
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the BMW.", name);
        }
    }
}
