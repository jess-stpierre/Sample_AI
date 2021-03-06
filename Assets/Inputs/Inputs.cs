// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Inputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""bdc27aba-fc97-41f8-9fa4-60cd7ce39421"",
            ""actions"": [
                {
                    ""name"": ""Forwards"",
                    ""type"": ""Button"",
                    ""id"": ""759bffef-c942-4842-9f20-44bd51123c59"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Backwards"",
                    ""type"": ""Button"",
                    ""id"": ""1bbebd86-4c69-4917-b687-6d1006434ab6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""f4b51eef-bba9-41d8-b3c2-f8a3f0e25eda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VirtualMouseTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""dbd88548-195e-4317-90a3-ad76365dc1ac"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0621db94-323a-45b4-9a34-13ccb023183e"",
                    ""path"": ""<Keyboard>/#(W)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""948329b3-d0fb-4677-8e59-5871ca65b69b"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b11e2b0-e39d-4891-bac0-1a75c6218ddb"",
                    ""path"": ""<Keyboard>/#(S)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f179d04-4cd8-4d09-bdfe-3cecbeecdcb6"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Backwards"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7d1739e3-04a5-4c72-9d1b-4070723156cc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8a1022e9-3d9d-4c24-ab7d-96d17e33f6eb"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8336d24-ec01-449c-83f2-967c6c8666ed"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VirtualMouseTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Forwards = m_Player.FindAction("Forwards", throwIfNotFound: true);
        m_Player_Backwards = m_Player.FindAction("Backwards", throwIfNotFound: true);
        m_Player_Attack = m_Player.FindAction("Attack", throwIfNotFound: true);
        m_Player_VirtualMouseTrigger = m_Player.FindAction("VirtualMouseTrigger", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Forwards;
    private readonly InputAction m_Player_Backwards;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_VirtualMouseTrigger;
    public struct PlayerActions
    {
        private @Inputs m_Wrapper;
        public PlayerActions(@Inputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Forwards => m_Wrapper.m_Player_Forwards;
        public InputAction @Backwards => m_Wrapper.m_Player_Backwards;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @VirtualMouseTrigger => m_Wrapper.m_Player_VirtualMouseTrigger;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Forwards.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnForwards;
                @Forwards.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnForwards;
                @Forwards.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnForwards;
                @Backwards.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwards;
                @Backwards.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwards;
                @Backwards.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackwards;
                @Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                @VirtualMouseTrigger.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVirtualMouseTrigger;
                @VirtualMouseTrigger.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVirtualMouseTrigger;
                @VirtualMouseTrigger.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnVirtualMouseTrigger;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Forwards.started += instance.OnForwards;
                @Forwards.performed += instance.OnForwards;
                @Forwards.canceled += instance.OnForwards;
                @Backwards.started += instance.OnBackwards;
                @Backwards.performed += instance.OnBackwards;
                @Backwards.canceled += instance.OnBackwards;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
                @VirtualMouseTrigger.started += instance.OnVirtualMouseTrigger;
                @VirtualMouseTrigger.performed += instance.OnVirtualMouseTrigger;
                @VirtualMouseTrigger.canceled += instance.OnVirtualMouseTrigger;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnForwards(InputAction.CallbackContext context);
        void OnBackwards(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnVirtualMouseTrigger(InputAction.CallbackContext context);
    }
}
