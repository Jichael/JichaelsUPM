// GENERATED AUTOMATICALLY FROM 'Assets/CustomPackages/JichaelsVR/Samples/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""JVRPlayer"",
            ""id"": ""8ee98cbc-93a2-405b-82fd-6cd7be395b81"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""579eea5d-ee19-4cf7-8586-10ea3c7f5104"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a2a8277d-b33c-4ba7-9582-3a29791ba583"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""Value"",
                    ""id"": ""b5efe267-08a0-476c-87fc-8dc011adb2a9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftControllerTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""dc9811c7-2f84-4a0f-8490-14c90d4254eb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftControllerGrip"",
                    ""type"": ""Value"",
                    ""id"": ""bb1a321d-1582-44a2-a80d-39e0c5ce6163"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightControllerTrigger"",
                    ""type"": ""Value"",
                    ""id"": ""061b3cb3-3db7-4e8a-a42f-ef153f3de057"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightControllerGrip"",
                    ""type"": ""Value"",
                    ""id"": ""b266a280-6d9c-4ab7-a443-bf969a604aef"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftControllerPrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""fa116cf3-0c86-4b77-ba22-a1789e15ca13"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""LeftControllerSecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""17784d3a-c84e-411e-af95-1d00600e4ecf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightControllerPrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""a788d525-028a-48b1-a36f-db509c18502b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""RightControllerSecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""64dec73f-c576-4852-bc3c-25c157835bc6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ActionPrimary"",
                    ""type"": ""Button"",
                    ""id"": ""f8b9f796-0577-405d-9a44-297946c0e2ab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ActionSecondary"",
                    ""type"": ""Button"",
                    ""id"": ""ed0b198d-414f-45ba-b1c8-4d65ca689b75"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""SwitchKeyboardGamepad"",
                    ""type"": ""Button"",
                    ""id"": ""d1f823d4-3243-4e7b-aa22-1076d823edad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""c4cd23d0-c459-48ef-a7e0-5ac47fe33f14"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""UserPresence"",
                    ""type"": ""PassThrough"",
                    ""id"": ""850fe795-ad8f-44aa-960a-d6c830121ac1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""7db5e3d4-6748-466f-900b-2051c21b62f2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""b05e1375-5cc8-4a36-8789-4888a437cb11"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""ResetTrackingSpace"",
                    ""type"": ""Button"",
                    ""id"": ""065f1e65-a3c5-45c0-8595-6f00d143a6a1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""OpenModuleSelector"",
                    ""type"": ""Button"",
                    ""id"": ""cc40a091-ef16-4d6e-a355-6bad9d13b8a5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""44d3f3fb-9ec9-4cdd-8267-da0014953b65"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""38f671fb-686a-430b-9a7a-12f25cbd9d50"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0ee01bcc-851c-4b99-add8-5b181ce2e7c1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""87c5b5e9-c1ed-497c-b2d9-07f6856b625e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""28eb207c-77b1-4560-bd9d-cff0a617cbee"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""41513c08-6756-4945-885c-d4bd743058f2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a5c970dd-02da-4c4e-a9b5-a12678176165"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad92a89c-3410-438a-8bf6-14875f6f4140"",
                    ""path"": ""<XRController>{RightHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""def9edf4-3a60-4bd7-a725-28be5da2e01e"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ee031ed-1f21-40b6-bff0-4dfa549ec07f"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b40ccf1e-63ae-48d8-8e3b-464153cd4022"",
                    ""path"": ""<XRController>{LeftHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""LeftControllerTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e01f12f5-57ed-4b87-9f44-0c38ce7d7f24"",
                    ""path"": ""<XRController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""LeftControllerGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14c4b62c-56d7-4285-9c13-0d080b58b981"",
                    ""path"": ""<XRController>{RightHand}/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RightControllerTrigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cb0bf28-2a53-43ab-8151-82f4c702b409"",
                    ""path"": ""<XRController>{RightHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RightControllerGrip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d176565f-dad2-4e62-a78d-104db8162f70"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""LeftControllerPrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0111bf94-8d89-42be-b86b-685e413f42ea"",
                    ""path"": ""<XRController>{LeftHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""LeftControllerSecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c7082c1-41f7-4ab5-a73a-3922a27819e6"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RightControllerPrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f793ae50-0ae4-48e1-a539-6bede10377f7"",
                    ""path"": ""<XRController>{RightHand}/secondaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""RightControllerSecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea080704-9bed-4415-8c3a-f97cfe87a853"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""ActionPrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b940d47-c4c3-4c53-9639-38b3f2e45b4c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionPrimary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe3e98a9-7dac-4fba-bfc8-17fa8c460856"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""ActionSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7250ad63-6e52-4a42-a56e-25ddfff903a7"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""ActionSecondary"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1095c75-8d9e-4f59-90d1-80e3b1b05594"",
                    ""path"": ""<Gamepad>/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""SwitchKeyboardGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4f0da3d-8a10-4c10-8df4-08023574b08a"",
                    ""path"": ""<Keyboard>/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SwitchKeyboardGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd8056fc-432c-40f4-b2fe-6a38c30dcfab"",
                    ""path"": ""<Mouse>/*"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SwitchKeyboardGamepad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3746fc7b-0f53-4fbd-8402-2d93e5cefd46"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard;VR"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4a425f0-aa69-421f-9aa8-d722a1af86eb"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c99aa7da-6ee5-4918-ad8d-1e38565675ba"",
                    ""path"": ""<XRHMD>/userPresence"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR;MouseKeyboard;Gamepad"",
                    ""action"": ""UserPresence"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44dff288-18bf-4e23-9447-8068d8a3e30a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83c54330-79ce-485a-8898-939b9cccecb5"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0813233b-b4fc-41b5-aedb-346b0f7caa55"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73730a7e-002f-4c3a-9128-3c8f91ef633e"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2431554-06dc-4b3c-bc05-fa6236f0dd78"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""ResetTrackingSpace"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cec64548-b845-4866-a5d7-6685ca26ab3a"",
                    ""path"": ""<XRController>{LeftHand}/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR"",
                    ""action"": ""OpenModuleSelector"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""653bd7b5-43a0-4123-a345-ddf942202daf"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseKeyboard"",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""VR"",
            ""bindingGroup"": ""VR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRHMD>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""MouseKeyboard"",
            ""bindingGroup"": ""MouseKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRHMD>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRHMD>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // JVRPlayer
        m_JVRPlayer = asset.FindActionMap("JVRPlayer", throwIfNotFound: true);
        m_JVRPlayer_MousePosition = m_JVRPlayer.FindAction("MousePosition", throwIfNotFound: true);
        m_JVRPlayer_Movement = m_JVRPlayer.FindAction("Movement", throwIfNotFound: true);
        m_JVRPlayer_CameraRotation = m_JVRPlayer.FindAction("CameraRotation", throwIfNotFound: true);
        m_JVRPlayer_LeftControllerTrigger = m_JVRPlayer.FindAction("LeftControllerTrigger", throwIfNotFound: true);
        m_JVRPlayer_LeftControllerGrip = m_JVRPlayer.FindAction("LeftControllerGrip", throwIfNotFound: true);
        m_JVRPlayer_RightControllerTrigger = m_JVRPlayer.FindAction("RightControllerTrigger", throwIfNotFound: true);
        m_JVRPlayer_RightControllerGrip = m_JVRPlayer.FindAction("RightControllerGrip", throwIfNotFound: true);
        m_JVRPlayer_LeftControllerPrimaryButton = m_JVRPlayer.FindAction("LeftControllerPrimaryButton", throwIfNotFound: true);
        m_JVRPlayer_LeftControllerSecondaryButton = m_JVRPlayer.FindAction("LeftControllerSecondaryButton", throwIfNotFound: true);
        m_JVRPlayer_RightControllerPrimaryButton = m_JVRPlayer.FindAction("RightControllerPrimaryButton", throwIfNotFound: true);
        m_JVRPlayer_RightControllerSecondaryButton = m_JVRPlayer.FindAction("RightControllerSecondaryButton", throwIfNotFound: true);
        m_JVRPlayer_ActionPrimary = m_JVRPlayer.FindAction("ActionPrimary", throwIfNotFound: true);
        m_JVRPlayer_ActionSecondary = m_JVRPlayer.FindAction("ActionSecondary", throwIfNotFound: true);
        m_JVRPlayer_SwitchKeyboardGamepad = m_JVRPlayer.FindAction("SwitchKeyboardGamepad", throwIfNotFound: true);
        m_JVRPlayer_Escape = m_JVRPlayer.FindAction("Escape", throwIfNotFound: true);
        m_JVRPlayer_UserPresence = m_JVRPlayer.FindAction("UserPresence", throwIfNotFound: true);
        m_JVRPlayer_Crouch = m_JVRPlayer.FindAction("Crouch", throwIfNotFound: true);
        m_JVRPlayer_Sprint = m_JVRPlayer.FindAction("Sprint", throwIfNotFound: true);
        m_JVRPlayer_ResetTrackingSpace = m_JVRPlayer.FindAction("ResetTrackingSpace", throwIfNotFound: true);
        m_JVRPlayer_OpenModuleSelector = m_JVRPlayer.FindAction("OpenModuleSelector", throwIfNotFound: true);
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

    // JVRPlayer
    private readonly InputActionMap m_JVRPlayer;
    private IJVRPlayerActions m_JVRPlayerActionsCallbackInterface;
    private readonly InputAction m_JVRPlayer_MousePosition;
    private readonly InputAction m_JVRPlayer_Movement;
    private readonly InputAction m_JVRPlayer_CameraRotation;
    private readonly InputAction m_JVRPlayer_LeftControllerTrigger;
    private readonly InputAction m_JVRPlayer_LeftControllerGrip;
    private readonly InputAction m_JVRPlayer_RightControllerTrigger;
    private readonly InputAction m_JVRPlayer_RightControllerGrip;
    private readonly InputAction m_JVRPlayer_LeftControllerPrimaryButton;
    private readonly InputAction m_JVRPlayer_LeftControllerSecondaryButton;
    private readonly InputAction m_JVRPlayer_RightControllerPrimaryButton;
    private readonly InputAction m_JVRPlayer_RightControllerSecondaryButton;
    private readonly InputAction m_JVRPlayer_ActionPrimary;
    private readonly InputAction m_JVRPlayer_ActionSecondary;
    private readonly InputAction m_JVRPlayer_SwitchKeyboardGamepad;
    private readonly InputAction m_JVRPlayer_Escape;
    private readonly InputAction m_JVRPlayer_UserPresence;
    private readonly InputAction m_JVRPlayer_Crouch;
    private readonly InputAction m_JVRPlayer_Sprint;
    private readonly InputAction m_JVRPlayer_ResetTrackingSpace;
    private readonly InputAction m_JVRPlayer_OpenModuleSelector;
    public struct JVRPlayerActions
    {
        private @PlayerControls m_Wrapper;
        public JVRPlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_JVRPlayer_MousePosition;
        public InputAction @Movement => m_Wrapper.m_JVRPlayer_Movement;
        public InputAction @CameraRotation => m_Wrapper.m_JVRPlayer_CameraRotation;
        public InputAction @LeftControllerTrigger => m_Wrapper.m_JVRPlayer_LeftControllerTrigger;
        public InputAction @LeftControllerGrip => m_Wrapper.m_JVRPlayer_LeftControllerGrip;
        public InputAction @RightControllerTrigger => m_Wrapper.m_JVRPlayer_RightControllerTrigger;
        public InputAction @RightControllerGrip => m_Wrapper.m_JVRPlayer_RightControllerGrip;
        public InputAction @LeftControllerPrimaryButton => m_Wrapper.m_JVRPlayer_LeftControllerPrimaryButton;
        public InputAction @LeftControllerSecondaryButton => m_Wrapper.m_JVRPlayer_LeftControllerSecondaryButton;
        public InputAction @RightControllerPrimaryButton => m_Wrapper.m_JVRPlayer_RightControllerPrimaryButton;
        public InputAction @RightControllerSecondaryButton => m_Wrapper.m_JVRPlayer_RightControllerSecondaryButton;
        public InputAction @ActionPrimary => m_Wrapper.m_JVRPlayer_ActionPrimary;
        public InputAction @ActionSecondary => m_Wrapper.m_JVRPlayer_ActionSecondary;
        public InputAction @SwitchKeyboardGamepad => m_Wrapper.m_JVRPlayer_SwitchKeyboardGamepad;
        public InputAction @Escape => m_Wrapper.m_JVRPlayer_Escape;
        public InputAction @UserPresence => m_Wrapper.m_JVRPlayer_UserPresence;
        public InputAction @Crouch => m_Wrapper.m_JVRPlayer_Crouch;
        public InputAction @Sprint => m_Wrapper.m_JVRPlayer_Sprint;
        public InputAction @ResetTrackingSpace => m_Wrapper.m_JVRPlayer_ResetTrackingSpace;
        public InputAction @OpenModuleSelector => m_Wrapper.m_JVRPlayer_OpenModuleSelector;
        public InputActionMap Get() { return m_Wrapper.m_JVRPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JVRPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IJVRPlayerActions instance)
        {
            if (m_Wrapper.m_JVRPlayerActionsCallbackInterface != null)
            {
                @MousePosition.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnMousePosition;
                @Movement.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnMovement;
                @CameraRotation.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnCameraRotation;
                @LeftControllerTrigger.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerTrigger;
                @LeftControllerTrigger.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerTrigger;
                @LeftControllerTrigger.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerTrigger;
                @LeftControllerGrip.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerGrip;
                @LeftControllerGrip.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerGrip;
                @LeftControllerGrip.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerGrip;
                @RightControllerTrigger.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerTrigger;
                @RightControllerTrigger.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerTrigger;
                @RightControllerTrigger.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerTrigger;
                @RightControllerGrip.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerGrip;
                @RightControllerGrip.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerGrip;
                @RightControllerGrip.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerGrip;
                @LeftControllerPrimaryButton.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerPrimaryButton;
                @LeftControllerPrimaryButton.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerPrimaryButton;
                @LeftControllerPrimaryButton.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerPrimaryButton;
                @LeftControllerSecondaryButton.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerSecondaryButton;
                @LeftControllerSecondaryButton.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerSecondaryButton;
                @LeftControllerSecondaryButton.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnLeftControllerSecondaryButton;
                @RightControllerPrimaryButton.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerPrimaryButton;
                @RightControllerPrimaryButton.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerPrimaryButton;
                @RightControllerPrimaryButton.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerPrimaryButton;
                @RightControllerSecondaryButton.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerSecondaryButton;
                @RightControllerSecondaryButton.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerSecondaryButton;
                @RightControllerSecondaryButton.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnRightControllerSecondaryButton;
                @ActionPrimary.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnActionPrimary;
                @ActionPrimary.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnActionPrimary;
                @ActionPrimary.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnActionPrimary;
                @ActionSecondary.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnActionSecondary;
                @ActionSecondary.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnActionSecondary;
                @ActionSecondary.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnActionSecondary;
                @SwitchKeyboardGamepad.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnSwitchKeyboardGamepad;
                @SwitchKeyboardGamepad.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnSwitchKeyboardGamepad;
                @SwitchKeyboardGamepad.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnSwitchKeyboardGamepad;
                @Escape.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnEscape;
                @UserPresence.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnUserPresence;
                @UserPresence.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnUserPresence;
                @UserPresence.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnUserPresence;
                @Crouch.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnCrouch;
                @Sprint.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnSprint;
                @ResetTrackingSpace.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnResetTrackingSpace;
                @ResetTrackingSpace.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnResetTrackingSpace;
                @ResetTrackingSpace.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnResetTrackingSpace;
                @OpenModuleSelector.started -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnOpenModuleSelector;
                @OpenModuleSelector.performed -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnOpenModuleSelector;
                @OpenModuleSelector.canceled -= m_Wrapper.m_JVRPlayerActionsCallbackInterface.OnOpenModuleSelector;
            }
            m_Wrapper.m_JVRPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
                @LeftControllerTrigger.started += instance.OnLeftControllerTrigger;
                @LeftControllerTrigger.performed += instance.OnLeftControllerTrigger;
                @LeftControllerTrigger.canceled += instance.OnLeftControllerTrigger;
                @LeftControllerGrip.started += instance.OnLeftControllerGrip;
                @LeftControllerGrip.performed += instance.OnLeftControllerGrip;
                @LeftControllerGrip.canceled += instance.OnLeftControllerGrip;
                @RightControllerTrigger.started += instance.OnRightControllerTrigger;
                @RightControllerTrigger.performed += instance.OnRightControllerTrigger;
                @RightControllerTrigger.canceled += instance.OnRightControllerTrigger;
                @RightControllerGrip.started += instance.OnRightControllerGrip;
                @RightControllerGrip.performed += instance.OnRightControllerGrip;
                @RightControllerGrip.canceled += instance.OnRightControllerGrip;
                @LeftControllerPrimaryButton.started += instance.OnLeftControllerPrimaryButton;
                @LeftControllerPrimaryButton.performed += instance.OnLeftControllerPrimaryButton;
                @LeftControllerPrimaryButton.canceled += instance.OnLeftControllerPrimaryButton;
                @LeftControllerSecondaryButton.started += instance.OnLeftControllerSecondaryButton;
                @LeftControllerSecondaryButton.performed += instance.OnLeftControllerSecondaryButton;
                @LeftControllerSecondaryButton.canceled += instance.OnLeftControllerSecondaryButton;
                @RightControllerPrimaryButton.started += instance.OnRightControllerPrimaryButton;
                @RightControllerPrimaryButton.performed += instance.OnRightControllerPrimaryButton;
                @RightControllerPrimaryButton.canceled += instance.OnRightControllerPrimaryButton;
                @RightControllerSecondaryButton.started += instance.OnRightControllerSecondaryButton;
                @RightControllerSecondaryButton.performed += instance.OnRightControllerSecondaryButton;
                @RightControllerSecondaryButton.canceled += instance.OnRightControllerSecondaryButton;
                @ActionPrimary.started += instance.OnActionPrimary;
                @ActionPrimary.performed += instance.OnActionPrimary;
                @ActionPrimary.canceled += instance.OnActionPrimary;
                @ActionSecondary.started += instance.OnActionSecondary;
                @ActionSecondary.performed += instance.OnActionSecondary;
                @ActionSecondary.canceled += instance.OnActionSecondary;
                @SwitchKeyboardGamepad.started += instance.OnSwitchKeyboardGamepad;
                @SwitchKeyboardGamepad.performed += instance.OnSwitchKeyboardGamepad;
                @SwitchKeyboardGamepad.canceled += instance.OnSwitchKeyboardGamepad;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
                @UserPresence.started += instance.OnUserPresence;
                @UserPresence.performed += instance.OnUserPresence;
                @UserPresence.canceled += instance.OnUserPresence;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @ResetTrackingSpace.started += instance.OnResetTrackingSpace;
                @ResetTrackingSpace.performed += instance.OnResetTrackingSpace;
                @ResetTrackingSpace.canceled += instance.OnResetTrackingSpace;
                @OpenModuleSelector.started += instance.OnOpenModuleSelector;
                @OpenModuleSelector.performed += instance.OnOpenModuleSelector;
                @OpenModuleSelector.canceled += instance.OnOpenModuleSelector;
            }
        }
    }
    public JVRPlayerActions @JVRPlayer => new JVRPlayerActions(this);
    private int m_VRSchemeIndex = -1;
    public InputControlScheme VRScheme
    {
        get
        {
            if (m_VRSchemeIndex == -1) m_VRSchemeIndex = asset.FindControlSchemeIndex("VR");
            return asset.controlSchemes[m_VRSchemeIndex];
        }
    }
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseKeyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IJVRPlayerActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnCameraRotation(InputAction.CallbackContext context);
        void OnLeftControllerTrigger(InputAction.CallbackContext context);
        void OnLeftControllerGrip(InputAction.CallbackContext context);
        void OnRightControllerTrigger(InputAction.CallbackContext context);
        void OnRightControllerGrip(InputAction.CallbackContext context);
        void OnLeftControllerPrimaryButton(InputAction.CallbackContext context);
        void OnLeftControllerSecondaryButton(InputAction.CallbackContext context);
        void OnRightControllerPrimaryButton(InputAction.CallbackContext context);
        void OnRightControllerSecondaryButton(InputAction.CallbackContext context);
        void OnActionPrimary(InputAction.CallbackContext context);
        void OnActionSecondary(InputAction.CallbackContext context);
        void OnSwitchKeyboardGamepad(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnUserPresence(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnResetTrackingSpace(InputAction.CallbackContext context);
        void OnOpenModuleSelector(InputAction.CallbackContext context);
    }
}
