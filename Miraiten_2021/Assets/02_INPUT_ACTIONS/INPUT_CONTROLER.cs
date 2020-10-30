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
        },
        {
            ""name"": ""MAIN_GAME"",
            ""id"": ""f1156999-82a6-402a-8097-7d3b804dc349"",
            ""actions"": [
                {
                    ""name"": ""CAMERA_CONTROLE"",
                    ""type"": ""Button"",
                    ""id"": ""5f586388-746c-4258-bde0-e56295613459"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""850db997-97cd-43bf-b310-9beb7e7e46d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MOUSE_POSITION"",
                    ""type"": ""Value"",
                    ""id"": ""45fb86b1-51b9-4812-aae3-5be935b4614f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""449fd7d9-cea2-4242-a469-ed5e9279a923"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fa7c224a-68ea-4caf-af99-560951849279"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""07d2e0dd-2e1d-46a2-a6b8-35640a96735d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f1cb560d-28e5-4c18-90a2-23e80f4c2b66"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3b44e51f-0a6e-4211-aaf5-be60b14028ab"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ARROW"",
                    ""id"": ""d24cbf98-a74f-4589-ad90-5aff8af906f7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""81de6591-10ca-41c4-85ab-f908d0642841"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ccf6f899-87c6-4936-9927-707bef69f919"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6bf37deb-57b0-4066-aa66-befa11ffa0ac"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""eeecbf9d-da19-491d-a5cf-f82695e05c0b"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CAMERA_CONTROLE"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a32dbf65-013d-4cfe-8537-e0453779217c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""183ff55e-d75d-47fd-baf0-e3a588c28571"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MOUSE_POSITION"",
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
        // MAIN_GAME
        m_MAIN_GAME = asset.FindActionMap("MAIN_GAME", throwIfNotFound: true);
        m_MAIN_GAME_CAMERA_CONTROLE = m_MAIN_GAME.FindAction("CAMERA_CONTROLE", throwIfNotFound: true);
        m_MAIN_GAME_Action = m_MAIN_GAME.FindAction("Action", throwIfNotFound: true);
        m_MAIN_GAME_MOUSE_POSITION = m_MAIN_GAME.FindAction("MOUSE_POSITION", throwIfNotFound: true);
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

    // MAIN_GAME
    private readonly InputActionMap m_MAIN_GAME;
    private IMAIN_GAMEActions m_MAIN_GAMEActionsCallbackInterface;
    private readonly InputAction m_MAIN_GAME_CAMERA_CONTROLE;
    private readonly InputAction m_MAIN_GAME_Action;
    private readonly InputAction m_MAIN_GAME_MOUSE_POSITION;
    public struct MAIN_GAMEActions
    {
        private @INPUT_CONTROLER m_Wrapper;
        public MAIN_GAMEActions(@INPUT_CONTROLER wrapper) { m_Wrapper = wrapper; }
        public InputAction @CAMERA_CONTROLE => m_Wrapper.m_MAIN_GAME_CAMERA_CONTROLE;
        public InputAction @Action => m_Wrapper.m_MAIN_GAME_Action;
        public InputAction @MOUSE_POSITION => m_Wrapper.m_MAIN_GAME_MOUSE_POSITION;
        public InputActionMap Get() { return m_Wrapper.m_MAIN_GAME; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MAIN_GAMEActions set) { return set.Get(); }
        public void SetCallbacks(IMAIN_GAMEActions instance)
        {
            if (m_Wrapper.m_MAIN_GAMEActionsCallbackInterface != null)
            {
                @CAMERA_CONTROLE.started -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnCAMERA_CONTROLE;
                @CAMERA_CONTROLE.performed -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnCAMERA_CONTROLE;
                @CAMERA_CONTROLE.canceled -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnCAMERA_CONTROLE;
                @Action.started -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnAction;
                @MOUSE_POSITION.started -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnMOUSE_POSITION;
                @MOUSE_POSITION.performed -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnMOUSE_POSITION;
                @MOUSE_POSITION.canceled -= m_Wrapper.m_MAIN_GAMEActionsCallbackInterface.OnMOUSE_POSITION;
            }
            m_Wrapper.m_MAIN_GAMEActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CAMERA_CONTROLE.started += instance.OnCAMERA_CONTROLE;
                @CAMERA_CONTROLE.performed += instance.OnCAMERA_CONTROLE;
                @CAMERA_CONTROLE.canceled += instance.OnCAMERA_CONTROLE;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
                @MOUSE_POSITION.started += instance.OnMOUSE_POSITION;
                @MOUSE_POSITION.performed += instance.OnMOUSE_POSITION;
                @MOUSE_POSITION.canceled += instance.OnMOUSE_POSITION;
            }
        }
    }
    public MAIN_GAMEActions @MAIN_GAME => new MAIN_GAMEActions(this);
    public interface ITITLE_MENUActions
    {
        void OnSELECTION(InputAction.CallbackContext context);
        void OnDECISON(InputAction.CallbackContext context);
    }
    public interface IMAIN_GAMEActions
    {
        void OnCAMERA_CONTROLE(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
        void OnMOUSE_POSITION(InputAction.CallbackContext context);
    }
}
