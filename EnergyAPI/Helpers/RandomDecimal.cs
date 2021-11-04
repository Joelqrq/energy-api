using System;
namespace EnergyAPI.Helpers
{
    public static class RandomDecimal
    {
        public static decimal NextDecimal(this Random rng, byte scale = 1)
        {
            return new decimal(rng.Next(20000),
                               0,
                               0,
                               false,
                               scale);
        }
    }
}
