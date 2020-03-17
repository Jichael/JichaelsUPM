using UnityEngine;

namespace Jichaels.Core
{
    [CreateAssetMenu(fileName = "NewCursor", menuName = "Cursor")]
    public class CursorSO : ScriptableObject
    {
        public Texture2D sprite;
        public Vector2 hotSpot;
    }
}