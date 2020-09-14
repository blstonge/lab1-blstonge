using System;

namespace baseball
{
    public class Curveball : IPitch
    {
        public void Pitch()
        {
            Console.WriteLine("A 80 mph curveball was thrown.");
        }
    }
}