// GENERATED AUTOMATICALLY FROM 'Assets/InputControls/Controls.inputactions'

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
            ""name"": ""PlayerMap"",
            ""id"": ""a41ce092-05d6-4fd1-b96f-efaf4708b36d"",
            ""actions"": [
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""f3622c85-50c0-4f6f-bc47-d5233cbaa7a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleMenu"",
                    ""type"": ""Button"",
                    ""id"": ""0cfdebd8-5a2f-4e9f-9991-50a30d008adf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ToggleChat"",
                    ""type"": ""Button"",
                    ""id"": ""b5095ab9-6ea0-4534-8ada-a74a747dcd7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""42c62bd8-e7ea-44e7-b304-9d37726c2847"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StartJumping"",
                    ""type"": ""Button"",
                    ""id"": ""31f373f8-bde3-47a1-ae3c-80d6c5b1ecc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""StopJumping"",
                    ""type"": ""Button"",
                    ""id"": ""d77cd023-e99a-4715-912b-2d4d078d71e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""StartFireing"",
                    ""type"": ""Button"",
                    ""id"": ""002dfab8-4fb1-4c48-8046-a205341dd9f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""StopFireing"",
                    ""type"": ""Button"",
                    ""id"": ""b4d0f5bf-2b65-4b65-9a5d-0a286f250592"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""StartCrouching"",
                    ""type"": ""Button"",
                    ""id"": ""d6e5a7e5-6af4-4b13-9959-e30540c2a361"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""StopCrouching"",
                    ""type"": ""Button"",
                    ""id"": ""c792c988-4a1f-44dc-bb3d-59ec866f2935"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0732a1db-06ad-494f-86ed-e77ba1e82a2c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d5a5cabe-66ba-4ea9-acad-776405cb558e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69d3ec8b-71d4-4801-8a67-1b493ddf51a8"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44c3c0ca-0b90-4c89-987f-2ed070daebfd"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c59a9720-caae-44bc-beaa-a81e863dcb0c"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartFireing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14d4f999-ec7e-43c8-9f1f-9ee374a4c0c7"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartFireing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9a45785-f247-4d2b-ba3b-f7bb09eaccb6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartJumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24f25e6b-1e97-44a8-9a06-ecb848a8305e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartJumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a17019d2-eec3-4095-8abe-3f6b44c3ec60"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartCrouching"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e6149c9-72ad-40c6-8eae-f3ad9a15c6d7"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StartCrouching"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""A and D"",
                    ""id"": ""32494177-902f-4597-b58b-4638d72bb992"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b712cc3b-e730-49ba-b519-f3d802f91e0f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""37134ec6-2d70-4b06-9ad8-a43dad13fcb0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""b834aeea-0de8-4a26-ae14-900c91a9f60d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a695a1ad-50dd-49a5-ad45-1ef0b91a3515"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3fbad599-0a22-427d-9809-631a8c24d263"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1ee4dad1-a8db-4421-ad7e-31e86a9bd9c3"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleChat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4a9e596-2433-4a7e-9b8d-4d461a24495c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopCrouching"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c6ca728-f2ea-458e-b126-e7080506fda4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopCrouching"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""797ed4c3-45f2-4aeb-b13a-785cd10f4d6d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopJumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28782893-0c29-4946-a963-8821c240c355"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopJumping"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8eec523-8cd8-4e20-8d5e-b63a3bd8a871"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopFireing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""852236ea-e990-482c-b367-bce5f618c1e2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""StopFireing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e16de39-c928-424b-9cd7-51e110e8406c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TestMap"",
            ""id"": ""a93504b1-f221-454c-8ec2-698b5d8c5691"",
            ""actions"": [
                {
                    ""name"": ""Test"",
                    ""type"": ""Button"",
                    ""id"": ""bd15ed7e-3130-4e29-9491-b37880436030"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2826db5e-71c5-4961-8615-a4f4a2981afd"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": ""Press(behavior=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Test"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RebindingMap"",
            ""id"": ""1bc7143a-04be-41e6-83e8-6d24d6188752"",
            ""actions"": [
                {
                    ""name"": ""CancelRebind"",
                    ""type"": ""Button"",
                    ""id"": ""baa66884-8add-445e-9031-dddbc0e54c2d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2bce5370-1ada-4158-bd7f-77da62ac258b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CancelRebind"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMap
        m_PlayerMap = asset.FindActionMap("PlayerMap", throwIfNotFound: true);
        m_PlayerMap_Confirm = m_PlayerMap.FindAction("Confirm", throwIfNotFound: true);
        m_PlayerMap_ToggleMenu = m_PlayerMap.FindAction("ToggleMenu", throwIfNotFound: true);
        m_PlayerMap_ToggleChat = m_PlayerMap.FindAction("ToggleChat", throwIfNotFound: true);
        m_PlayerMap_Move = m_PlayerMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerMap_StartJumping = m_PlayerMap.FindAction("StartJumping", throwIfNotFound: true);
        m_PlayerMap_StopJumping = m_PlayerMap.FindAction("StopJumping", throwIfNotFound: true);
        m_PlayerMap_StartFireing = m_PlayerMap.FindAction("StartFireing", throwIfNotFound: true);
        m_PlayerMap_StopFireing = m_PlayerMap.FindAction("StopFireing", throwIfNotFound: true);
        m_PlayerMap_StartCrouching = m_PlayerMap.FindAction("StartCrouching", throwIfNotFound: true);
        m_PlayerMap_StopCrouching = m_PlayerMap.FindAction("StopCrouching", throwIfNotFound: true);
        m_PlayerMap_Interact = m_PlayerMap.FindAction("Interact", throwIfNotFound: true);
        // TestMap
        m_TestMap = asset.FindActionMap("TestMap", throwIfNotFound: true);
        m_TestMap_Test = m_TestMap.FindAction("Test", throwIfNotFound: true);
        // RebindingMap
        m_RebindingMap = asset.FindActionMap("RebindingMap", throwIfNotFound: true);
        m_RebindingMap_CancelRebind = m_RebindingMap.FindAction("CancelRebind", throwIfNotFound: true);
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

    // PlayerMap
    private readonly InputActionMap m_PlayerMap;
    private IPlayerMapActions m_PlayerMapActionsCallbackInterface;
    private readonly InputAction m_PlayerMap_Confirm;
    private readonly InputAction m_PlayerMap_ToggleMenu;
    private readonly InputAction m_PlayerMap_ToggleChat;
    private readonly InputAction m_PlayerMap_Move;
    private readonly InputAction m_PlayerMap_StartJumping;
    private readonly InputAction m_PlayerMap_StopJumping;
    private readonly InputAction m_PlayerMap_StartFireing;
    private readonly InputAction m_PlayerMap_StopFireing;
    private readonly InputAction m_PlayerMap_StartCrouching;
    private readonly InputAction m_PlayerMap_StopCrouching;
    private readonly InputAction m_PlayerMap_Interact;
    public struct PlayerMapActions
    {
        private @Controls m_Wrapper;
        public PlayerMapActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm => m_Wrapper.m_PlayerMap_Confirm;
        public InputAction @ToggleMenu => m_Wrapper.m_PlayerMap_ToggleMenu;
        public InputAction @ToggleChat => m_Wrapper.m_PlayerMap_ToggleChat;
        public InputAction @Move => m_Wrapper.m_PlayerMap_Move;
        public InputAction @StartJumping => m_Wrapper.m_PlayerMap_StartJumping;
        public InputAction @StopJumping => m_Wrapper.m_PlayerMap_StopJumping;
        public InputAction @StartFireing => m_Wrapper.m_PlayerMap_StartFireing;
        public InputAction @StopFireing => m_Wrapper.m_PlayerMap_StopFireing;
        public InputAction @StartCrouching => m_Wrapper.m_PlayerMap_StartCrouching;
        public InputAction @StopCrouching => m_Wrapper.m_PlayerMap_StopCrouching;
        public InputAction @Interact => m_Wrapper.m_PlayerMap_Interact;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMapActions instance)
        {
            if (m_Wrapper.m_PlayerMapActionsCallbackInterface != null)
            {
                @Confirm.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnConfirm;
                @ToggleMenu.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnToggleMenu;
                @ToggleMenu.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnToggleMenu;
                @ToggleMenu.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnToggleMenu;
                @ToggleChat.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnToggleChat;
                @ToggleChat.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnToggleChat;
                @ToggleChat.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnToggleChat;
                @Move.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnMove;
                @StartJumping.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartJumping;
                @StartJumping.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartJumping;
                @StartJumping.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartJumping;
                @StopJumping.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopJumping;
                @StopJumping.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopJumping;
                @StopJumping.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopJumping;
                @StartFireing.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartFireing;
                @StartFireing.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartFireing;
                @StartFireing.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartFireing;
                @StopFireing.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopFireing;
                @StopFireing.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopFireing;
                @StopFireing.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopFireing;
                @StartCrouching.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartCrouching;
                @StartCrouching.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartCrouching;
                @StartCrouching.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStartCrouching;
                @StopCrouching.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopCrouching;
                @StopCrouching.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopCrouching;
                @StopCrouching.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnStopCrouching;
                @Interact.started -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerMapActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_PlayerMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @ToggleMenu.started += instance.OnToggleMenu;
                @ToggleMenu.performed += instance.OnToggleMenu;
                @ToggleMenu.canceled += instance.OnToggleMenu;
                @ToggleChat.started += instance.OnToggleChat;
                @ToggleChat.performed += instance.OnToggleChat;
                @ToggleChat.canceled += instance.OnToggleChat;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @StartJumping.started += instance.OnStartJumping;
                @StartJumping.performed += instance.OnStartJumping;
                @StartJumping.canceled += instance.OnStartJumping;
                @StopJumping.started += instance.OnStopJumping;
                @StopJumping.performed += instance.OnStopJumping;
                @StopJumping.canceled += instance.OnStopJumping;
                @StartFireing.started += instance.OnStartFireing;
                @StartFireing.performed += instance.OnStartFireing;
                @StartFireing.canceled += instance.OnStartFireing;
                @StopFireing.started += instance.OnStopFireing;
                @StopFireing.performed += instance.OnStopFireing;
                @StopFireing.canceled += instance.OnStopFireing;
                @StartCrouching.started += instance.OnStartCrouching;
                @StartCrouching.performed += instance.OnStartCrouching;
                @StartCrouching.canceled += instance.OnStartCrouching;
                @StopCrouching.started += instance.OnStopCrouching;
                @StopCrouching.performed += instance.OnStopCrouching;
                @StopCrouching.canceled += instance.OnStopCrouching;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public PlayerMapActions @PlayerMap => new PlayerMapActions(this);

    // TestMap
    private readonly InputActionMap m_TestMap;
    private ITestMapActions m_TestMapActionsCallbackInterface;
    private readonly InputAction m_TestMap_Test;
    public struct TestMapActions
    {
        private @Controls m_Wrapper;
        public TestMapActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Test => m_Wrapper.m_TestMap_Test;
        public InputActionMap Get() { return m_Wrapper.m_TestMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TestMapActions set) { return set.Get(); }
        public void SetCallbacks(ITestMapActions instance)
        {
            if (m_Wrapper.m_TestMapActionsCallbackInterface != null)
            {
                @Test.started -= m_Wrapper.m_TestMapActionsCallbackInterface.OnTest;
                @Test.performed -= m_Wrapper.m_TestMapActionsCallbackInterface.OnTest;
                @Test.canceled -= m_Wrapper.m_TestMapActionsCallbackInterface.OnTest;
            }
            m_Wrapper.m_TestMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Test.started += instance.OnTest;
                @Test.performed += instance.OnTest;
                @Test.canceled += instance.OnTest;
            }
        }
    }
    public TestMapActions @TestMap => new TestMapActions(this);

    // RebindingMap
    private readonly InputActionMap m_RebindingMap;
    private IRebindingMapActions m_RebindingMapActionsCallbackInterface;
    private readonly InputAction m_RebindingMap_CancelRebind;
    public struct RebindingMapActions
    {
        private @Controls m_Wrapper;
        public RebindingMapActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @CancelRebind => m_Wrapper.m_RebindingMap_CancelRebind;
        public InputActionMap Get() { return m_Wrapper.m_RebindingMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RebindingMapActions set) { return set.Get(); }
        public void SetCallbacks(IRebindingMapActions instance)
        {
            if (m_Wrapper.m_RebindingMapActionsCallbackInterface != null)
            {
                @CancelRebind.started -= m_Wrapper.m_RebindingMapActionsCallbackInterface.OnCancelRebind;
                @CancelRebind.performed -= m_Wrapper.m_RebindingMapActionsCallbackInterface.OnCancelRebind;
                @CancelRebind.canceled -= m_Wrapper.m_RebindingMapActionsCallbackInterface.OnCancelRebind;
            }
            m_Wrapper.m_RebindingMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CancelRebind.started += instance.OnCancelRebind;
                @CancelRebind.performed += instance.OnCancelRebind;
                @CancelRebind.canceled += instance.OnCancelRebind;
            }
        }
    }
    public RebindingMapActions @RebindingMap => new RebindingMapActions(this);
    public interface IPlayerMapActions
    {
        void OnConfirm(InputAction.CallbackContext context);
        void OnToggleMenu(InputAction.CallbackContext context);
        void OnToggleChat(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnStartJumping(InputAction.CallbackContext context);
        void OnStopJumping(InputAction.CallbackContext context);
        void OnStartFireing(InputAction.CallbackContext context);
        void OnStopFireing(InputAction.CallbackContext context);
        void OnStartCrouching(InputAction.CallbackContext context);
        void OnStopCrouching(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface ITestMapActions
    {
        void OnTest(InputAction.CallbackContext context);
    }
    public interface IRebindingMapActions
    {
        void OnCancelRebind(InputAction.CallbackContext context);
    }
}
