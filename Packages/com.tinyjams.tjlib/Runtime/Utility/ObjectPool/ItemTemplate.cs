using System;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Utility.ObjectPool
{
    [Serializable]
    public struct ItemTemplate
    {
        [field: SerializeField] public string Key { get; set; }
        [field: SerializeField] public GameObject Prefab { get; set; }
        [field: SerializeField, Min(1)] public int MinPoolSize { get; set; }
    }
}