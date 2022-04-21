using System;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Utility.ComboSystem
{
    [Serializable]
    public class ComboAction : ICombo
    {
        [SerializeField] public string Key;

        public bool IsAction()
        {
            return true;
        }
    }
}