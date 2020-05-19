using UnityEngine;

namespace Jichaels.Tools2D
{
    public static class SegmentTools
    {
        
        
        // Need testing
        private static bool IntersectionPoint(Vector2 startPos1, Vector2 endPos1, Vector2 startPos2, Vector2 endPos2,
            out Vector2 intersectionPoint)
        {
            float tmp = (endPos2.x - startPos2.x) * (endPos1.y - startPos1.y) -
                        (endPos2.y - startPos2.y) * (endPos1.x - startPos1.x);

            if (Mathf.Approximately(tmp, 0))
            {
                intersectionPoint = Vector2.zero;
                return false;
            }

            float mu = ((startPos1.x - startPos2.x) * (endPos1.y - startPos1.y) -
                        (startPos1.y - startPos2.y) * (endPos1.x - startPos1.x)) / tmp;

            intersectionPoint = new Vector2(
                startPos2.x + (endPos2.x - startPos2.x) * mu,
                startPos2.y + (endPos2.y - startPos2.y) * mu
            );
            return true;
        }

        
        // Need testing
        private static bool IsPointOnSegment(Vector2 a, Vector2 b, Vector2 c)
        {

            if (b == c)
            {
                Debug.LogError("StartPos and EndPos are the same !");
                return false;
            }

            float cross = (c.y - a.y) * (b.x - a.x) - (c.x - a.x) * (b.y - a.y);
            
            if (Mathf.Abs(cross) > float.Epsilon) return false;

            float dot = (c.x - a.x) * (b.x - a.x) + (c.y - a.y) * (b.y - a.y);

            if (dot < 0) return false;

            float squaredLength = (b.x - a.x) * (b.x - a.x) + (b.y - a.y) * (b.y - a.y);
            
            return dot <= squaredLength;
        }
        
        // Need testing
        public static bool IsBetween(Vector3 a, Vector3 b, Vector3 c)
        {
            return Mathf.Approximately(Distance(a, c) + Distance(c, b), Distance(a, b));
        }

        // Same as Vector3.Distance ?
        public static float Distance(Vector3 a, Vector3 b)
        {
            return Mathf.Sqrt(Mathf.Pow(a.x - b.x, 2) + Mathf.Pow(a.y - b.y, 2));
        }

        
    }
}