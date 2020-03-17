using System.Collections.Generic;
using UnityEngine;

namespace Jichaels.VRSDK
{

    public class JVRHandController : MonoBehaviour, IInteractionController
    {
        public JVRPlayer Player { get; private set; }
        public Transform Transform { get; private set; }
        public VRControllerModule VrControllerModule { get; set; }
        public bool HasModule { get; private set; }
        public Vector3 CurrentPositionWorld { get; private set; }
        public Vector3 CurrentPositionLocal { get; private set; }
        private Vector3 _previousPositionLocal;
        private Vector3 _previousPositionWorld;
        public Vector3 DeltaPositionWorld => CurrentPositionWorld - _previousPositionWorld;
        public Vector3 DeltaPositionLocal => CurrentPositionLocal - _previousPositionLocal;
        public float Grip { get; set; }
        public float Trigger { get; set; }

        public bool IsGrabbing { get; private set; }
        public IJVRHandInteract Grabbed { get; private set; }

        [SerializeField] private GameObject handModel;
        private Renderer _handModelRenderer;

        [Header("Physic calculation")]
        [SerializeField] private float raycastRadius;
        [SerializeField] private Vector3 raycastOffset;
        [SerializeField] private LayerMask layerMask;
        private readonly Collider[] _hit = new Collider[8];
        private readonly List<IJVRHandInteract> _hitInteractions = new List<IJVRHandInteract>();

        private Color _initialColor;
        private readonly Color _handColor = Color.green;
        private bool _showHandModel = true;

        [SerializeField] private Animator handModelAnimator;

        private static readonly int BaseColor = Shader.PropertyToID("_BaseColor");
        private static readonly int Flex = Animator.StringToHash("Flex");

        private IJVRHandInteract _currentInteraction;
        private bool _isInteracting;

        public void InitializeController(JVRPlayer jvrPlayer)
        {
            Player = jvrPlayer;
            
            Player.OnToggleVR += OnToggleVR;

            _handModelRenderer = handModel.GetComponentInChildren<Renderer>();
            _initialColor = _handModelRenderer.material.GetColor(BaseColor);
            
            Transform = transform;
        }

        private void OnDestroy()
        {
            Player.OnToggleVR -= OnToggleVR;
        }

        private void OnToggleVR(bool vr)
        {
            gameObject.SetActive(vr);
        }

        public void SetModelVisibility(bool isVisible)
        {
            _showHandModel = isVisible;
            handModel.SetActive(_showHandModel);
        }

        public void UpdateController()
        {
            _previousPositionWorld = CurrentPositionWorld;
            CurrentPositionWorld = Transform.position;

            _previousPositionLocal = CurrentPositionLocal;
            CurrentPositionLocal = Transform.localPosition;

            // TODO : make handmodel an interface and call into that -> hands, avatar, controller, other...
            if (_showHandModel)
            {
                handModelAnimator.SetFloat(Flex, Trigger + Grip);
            }

            SphereCast();
        }

        public void SetGrabbedObject(IJVRHandInteract grabbed)
        {
            Grabbed = grabbed;
            IsGrabbing = true;
            SetHandColor(_initialColor);
        }

        public void StopGrabbing()
        {
            Grabbed = null;
            IsGrabbing = false;
            SetHandColor(_initialColor);
        }

        private void SphereCast()
        {

            if (IsGrabbing)
            {
                Grabbed.HandInteractionStay(this);
                return;
            }

            int hitCount = Physics.OverlapSphereNonAlloc(Transform.position + raycastOffset, raycastRadius, _hit, layerMask);

            if (hitCount == 0)
            {
                if (!_isInteracting) return;
                
                StopInteraction();
                SetHandColor(_initialColor);
            }
            else
            {

                _hitInteractions.Clear();
                bool contains = false;

                for (int i = 0; i < hitCount; i++)
                {
                    IJVRHandInteract interact = _hit[i].GetComponent<IJVRHandInteract>();
                    if (interact == null) continue;
                    
                    _hitInteractions.Add(interact);
                    
                    if (!_isInteracting) continue;
                    if (interact != _currentInteraction) continue;
                    contains = true;
                    break;
                }

                if (_hitInteractions.Count == 0)
                {
                    if (!_isInteracting) return;
                
                    StopInteraction();
                    SetHandColor(_initialColor);
                }
                else
                {
                    if (!_isInteracting)
                    {
                        StartInteraction(_hitInteractions[0]);
                        SetHandColor(_handColor);
                    }
                    else
                    {
                        if (contains)
                        {
                            _currentInteraction.HandInteractionStay(this);
                        }
                        else
                        {
                            StopInteraction();
                            StartInteraction(_hitInteractions[0]);
                            SetHandColor(_handColor);
                        }
                    }
                }
            }
        }

        private void StartInteraction(IJVRHandInteract interact)
        {
            _isInteracting = true;
            _currentInteraction = interact;
            _currentInteraction.HandInteractionStart(this);
        }

        private void StopInteraction()
        {
            _isInteracting = false;
            _currentInteraction.HandInteractionStop(this);
            _currentInteraction = null;
        }

        private void SetHandColor(Color color)
        {
            if(!_showHandModel) return;
            
            _handModelRenderer.material.SetColor(BaseColor, color);
        }

        public void SetModule(VRControllerModule module)
        {
            if (HasModule)
            {
                Destroy(VrControllerModule.gameObject);
                HasModule = false;
                VrControllerModule = null;
            }

            if (module == null) return;
            
            VrControllerModule = Instantiate(module, Transform);
            HasModule = true;
        }

        public void PrimaryAction()
        {
            if (!HasModule) return;
            VrControllerModule.PrimaryAction();
        }

        public void SecondaryAction()
        {
            if (!HasModule) return;
            VrControllerModule.SecondaryAction();
        }

    }
}