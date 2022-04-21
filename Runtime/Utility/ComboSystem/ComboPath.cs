using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Utility.ComboSystem
{
    [Serializable]
    public class ComboPath : ICombo
    {
        [SerializeField] public string Key;
        [SerializeField] public List<ComboPath> Paths = new();
        [SerializeField] public List<ComboAction> Actions = new();

        public bool IsAction()
        {
            return false;
        }

        public bool TryGetSubCombo(string input, out ICombo result)
        {
            result = this.Actions.FirstOrDefault(x => x.Key == input);
            
            if (result != null)
            {
                return true;
            }

            result = this.Paths.FirstOrDefault(x => x.Key == input);

            return result != null;
        }
    }
}