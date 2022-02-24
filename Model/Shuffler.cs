using System;
namespace ServerMTA.Model
{
    public static class Shuffler
    {
        private static Random Random => new((int)DateTime.Now.Ticks);
        public static void Shuffle<T>(this T[] list)
        {
            int n = list.Length;
            while (n > 1)
            {
                int k = Random.Next(n--);
                (list[k], list[n]) = (list[n], list[k]);         
            }
        }
    }
}
