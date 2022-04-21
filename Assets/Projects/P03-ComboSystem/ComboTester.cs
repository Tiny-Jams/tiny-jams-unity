using System;
using com.tinyjams.tjlib.Runtime.Utility.ComboSystem;
using UnityEngine;

namespace TinyJams.P03_ComboSystem
{
    public class ComboTester : MonoBehaviour
    {
        private P03_Input input;

        private ComboSystemComponent comboSystem;

        private void Awake()
        {
            this.input = new P03_Input();
            this.comboSystem = this.GetComponent<ComboSystemComponent>();
        }

        private void Start()
        {
            this.input.General.A.started += context => { this.comboSystem.AddInput("a"); };
            this.input.General.B.started += context => { this.comboSystem.AddInput("b"); };
        }

        private void OnEnable()
        {
            this.input.Enable();
        }

        private void OnDisable()
        {
            this.input.Disable();
        }
    }
}