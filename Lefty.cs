using System;

namespace baseball
{
    public class Lefty : Pitcher
    {
        public Lefty()
        {
            Throws = "Left";
            SetPitchBehavior(new Curveball()); 
        }

    }
}