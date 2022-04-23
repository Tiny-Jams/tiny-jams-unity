using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace com.tinyjams.tjlib.Runtime.Utility.Extensions
{
    public static class GenericListExtensions
    {
        public static T GetRandomElement<T>(this List<T> list)
        {
            var idx = Random.Range(0, list.Count);
            return list[idx];
        }
    }
}