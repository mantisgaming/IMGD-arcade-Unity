//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Scenes/Controls.inputactions
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

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Core"",
            ""id"": ""f2f94a7d-3da5-4bb9-a2d1-8c366958b6c7"",
            ""actions"": [
                {
                    ""name"": ""B11"",
                    ""type"": ""Button"",
                    ""id"": ""4bfe9ada-d4bc-423e-bea4-65c8d8ba5daf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B3"",
                    ""type"": ""Button"",
                    ""id"": ""735b7995-b7f5-4c67-b920-7ea587507e7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B4"",
                    ""type"": ""Button"",
                    ""id"": ""55ce10fa-c7da-4d15-86f0-85c88f4a5818"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B1"",
                    ""type"": ""Button"",
                    ""id"": ""9d0c5a63-4910-463e-a799-06819024b590"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""JoystickX"",
                    ""type"": ""Value"",
                    ""id"": ""0fe43344-c370-4715-9682-3926e79e56a9"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Trackball"",
                    ""type"": ""Value"",
                    ""id"": ""832c62cd-3332-44b2-9b88-8be9ff862706"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""JoystickY"",
                    ""type"": ""Value"",
                    ""id"": ""d67caaf7-a28c-4144-ac2c-e74afe95c24b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0547f41f-2dbf-4589-a7cc-5e22e180f726"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B11"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""744dc3ef-a2ab-41cb-89dd-bb329e602d75"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B11"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c85078c5-182a-4aaa-a3df-48bf1cf68d58"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""316887f8-03be-40f0-a138-b6eca148e832"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64f26460-6723-448c-af5d-731bcdf8bd20"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fbb77706-4440-452c-acd9-bc60cddc3f79"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d31aa10-c570-4777-af14-0b39dc275ff1"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trackball"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cc8e5e20-054c-43c4-aa03-965f69093783"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""035d7290-05e9-4ad4-a331-b0ebc9939e96"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e76f1111-6506-46d0-abae-ade359c7e00d"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b1a4c2e7-5c6b-4d11-af6a-b5f46fb44a60"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e4220c73-8688-4dee-af0a-258e60208da7"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""276df5b0-b8af-4bab-a6ac-8a451c3951e0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8dadf603-7bfa-44c1-810d-a19343b5d9d3"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""00dbdca3-4bdf-4cd0-9de8-a7250cfc1055"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""JoystickY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4ae1455e-2606-4970-b39c-5176f24f8e94"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce2115bc-8e4d-4dce-99d9-5ff7b9afca23"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Core
        m_Core = asset.FindActionMap("Core", throwIfNotFound: true);
        m_Core_B11 = m_Core.FindAction("B11", throwIfNotFound: true);
        m_Core_B3 = m_Core.FindAction("B3", throwIfNotFound: true);
        m_Core_B4 = m_Core.FindAction("B4", throwIfNotFound: true);
        m_Core_B1 = m_Core.FindAction("B1", throwIfNotFound: true);
        m_Core_JoystickX = m_Core.FindAction("JoystickX", throwIfNotFound: true);
        m_Core_Trackball = m_Core.FindAction("Trackball", throwIfNotFound: true);
        m_Core_JoystickY = m_Core.FindAction("JoystickY", throwIfNotFound: true);
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

    // Core
    private readonly InputActionMap m_Core;
    private List<ICoreActions> m_CoreActionsCallbackInterfaces = new List<ICoreActions>();
    private readonly InputAction m_Core_B11;
    private readonly InputAction m_Core_B3;
    private readonly InputAction m_Core_B4;
    private readonly InputAction m_Core_B1;
    private readonly InputAction m_Core_JoystickX;
    private readonly InputAction m_Core_Trackball;
    private readonly InputAction m_Core_JoystickY;
    public struct CoreActions
    {
        private @Controls m_Wrapper;
        public CoreActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @B11 => m_Wrapper.m_Core_B11;
        public InputAction @B3 => m_Wrapper.m_Core_B3;
        public InputAction @B4 => m_Wrapper.m_Core_B4;
        public InputAction @B1 => m_Wrapper.m_Core_B1;
        public InputAction @JoystickX => m_Wrapper.m_Core_JoystickX;
        public InputAction @Trackball => m_Wrapper.m_Core_Trackball;
        public InputAction @JoystickY => m_Wrapper.m_Core_JoystickY;
        public InputActionMap Get() { return m_Wrapper.m_Core; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CoreActions set) { return set.Get(); }
        public void AddCallbacks(ICoreActions instance)
        {
            if (instance == null || m_Wrapper.m_CoreActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CoreActionsCallbackInterfaces.Add(instance);
            @B11.started += instance.OnB11;
            @B11.performed += instance.OnB11;
            @B11.canceled += instance.OnB11;
            @B3.started += instance.OnB3;
            @B3.performed += instance.OnB3;
            @B3.canceled += instance.OnB3;
            @B4.started += instance.OnB4;
            @B4.performed += instance.OnB4;
            @B4.canceled += instance.OnB4;
            @B1.started += instance.OnB1;
            @B1.performed += instance.OnB1;
            @B1.canceled += instance.OnB1;
            @JoystickX.started += instance.OnJoystickX;
            @JoystickX.performed += instance.OnJoystickX;
            @JoystickX.canceled += instance.OnJoystickX;
            @Trackball.started += instance.OnTrackball;
            @Trackball.performed += instance.OnTrackball;
            @Trackball.canceled += instance.OnTrackball;
            @JoystickY.started += instance.OnJoystickY;
            @JoystickY.performed += instance.OnJoystickY;
            @JoystickY.canceled += instance.OnJoystickY;
        }

        private void UnregisterCallbacks(ICoreActions instance)
        {
            @B11.started -= instance.OnB11;
            @B11.performed -= instance.OnB11;
            @B11.canceled -= instance.OnB11;
            @B3.started -= instance.OnB3;
            @B3.performed -= instance.OnB3;
            @B3.canceled -= instance.OnB3;
            @B4.started -= instance.OnB4;
            @B4.performed -= instance.OnB4;
            @B4.canceled -= instance.OnB4;
            @B1.started -= instance.OnB1;
            @B1.performed -= instance.OnB1;
            @B1.canceled -= instance.OnB1;
            @JoystickX.started -= instance.OnJoystickX;
            @JoystickX.performed -= instance.OnJoystickX;
            @JoystickX.canceled -= instance.OnJoystickX;
            @Trackball.started -= instance.OnTrackball;
            @Trackball.performed -= instance.OnTrackball;
            @Trackball.canceled -= instance.OnTrackball;
            @JoystickY.started -= instance.OnJoystickY;
            @JoystickY.performed -= instance.OnJoystickY;
            @JoystickY.canceled -= instance.OnJoystickY;
        }

        public void RemoveCallbacks(ICoreActions instance)
        {
            if (m_Wrapper.m_CoreActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICoreActions instance)
        {
            foreach (var item in m_Wrapper.m_CoreActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CoreActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CoreActions @Core => new CoreActions(this);
    public interface ICoreActions
    {
        void OnB11(InputAction.CallbackContext context);
        void OnB3(InputAction.CallbackContext context);
        void OnB4(InputAction.CallbackContext context);
        void OnB1(InputAction.CallbackContext context);
        void OnJoystickX(InputAction.CallbackContext context);
        void OnTrackball(InputAction.CallbackContext context);
        void OnJoystickY(InputAction.CallbackContext context);
    }
}
