using System;

namespace SharpPatterns.Controllers
{
    public static class RandomSingleton
    {
        private static Random _random;

        public static Random Get()
        {
            lock (new object())
            {
                return _random ?? (_random = new Random());
            }
        }
    }
}