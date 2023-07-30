//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/UIInputActions.inputactions
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

public partial class @UIInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIInputActions"",
    ""maps"": [
        {
            ""name"": ""ProgressBar"",
            ""id"": ""dfa80c2e-d1a0-496d-8e2b-d0860e6fc729"",
            ""actions"": [
                {
                    ""name"": ""Fill"",
                    ""type"": ""Button"",
                    ""id"": ""4fcdd40a-a4bc-4134-85bc-8c608964590a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""21afb497-1a31-465e-973e-28620960f9a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reset"",
                    ""type"": ""Button"",
                    ""id"": ""4e05c045-4624-4e4e-a52d-44a7c6b9370f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""81f05295-0de8-4325-8fa0-cee71ed2bae2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fill"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""18de81fe-a5cf-4cb0-8b2d-eff8e9fdbce2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5a633cc-c6de-4a33-aaca-b0b75d88031d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reset"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ProgressBar
        m_ProgressBar = asset.FindActionMap("ProgressBar", throwIfNotFound: true);
        m_ProgressBar_Fill = m_ProgressBar.FindAction("Fill", throwIfNotFound: true);
        m_ProgressBar_Quit = m_ProgressBar.FindAction("Quit", throwIfNotFound: true);
        m_ProgressBar_Reset = m_ProgressBar.FindAction("Reset", throwIfNotFound: true);
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

    // ProgressBar
    private readonly InputActionMap m_ProgressBar;
    private List<IProgressBarActions> m_ProgressBarActionsCallbackInterfaces = new List<IProgressBarActions>();
    private readonly InputAction m_ProgressBar_Fill;
    private readonly InputAction m_ProgressBar_Quit;
    private readonly InputAction m_ProgressBar_Reset;
    public struct ProgressBarActions
    {
        private @UIInputActions m_Wrapper;
        public ProgressBarActions(@UIInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fill => m_Wrapper.m_ProgressBar_Fill;
        public InputAction @Quit => m_Wrapper.m_ProgressBar_Quit;
        public InputAction @Reset => m_Wrapper.m_ProgressBar_Reset;
        public InputActionMap Get() { return m_Wrapper.m_ProgressBar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ProgressBarActions set) { return set.Get(); }
        public void AddCallbacks(IProgressBarActions instance)
        {
            if (instance == null || m_Wrapper.m_ProgressBarActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ProgressBarActionsCallbackInterfaces.Add(instance);
            @Fill.started += instance.OnFill;
            @Fill.performed += instance.OnFill;
            @Fill.canceled += instance.OnFill;
            @Quit.started += instance.OnQuit;
            @Quit.performed += instance.OnQuit;
            @Quit.canceled += instance.OnQuit;
            @Reset.started += instance.OnReset;
            @Reset.performed += instance.OnReset;
            @Reset.canceled += instance.OnReset;
        }

        private void UnregisterCallbacks(IProgressBarActions instance)
        {
            @Fill.started -= instance.OnFill;
            @Fill.performed -= instance.OnFill;
            @Fill.canceled -= instance.OnFill;
            @Quit.started -= instance.OnQuit;
            @Quit.performed -= instance.OnQuit;
            @Quit.canceled -= instance.OnQuit;
            @Reset.started -= instance.OnReset;
            @Reset.performed -= instance.OnReset;
            @Reset.canceled -= instance.OnReset;
        }

        public void RemoveCallbacks(IProgressBarActions instance)
        {
            if (m_Wrapper.m_ProgressBarActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IProgressBarActions instance)
        {
            foreach (var item in m_Wrapper.m_ProgressBarActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ProgressBarActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ProgressBarActions @ProgressBar => new ProgressBarActions(this);
    public interface IProgressBarActions
    {
        void OnFill(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnReset(InputAction.CallbackContext context);
    }
}
