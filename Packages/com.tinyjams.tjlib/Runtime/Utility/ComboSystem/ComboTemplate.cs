using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace com.tinyjams.tjlib.Runtime.Utility.ComboSystem
{
    [CreateAssetMenu(fileName = "ComboSystem", menuName = "TinyJams/ComboSystem/Template", order = 0)]
    public class ComboTemplate : ScriptableObject
    {
        [SerializeField] private ComboPath combos;

        public bool FindCombo(string input, out ICombo action)
        {
            var currentSubCombo = this.combos;
            foreach (var i in input)
            {
                var isValid = currentSubCombo.TryGetSubCombo(i.ToString(), out var combo);

                if (!isValid)
                {
                    action = null;
                    return false;
                }

                if (combo.IsAction())
                {
                    action = combo;
                    return true;
                }

                currentSubCombo = (ComboPath) combo;
            }

            action = currentSubCombo;
            return true;
        }

        private void Reset()
        {
            this.combos = new ComboPath
            {
                Key = "root"
            };
        }
    }
}