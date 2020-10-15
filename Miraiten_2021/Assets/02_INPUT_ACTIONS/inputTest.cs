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
        },
        {
            ""name"": ""Keybord"",
            ""id"": ""c206ccb9-deb6-4dd1-b2be-481b84856066"",
            ""actions"": [
                {
                    ""name"": ""MenuControlOne"",
                    ""type"": ""Button"",
                    ""id"": ""eb878da5-75b1-4ed2-b3e4-d5f1acdaced2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MenuControlTwo"",
                    ""type"": ""Button"",
                    ""id"": ""21266d46-1703-44ee-be84-fd1ad1c86632"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Layout"",
                    ""id"": ""ed196e3f-8d83-4fb6-85a9-efd540280620"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlOne"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ddb07ba1-460c-4c69-8210-c8a7854d757b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8de6cd09-eefd-4281-b66c-ecd51df2c87e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50281fcc-cbf2-41a3-bc60-a14ac1e53951"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""22649a70-fff9-4dbe-ae91-469aea288ffb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlOne"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Layout"",
                    ""id"": ""5837d087-0094-48b6-b0b3-5f9eacdde82b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlTwo"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7f5bf7eb-8c5a-4285-bb04-d307c626fe62"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2f4d3339-a995-4368-9a16-ce9200c99acd"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3336e082-e6c6-4ed4-afc8-c64907f355bc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e05019c2-980c-4a47-96b0-12c8b9ce329b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuControlTwo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // test
        m_test = asset.FindActionMap("test", throwIfNotFound: true);
        m_test_action = m_test.FindAction("action", throwIfNotFound: true);
        // Keybord
        m_Keybord = asset.FindActionMap("Keybord", throwIfNotFound: true);
        m_Keybord_MenuControlOne = m_Keybord.FindAction("MenuControlOne", throwIfNotFound: true);
        m_Keybord_MenuControlTwo = m_Keybord.FindAction("MenuControlTwo", throwIfNotFound: true);
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

    // Keybord
    private readonly InputActionMap m_Keybord;
    private IKeybordActions m_KeybordActionsCallbackInterface;
    private readonly InputAction m_Keybord_MenuControlOne;
    private readonly InputAction m_Keybord_MenuControlTwo;
    public struct KeybordActions
    {
        private @InputTest m_Wrapper;
        public KeybordActions(@InputTest wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuControlOne => m_Wrapper.m_Keybord_MenuControlOne;
        public InputAction @MenuControlTwo => m_Wrapper.m_Keybord_MenuControlTwo;
        public InputActionMap Get() { return m_Wrapper.m_Keybord; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeybordActions set) { return set.Get(); }
        public void SetCallbacks(IKeybordActions instance)
        {
            if (m_Wrapper.m_KeybordActionsCallbackInterface != null)
            {
                @MenuControlOne.started -= m_Wrapper.m_KeybordActionsCallbackInterface.OnMenuControlOne;
                @MenuControlOne.performed -= m_Wrapper.m_KeybordActionsCallbackInterface.OnMenuControlOne;
                @MenuControlOne.canceled -= m_Wrapper.m_KeybordActionsCallbackInterface.OnMenuControlOne;
                @MenuControlTwo.started -= m_Wrapper.m_KeybordActionsCallbackInterface.OnMenuControlTwo;
                @MenuControlTwo.performed -= m_Wrapper.m_KeybordActionsCallbackInterface.OnMenuControlTwo;
                @MenuControlTwo.canceled -= m_Wrapper.m_KeybordActionsCallbackInterface.OnMenuControlTwo;
            }
            m_Wrapper.m_KeybordActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MenuControlOne.started += instance.OnMenuControlOne;
                @MenuControlOne.performed += instance.OnMenuControlOne;
                @MenuControlOne.canceled += instance.OnMenuControlOne;
                @MenuControlTwo.started += instance.OnMenuControlTwo;
                @MenuControlTwo.performed += instance.OnMenuControlTwo;
                @MenuControlTwo.canceled += instance.OnMenuControlTwo;
            }
        }
    }
    public KeybordActions @Keybord => new KeybordActions(this);
    public interface ITestActions
    {
        void OnAction(InputAction.CallbackContext context);
    }
    public interface IKeybordActions
    {
        void OnMenuControlOne(InputAction.CallbackContext context);
        void OnMenuControlTwo(InputAction.CallbackContext context);
    }
}
