//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Projects/P01-TinyShooter/P01_Input.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace TinyJams.P01_TinyShooter.Runtime
{
    public partial class @P01_Input : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @P01_Input()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""P01_Input"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""be1ca0c0-4092-4e19-a2ca-3df8870bd7f5"",
            ""actions"": [
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""b49bc091-48e1-458c-953a-d506a156f90f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""63a9de84-eb56-445e-81a9-719cff7eb168"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""0cd1e523-d0b2-45f2-bd14-681a0be4976f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08f28c95-4e01-403b-a30b-552b27b40d22"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7815db68-69c9-4afb-be77-4bb9b4a6168d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8944abd-4307-4db4-8c00-98580f004746"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6cc2cb2-ee33-48d4-b806-b434fcaa8033"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af0953e6-01bc-410b-95dc-428d9cfb1ae2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Default
            m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
            m_Default_Left = m_Default.FindAction("Left", throwIfNotFound: true);
            m_Default_Right = m_Default.FindAction("Right", throwIfNotFound: true);
            m_Default_Fire = m_Default.FindAction("Fire", throwIfNotFound: true);
        }

        public void Dispose()
        {
            UnityEngine.Object.Destroy(asset);
        }

        public InputBinding? bindingMask
        {
            get => asset.bindingMask;
            set => asset.bindingMask = value;
        }

        public ReadOnlyArray<InputDevice>? devices
        {
            get => asset.devices;
            set => asset.devices = value;
        }

        public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

        public bool Contains(InputAction action)
        {
            return asset.Contains(action);
        }

        public IEnumerator<InputAction> GetEnumerator()
        {
            return asset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Enable()
        {
            asset.Enable();
        }

        public void Disable()
        {
            asset.Disable();
        }
        public IEnumerable<InputBinding> bindings => asset.bindings;

        public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
        {
            return asset.FindAction(actionNameOrId, throwIfNotFound);
        }
        public int FindBinding(InputBinding bindingMask, out InputAction action)
        {
            return asset.FindBinding(bindingMask, out action);
        }

        // Default
        private readonly InputActionMap m_Default;
        private IDefaultActions m_DefaultActionsCallbackInterface;
        private readonly InputAction m_Default_Left;
        private readonly InputAction m_Default_Right;
        private readonly InputAction m_Default_Fire;
        public struct DefaultActions
        {
            private @P01_Input m_Wrapper;
            public DefaultActions(@P01_Input wrapper) { m_Wrapper = wrapper; }
            public InputAction @Left => m_Wrapper.m_Default_Left;
            public InputAction @Right => m_Wrapper.m_Default_Right;
            public InputAction @Fire => m_Wrapper.m_Default_Fire;
            public InputActionMap Get() { return m_Wrapper.m_Default; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
            public void SetCallbacks(IDefaultActions instance)
            {
                if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
                {
                    @Left.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                    @Left.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                    @Left.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnLeft;
                    @Right.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                    @Right.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                    @Right.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnRight;
                    @Fire.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFire;
                    @Fire.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFire;
                    @Fire.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnFire;
                }
                m_Wrapper.m_DefaultActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Left.started += instance.OnLeft;
                    @Left.performed += instance.OnLeft;
                    @Left.canceled += instance.OnLeft;
                    @Right.started += instance.OnRight;
                    @Right.performed += instance.OnRight;
                    @Right.canceled += instance.OnRight;
                    @Fire.started += instance.OnFire;
                    @Fire.performed += instance.OnFire;
                    @Fire.canceled += instance.OnFire;
                }
            }
        }
        public DefaultActions @Default => new DefaultActions(this);
        public interface IDefaultActions
        {
            void OnLeft(InputAction.CallbackContext context);
            void OnRight(InputAction.CallbackContext context);
            void OnFire(InputAction.CallbackContext context);
        }
    }
}
