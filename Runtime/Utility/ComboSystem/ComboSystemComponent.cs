using System;
using UnityEngine;
using UnityEngine.Events;

namespace com.tinyjams.tjlib.Runtime.Utility.ComboSystem
{
    [Serializable] public class ComboInputUEvent : UnityEvent<string, string, ICombo> {}
    [Serializable] public class ComboPerformedUEvent : UnityEvent<string, ComboAction> {}
    [Serializable] public class ComboAbortedUEvent : UnityEvent<string, string> {}

    public class ComboSystemComponent : MonoBehaviour
    {
        [SerializeField] private ComboTemplate combos;
        [SerializeField] private ComboInputUEvent onInputReceived;
        [SerializeField] private ComboPerformedUEvent onComboComplete;
        [SerializeField] private ComboAbortedUEvent onComboAborted;

        private string currentInput;
        
        public void AddInput(string s)
        {
            var inputBefore = this.currentInput;
            this.currentInput += s;
            if (this.combos.FindCombo(this.currentInput, out var action))
            {
                this.onInputReceived.Invoke(inputBefore, s, action);
                
                if(action.IsAction())
                {
                    this.onComboComplete.Invoke(this.currentInput, (ComboAction) action);
                    this.currentInput = string.Empty;
                }
            }
            else
            {
                this.onComboAborted.Invoke(inputBefore, s);
                this.currentInput = string.Empty;
            }
        }

        public void Abort()
        {
            this.onComboAborted.Invoke(this.currentInput, string.Empty);
            this.currentInput = string.Empty;
        }

        public void SetComboTemplate(ComboTemplate newCombos, bool reset = true)
        {
            this.combos = newCombos;

            if (reset)
            {
                this.currentInput = string.Empty;
            }
        }
    }
}