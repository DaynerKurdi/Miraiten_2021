// GENERATED AUTOMATICALLY FROM 'Assets/02_INPUT_ACTIONS/inputTest.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputTest : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputTest()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""inputTest"",
    ""maps"": [
        {
            ""name"": ""test"",
            ""id"": ""9fdda555-7730-4bd3-9acb-831cba1fba1b"",
            ""actions"": [
                {
                    ""name"": ""action"",
                    ""type"": ""Button"",
                    ""id"": ""55c486b9-7443-484a-86ad-b672e3e6b363"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b7db1d18-349f-49a8-86f6-8e8867004199"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // test
        m_test = asset.FindActionMap("test", throwIfNotFound: true);
        m_test_action = m_test.FindAction("action", throwIfNotFound: true);
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

    // test
    private readonly InputActionMap m_test;
    private ITestActions m_TestActionsCallbackInterface;
    private readonly InputAction m_test_action;
    public struct TestActions
    {
        private @InputTest m_Wrapper;
        public TestActions(@InputTest wrapper) { m_Wrapper = wrapper; }
        public InputAction @action => m_Wrapper.m_test_action;
        public InputActionMap Get() { return m_Wrapper.m_test; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestActions set) { return set.Get(); }
        public void SetCallbacks(ITestActions instance)
        {
            if (m_Wrapper.m_TestActionsCallbackInterface != null)
            {
                @action.started -= m_Wrapper.m_TestActionsCallbackInterface.OnAction;
                @action.performed -= m_Wrapper.m_TestActionsCallbackInterface.OnAction;
                @action.canceled -= m_Wrapper.m_TestActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_TestActionsCallbackInterface = instance;
            if (instance != null)
            {
                @action.started += instance.OnAction;
                @action.performed += instance.OnAction;
                @action.canceled += instance.OnAction;
            }
        }
    }
    public TestActions @test => new TestActions(this);
    public interface ITestActions
    {
        void OnAction(InputAction.CallbackContext context);
    }
}
