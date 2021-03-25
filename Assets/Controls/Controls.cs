// GENERATED AUTOMATICALLY FROM 'Assets/Controls/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""cdc919a6-895b-4fb0-a407-f662da795bbd"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""af92822e-2586-4db2-9e0a-9c2dafba6c15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""0486f05c-5aeb-4c72-949c-8cf5c6b35384"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""dbe5db5b-cd17-40af-ad4b-168a0b945db3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""82c9cc8d-1edf-49f4-8cf9-ce8fac6c1fbb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControlUp"",
                    ""type"": ""Button"",
                    ""id"": ""0605f264-f128-4708-875f-267dd06c1eda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DiscardControl"",
                    ""type"": ""Button"",
                    ""id"": ""a651bebd-3b32-49c3-a617-9e5eee994585"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""165ff629-af6f-47c2-8f65-0478729a2b97"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""7735b4fe-1e08-40a6-86bd-6fcd55e9825a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8b6aa25c-d4bf-47d4-902d-f55b8e581e0e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a10a5134-24e3-44ae-b3e0-19fbe639cc87"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d83a551-bd4e-47a9-8de9-ff08b8b412bc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d8b08a8-167a-4e90-a7c2-6e4479cc6b0e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c607d53-5b26-4587-81c8-296f765c1de6"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ControlUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eac7a5c4-ee8c-40fb-a634-cbd8d5053549"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DiscardControl"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0afe1e7-1d3d-4199-9740-93972d696ed1"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""681ee85a-962c-4c52-b012-f866cbcc3cef"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""dc173ac2-a707-44d9-a371-49edd55e83e5"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""efbd53a2-ffe4-46cd-999e-43355a6d6648"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Press"",
                    ""type"": ""Button"",
                    ""id"": ""e7aeeede-34c5-4eec-a07a-1b1d7210e57d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fd84e420-4eac-47e9-9a7c-7a822a0a52a7"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e1be93ac-6a3e-4a7c-b59e-de0cef3b073b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Press"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_MoveLeft = m_Game.FindAction("MoveLeft", throwIfNotFound: true);
        m_Game_MoveRight = m_Game.FindAction("MoveRight", throwIfNotFound: true);
        m_Game_MoveUp = m_Game.FindAction("MoveUp", throwIfNotFound: true);
        m_Game_MoveDown = m_Game.FindAction("MoveDown", throwIfNotFound: true);
        m_Game_ControlUp = m_Game.FindAction("ControlUp", throwIfNotFound: true);
        m_Game_DiscardControl = m_Game.FindAction("DiscardControl", throwIfNotFound: true);
        m_Game_Restart = m_Game.FindAction("Restart", throwIfNotFound: true);
        m_Game_Menu = m_Game.FindAction("Menu", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_MousePosition = m_Menu.FindAction("MousePosition", throwIfNotFound: true);
        m_Menu_Press = m_Menu.FindAction("Press", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_MoveLeft;
    private readonly InputAction m_Game_MoveRight;
    private readonly InputAction m_Game_MoveUp;
    private readonly InputAction m_Game_MoveDown;
    private readonly InputAction m_Game_ControlUp;
    private readonly InputAction m_Game_DiscardControl;
    private readonly InputAction m_Game_Restart;
    private readonly InputAction m_Game_Menu;
    public struct GameActions
    {
        private @Controls m_Wrapper;
        public GameActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_Game_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Game_MoveRight;
        public InputAction @MoveUp => m_Wrapper.m_Game_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_Game_MoveDown;
        public InputAction @ControlUp => m_Wrapper.m_Game_ControlUp;
        public InputAction @DiscardControl => m_Wrapper.m_Game_DiscardControl;
        public InputAction @Restart => m_Wrapper.m_Game_Restart;
        public InputAction @Menu => m_Wrapper.m_Game_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveRight;
                @MoveUp.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMoveDown;
                @ControlUp.started -= m_Wrapper.m_GameActionsCallbackInterface.OnControlUp;
                @ControlUp.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnControlUp;
                @ControlUp.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnControlUp;
                @DiscardControl.started -= m_Wrapper.m_GameActionsCallbackInterface.OnDiscardControl;
                @DiscardControl.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnDiscardControl;
                @DiscardControl.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnDiscardControl;
                @Restart.started -= m_Wrapper.m_GameActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnRestart;
                @Menu.started -= m_Wrapper.m_GameActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @ControlUp.started += instance.OnControlUp;
                @ControlUp.performed += instance.OnControlUp;
                @ControlUp.canceled += instance.OnControlUp;
                @DiscardControl.started += instance.OnDiscardControl;
                @DiscardControl.performed += instance.OnDiscardControl;
                @DiscardControl.canceled += instance.OnDiscardControl;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public GameActions @Game => new GameActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_MousePosition;
    private readonly InputAction m_Menu_Press;
    public struct MenuActions
    {
        private @Controls m_Wrapper;
        public MenuActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_Menu_MousePosition;
        public InputAction @Press => m_Wrapper.m_Menu_Press;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @MousePosition.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnMousePosition;
                @Press.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnPress;
                @Press.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnPress;
                @Press.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnPress;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Press.started += instance.OnPress;
                @Press.performed += instance.OnPress;
                @Press.canceled += instance.OnPress;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGameActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnControlUp(InputAction.CallbackContext context);
        void OnDiscardControl(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
        void OnPress(InputAction.CallbackContext context);
    }
}
