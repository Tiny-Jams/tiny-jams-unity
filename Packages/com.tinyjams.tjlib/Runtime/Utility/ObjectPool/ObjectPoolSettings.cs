using System.Collections.Generic;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Utility.ObjectPool
{
    [CreateAssetMenu(fileName = "ObjectPoolSettings", menuName = "ObjectPool/ObjectPoolSettings", order = 0)]
    public class ObjectPoolSettings : ScriptableObject
    {
        [SerializeField] public List<ItemTemplate> templates = new();
    }
}