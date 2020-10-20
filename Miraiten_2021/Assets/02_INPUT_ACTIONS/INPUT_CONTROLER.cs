// GENERATED AUTOMATICALLY FROM 'Assets/02_INPUT_ACTIONS/INPUT_CONTROLER.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @INPUT_CONTROLER : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @INPUT_CONTROLER()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""INPUT_CONTROLER"",
    ""maps"": [
        {
            ""name"": ""TITLE_MENU"",
            ""id"": ""0a1258d9-3759-4ba1-9cc6-8d13e59908c1"",
            ""actions"": [
                {
                    ""name"": ""SELECTION"",
                    ""type"": ""Button"",
                    ""id"": ""1e69a76a-c212-4b78-a7a1-70afb9e29437"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DECISON"",
                    ""type"": ""Button"",
                    ""id"": ""b6c4e4ee-6e25-4a37-9211-e26687cdf0dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WS_KEYS"",
                    ""id"": ""bcd44d10-7486-4a83-8396-f5e022c1d1d5"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SELECTION"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""17f42355-a4f0-4b88-8377-0161f464458d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SELECTION"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1953fab7-41bf-4642-9035-a1ee1fade653"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SELECTION"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ARROW_KEYS"",
                    ""id"": ""ff1d4c86-af36-493b-90cd-106b19ad6fd3"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SELECTION"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6289edd4-4b64-49ea-94a2-54fd464683c3"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SELECTION"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b8c76aeb-81fc-4413-9403-643d0e1f8f08"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SELECTION"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a0d02c79-7d17-41ef-be66-10ebec82e07f"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DECISON"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TITLE_MENU
        m_TITLE_MENU = asset.FindActionMap("TITLE_MENU", throwIfNotFound: true);
        m_TITLE_MENU_SELECTION = m_TITLE_MENU.FindAction("SELECTION", throwIfNotFound: true);
        m_TITLE_MENU_DECISON = m_TITLE_MENU.FindAction("DECISON", throwIfNotFound: true);
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

    // TITLE_MENU
    private readonly InputActionMap m_TITLE_MENU;
    private ITITLE_MENUActions m_TITLE_MENUActionsCallbackInterface;
    private readonly InputAction m_TITLE_MENU_SELECTION;
    private readonly InputAction m_TITLE_MENU_DECISON;
    public struct TITLE_MENUActions
    {
        private @INPUT_CONTROLER m_Wrapper;
        public TITLE_MENUActions(@INPUT_CONTROLER wrapper) { m_Wrapper = wrapper; }
        public InputAction @SELECTION => m_Wrapper.m_TITLE_MENU_SELECTION;
        public InputAction @DECISON => m_Wrapper.m_TITLE_MENU_DECISON;
        public InputActionMap Get() { return m_Wrapper.m_TITLE_MENU; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TITLE_MENUActions set) { return set.Get(); }
        public void SetCallbacks(ITITLE_MENUActions instance)
        {
            if (m_Wrapper.m_TITLE_MENUActionsCallbackInterface != null)
            {
                @SELECTION.started -= m_Wrapper.m_TITLE_MENUActionsCallbackInterface.OnSELECTION;
                @SELECTION.performed -= m_Wrapper.m_TITLE_MENUActionsCallbackInterface.OnSELECTION;
                @SELECTION.canceled -= m_Wrapper.m_TITLE_MENUActionsCallbackInterface.OnSELECTION;
                @DECISON.started -= m_Wrapper.m_TITLE_MENUActionsCallbackInterface.OnDECISON;
                @DECISON.performed -= m_Wrapper.m_TITLE_MENUActionsCallbackInterface.OnDECISON;
                @DECISON.canceled -= m_Wrapper.m_TITLE_MENUActionsCallbackInterface.OnDECISON;
            }
            m_Wrapper.m_TITLE_MENUActionsCallbackInterface = instance;
            if (instance != null)
            {
                @SELECTION.started += instance.OnSELECTION;
                @SELECTION.performed += instance.OnSELECTION;
                @SELECTION.canceled += instance.OnSELECTION;
                @DECISON.started += instance.OnDECISON;
                @DECISON.performed += instance.OnDECISON;
                @DECISON.canceled += instance.OnDECISON;
            }
        }
    }
    public TITLE_MENUActions @TITLE_MENU => new TITLE_MENUActions(this);
    public interface ITITLE_MENUActions
    {
        void OnSELECTION(InputAction.CallbackContext context);
        void OnDECISON(InputAction.CallbackContext context);
    }
}
