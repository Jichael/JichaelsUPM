using System;
using UnityEngine;
namespace Jichaels.VRSDK
{
    public class CursorManager : MonoBehaviour
    {
        public static CursorManager Instance { get; private set; }
        
        public bool IsLocked { get; private set; }

        [SerializeField] private CursorBase defaultCursor;
        [SerializeField] private CursorBase zoomCursor;
        [SerializeField] private CursorBase handCursor;
        [SerializeField] private CursorBase informationCursor;
        
        public bool ShowHint { get; set; }

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
        }

        public void SetCursorPosition(Vector3 position)
        {
            _currentCursor.transform.position = position;
        }

        public void SetClickState(bool clickState)
        {
            _currentCursor.SetClickState(clickState);
        }

        public void SetCursor(CursorType cursorType, string hintText = null)
        {
            _currentCursor.HideCursor();
            _currentCursor = CursorTypeToCursor(cursorType);
            if (string.Equals(hintText, null))
            {
                _currentCursor.HideHint();
            }
            else
            {
                if(ShowHint) _currentCursor.ShowHint(hintText);
            }
            _currentCursor.ShowCursor();
        }

        public void ResetDefaultCursor()
        {
            SetCursor(CursorType.Default);
        }

        public void SetLockState(bool isLocked)
        {
            if (IsLocked == isLocked) return;
            
            IsLocked = isLocked;
            Cursor.lockState = IsLocked ? CursorLockMode.Locked : CursorLockMode.None; // TODO : in the option menu, chose between confined and none
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
}