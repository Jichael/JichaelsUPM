using System;
using Jichaels.Localization;
using UnityEngine;
namespace Jichaels.VRSDK
{
    public class CursorManager : MonoBehaviour
    {
        public static CursorManager Instance { get; private set; }
        
        public bool IsLocked { get; private set; }

        [SerializeField] private GameObject cursorCanvas;       

        [SerializeField] private CursorBase defaultCursor;
        [SerializeField] private CursorBase zoomCursor;
        [SerializeField] private CursorBase handCursor;
        [SerializeField] private CursorBase informationCursor;

        public bool ShowHint { get; set; } = true;

        private CursorBase _currentCursor;

        private void Awake()
        {
            Instance = this;

            Cursor.visible = false;
            SetLockState(false);
            IsLocked = Cursor.lockState == CursorLockMode.Locked;

            _currentCursor = defaultCursor;
            _currentCursor.HideHint();
            _currentCursor.ShowCursor();
            
            zoomCursor.HideCursor();
            handCursor.HideCursor();
            informationCursor.HideCursor();
        }

        public void SetCursorPosition(Vector3 position)
        {
            _currentCursor.transform.position = position;
        }

        public void SetClickState(bool clickState)
        {
            _currentCursor.SetClickState(clickState);
        }

        public void SetCursor(CursorInfo cursorInfo)
        {
            // Only translate once
            if (cursorInfo.TranslatedHint)
            {
                cursorInfo.TranslatedHint = false;
                cursorInfo.CursorHint = LanguageManager.Instance.RequestValue(cursorInfo.CursorHint);
            }
            SetCursor(cursorInfo.CursorType, cursorInfo.CursorHint);
        }

        private void SetCursor(CursorType cursorType, string cursorHint)
        {
            _currentCursor.HideCursor();
            _currentCursor = CursorTypeToCursor(cursorType);
            if (string.IsNullOrEmpty(cursorHint))
            {
                _currentCursor.HideHint();
            }
            else
            {
                if (ShowHint)
                {
                    _currentCursor.ShowHint(cursorHint);
                }
                else
                {
                    _currentCursor.HideHint();
                }
            }
            _currentCursor.ShowCursor();
        }

        public void ResetDefaultCursor()
        {
            SetCursor(CursorType.Default, null);
        }

        public void SetLockState(bool isLocked)
        {
            if (IsLocked == isLocked) return;
            
            IsLocked = isLocked;
            Cursor.lockState = IsLocked ? CursorLockMode.Locked : CursorLockMode.None; // TODO : in the option menu, chose between confined and none
        }

        public void SetCanvasActive(bool active)
        {
            cursorCanvas.SetActive(active);
        }

        private CursorBase CursorTypeToCursor(CursorType cursorType)
        {
            switch (cursorType)
            {
                case CursorType.Default:
                    return defaultCursor;
                case CursorType.Zoom:
                    return zoomCursor;
                case CursorType.Hand:
                    return handCursor;
                case CursorType.Information:
                    return informationCursor;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cursorType), cursorType, null);
            }
        }
        
    }
    
    public enum CursorType
    {
        Default,
        Zoom,
        Hand,
        Information // TODO : more cursor
    }

    [Serializable]
    public class CursorInfo
    {
        public CursorType CursorType;
        public string CursorHint;
        public bool TranslatedHint;
    }
}