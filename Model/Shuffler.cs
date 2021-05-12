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
                n--;
                int k = Random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
