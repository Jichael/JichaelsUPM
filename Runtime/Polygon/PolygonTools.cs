using System.Collections.Generic;
using ClipperLib;
using UnityEngine;

namespace Jichaels.Tools2D
{
    public static class PolygonTools
    {

        private const int Precision = 100000;

        public static List<Vector2[]> Clip(Vector2[] subjectPoints, Vector2[] clipPoints, ClipType clipType)
        {
            return Clip(new List<Vector2[]> {subjectPoints}, new List<Vector2[]> {clipPoints}, clipType);
        }

        public static List<Vector2[]> Clip(List<Vector2[]> subjectPoints, Vector2[] clipPoints, ClipType clipType)
        {
            return Clip(subjectPoints, new List<Vector2[]> {clipPoints}, clipType);
        }

        public static List<Vector2[]> Clip(Vector2[] subjectPoints, List<Vector2[]> clipPoints, ClipType clipType)
        {
            return Clip(new List<Vector2[]> {subjectPoints}, clipPoints, clipType);
        }

        public static List<Vector2[]> Clip(List<Vector2[]> subjects, List<Vector2[]> clips, ClipType clipType)
        {
            Clipper clipper = new Clipper();

            for (int i = 0; i < subjects.Count; i++)
            {
                clipper.AddPath(Vector2ToIntPoints(subjects[i]), PolyType.ptSubject, true);
            }

            for (int i = 0; i < clips.Count; i++)
            {
                clipper.AddPath(Vector2ToIntPoints(clips[i]), PolyType.ptClip, true);
            }

            List<List<IntPoint>> intersectionPolyInt = new List<List<IntPoint>>();

            if (clipper.Execute(clipType, intersectionPolyInt, PolyFillType.pftNonZero,
                PolyFillType.pftNonZero))
            {
                List<Vector2[]> intersectionPoly = new List<Vector2[]>();
                for (int i = 0; i < intersectionPolyInt.Count; i++)
                {
                    intersectionPoly.Add(IntPointsToVector2(intersectionPolyInt[i]));
                }

                return intersectionPoly;
            }


            Debug.LogError("Clipping failed.");
            return null;

        }

        private static List<IntPoint> Vector2ToIntPoints(Vector2[] points)
        {
            List<IntPoint> intPoints = new List<IntPoint>();

            for (int i = 0; i < points.Length; i++)
            {
                intPoints.Add(new IntPoint(Mathf.RoundToInt(points[i].x * Precision),
                    Mathf.RoundToInt(points[i].y * Precision)));
            }

            return intPoints;
        }

        private static Vector2[] IntPointsToVector2(List<IntPoint> intPoints)
        {
            Vector2[] points = new Vector2[intPoints.Count];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Vector2((float) intPoints[i].X / Precision, (float) intPoints[i].Y / Precision);
            }

            return points;

        }

        public static float PolygonArea(Vector2[] points)
        {
            float area = 0;
            int n = points.Length - 1;

            for (int i = 0; i < n; i++)
            {
                area += points[i].x * points[i + 1].y - points[i].y * points[i + 1].x;
            }

            area += points[n].x * points[0].y - points[n].y * points[0].x;
            area = Mathf.Abs(area / 2);

            return area;
        }

        public static float PolygonArea(this PolygonCollider2D polygon) => PolygonArea(polygon.points);

        public static Vector2[] FixTransformBias(Vector2[] points, Transform transform)
        {
            Vector2 offSet = transform.position;
            Vector2 scale = transform.lossyScale;
            float rotation = transform.eulerAngles.z;
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = Quaternion.Euler(0, 0, rotation) * points[i] * scale + offSet;
            }

            return points;
        }

    }
}