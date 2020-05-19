// GENERATED AUTOMATICALLY FROM 'Assets/CustomPackages/Jichaels2DTools/Samples/PolygonExemple/PolygonExempleAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PolygonExempleAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PolygonExempleAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PolygonExempleAction"",
    ""maps"": [
        {
            ""name"": ""Default"",
            ""id"": ""ea3bafb2-b587-4bf9-b567-0c26f7ca588b"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""24972589-df9b-4943-b595-b086bb004220"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GetSnapShot"",
                    ""type"": ""Button"",
                    ""id"": ""cad1817c-052d-4ba2-8100-a543516045ea"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ClearSnapShot"",
                    ""type"": ""Button"",
                    ""id"": ""65fd05ac-61ae-49f8-8a40-27769757ea44"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9e24cdc5-e6a8-4dc6-b154-24816c2f17f7"",
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
                    ""id"": ""4243993f-582f-4548-a62d-3ce2bd8b3707"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GetSnapShot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""536ccf05-b50a-43e7-aa4d-d5ddf5d2d96d"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ClearSnapShot"",
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
        m_Default_MousePosition = m_Default.FindAction("MousePosition", throwIfNotFound: true);
        m_Default_GetSnapShot = m_Default.FindAction("GetSnapShot", throwIfNotFound: true);
        m_Default_ClearSnapShot = m_Default.FindAction("ClearSnapShot", throwIfNotFound: true);
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

    // Default
    private readonly InputActionMap m_Default;
    private IDefaultActions m_DefaultActionsCallbackInterface;
    private readonly InputAction m_Default_MousePosition;
    private readonly InputAction m_Default_GetSnapShot;
    private readonly InputAction m_Default_ClearSnapShot;
    public struct DefaultActions
    {
        private @PolygonExempleAction m_Wrapper;
        public DefaultActions(@PolygonExempleAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_Default_MousePosition;
        public InputAction @GetSnapShot => m_Wrapper.m_Default_GetSnapShot;
        public InputAction @ClearSnapShot => m_Wrapper.m_Default_ClearSnapShot;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterface != null)
            {
                @MousePosition.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnMousePosition;
                @GetSnapShot.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGetSnapShot;
                @GetSnapShot.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGetSnapShot;
                @GetSnapShot.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnGetSnapShot;
                @ClearSnapShot.started -= m_Wrapper.m_DefaultActionsCallbackInterface.OnClearSnapShot;
                @ClearSnapShot.performed -= m_Wrapper.m_DefaultActionsCallbackInterface.OnClearSnapShot;
                @ClearSnapShot.canceled -= m_Wrapper.m_DefaultActionsCallbackInterface.OnClearSnapShot;
            }
            m_Wrapper.m_DefaultActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @GetSnapShot.started += instance.OnGetSnapShot;
                @GetSnapShot.performed += instance.OnGetSnapShot;
                @GetSnapShot.canceled += instance.OnGetSnapShot;
                @ClearSnapShot.started += instance.OnClearSnapShot;
                @ClearSnapShot.performed += instance.OnClearSnapShot;
                @ClearSnapShot.canceled += instance.OnClearSnapShot;
            }
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IDefaultActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
        void OnGetSnapShot(InputAction.CallbackContext context);
        void OnClearSnapShot(InputAction.CallbackContext context);
    }
}
