//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/GameFolders/Scripts/Concretes/Inputs/DefaultActions.inputactions
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

namespace RocketGame.Input
{
    public partial class @DefaultActions : IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @DefaultActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaultActions"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""10f019cb-e857-4d9c-8eae-1afcaa844a4e"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bf0f2683-7868-4a14-b7f2-203aeb8e6d5c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5afc2433-82d7-4c17-8f2b-6d1b51ea70c2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b0fab39b-bc54-49ff-b516-f571e9c0bd80"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ddcd631c-4a9f-4a00-ba0a-391615d917cd"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""8342ed90-873d-4ea5-93ff-0ecad7690011"",
                    ""path"": ""1DAxis(minValue=-0.2,maxValue=0.2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""10a38dce-76f9-49dc-965c-c2d982b25346"",
                    ""path"": ""<Touchscreen>/delta/left"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""0eaf195b-5b95-422e-8fdd-716edaf5417d"",
                    ""path"": ""<Touchscreen>/delta/right"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""8b3c516c-4ae2-456c-9272-f94b0550f29f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""49efbd27-2861-41ea-8d18-37666d755592"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""20c389de-f14e-43c0-9e45-c74dd2a80c5a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": ""Scale"",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Rocket
            m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
            m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
            m_Rocket_LeftRight = m_Rocket.FindAction("LeftRight", throwIfNotFound: true);
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

        // Rocket
        private readonly InputActionMap m_Rocket;
        private IRocketActions m_RocketActionsCallbackInterface;
        private readonly InputAction m_Rocket_ForceUp;
        private readonly InputAction m_Rocket_LeftRight;
        public struct RocketActions
        {
            private @DefaultActions m_Wrapper;
            public RocketActions(@DefaultActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
            public InputAction @LeftRight => m_Wrapper.m_Rocket_LeftRight;
            public InputActionMap Get() { return m_Wrapper.m_Rocket; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
            public void SetCallbacks(IRocketActions instance)
            {
                if (m_Wrapper.m_RocketActionsCallbackInterface != null)
                {
                    @ForceUp.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @ForceUp.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                    @LeftRight.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                    @LeftRight.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                    @LeftRight.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                }
                m_Wrapper.m_RocketActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ForceUp.started += instance.OnForceUp;
                    @ForceUp.performed += instance.OnForceUp;
                    @ForceUp.canceled += instance.OnForceUp;
                    @LeftRight.started += instance.OnLeftRight;
                    @LeftRight.performed += instance.OnLeftRight;
                    @LeftRight.canceled += instance.OnLeftRight;
                }
            }
        }
        public RocketActions @Rocket => new RocketActions(this);
        public interface IRocketActions
        {
            void OnForceUp(InputAction.CallbackContext context);
            void OnLeftRight(InputAction.CallbackContext context);
        }
    }
}
