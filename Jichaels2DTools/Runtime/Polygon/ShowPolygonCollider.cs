using System.Collections.Generic;
using Jichaels.Tools2D;
using UnityEngine;

namespace Jichaels.Tools2D
{
    public class ShowPolygonCollider : MonoBehaviour
    {

        public PolygonCollider2D polygon;
        [SerializeField] private PolygonPointGizmo template;
        [SerializeField] private bool showLines;
        [SerializeField] private bool showGizmos;
        [SerializeField] private bool showTexts;
        [SerializeField] private LineRenderer lineRenderer;

        public List<PolygonPointGizmo> polygonPointGizmos;

        private Vector2[] _polygonPoints;
        private Vector2 _startPoint;
        private Vector2 _endPoint;

        private void OnDrawGizmos()
        {
            Synchronize();
            DrawShapes();
        }

        private void DrawShapes()
        {
            if (_polygonPoints.Length == 0) return;

            if (lineRenderer != null) lineRenderer.positionCount = _polygonPoints.Length + 1;

            for (int i = 0; i < _polygonPoints.Length; i++)
            {
                _startPoint = _polygonPoints[i];
                _endPoint = i == _polygonPoints.Length - 1 ? _polygonPoints[0] : _polygonPoints[i + 1];

                if (lineRenderer != null) lineRenderer.SetPosition(i, _startPoint);
                else Debug.DrawLine(_startPoint, _endPoint);

                polygonPointGizmos[i].transform.position = _startPoint;
                polygonPointGizmos[i].text.text = i.ToString();

            }

            if (lineRenderer != null)
            {
                lineRenderer.SetPosition(_polygonPoints.Length, _polygonPoints[0]);
            }
        }

        private void Synchronize()
        {

            _polygonPoints = PolygonTools.FixTransformBias(polygon.points, polygon.transform);

            if (_polygonPoints.Length > polygonPointGizmos.Count) // More points than gizmos -> add new gizmos
            {
                int diff = _polygonPoints.Length - polygonPointGizmos.Count;
                for (int i = 0; i < diff; i++)
                {
                    polygonPointGizmos.Add(CreateGizmo());
                }
            }
            else if (_polygonPoints.Length < polygonPointGizmos.Count) // More gizmos than points -> remove gizmos
            {
                int diff = polygonPointGizmos.Count - _polygonPoints.Length;
                for (int i = 0; i < diff; i++)
                {
                    PolygonPointGizmo toRemove = polygonPointGizmos[0];
                    polygonPointGizmos.Remove(toRemove);
                    DestroyImmediate(toRemove.gameObject);
                }
            }

            for (int i = 0; i < _polygonPoints.Length; i++)
            {
                if (polygonPointGizmos[i] == null)
                {
                    polygonPointGizmos[i] = CreateGizmo();
                }

                lineRenderer.enabled = showLines;
                polygonPointGizmos[i].gameObject.SetActive(showGizmos);
                polygonPointGizmos[i].text.gameObject.SetActive(showTexts);

            }
        }

        private PolygonPointGizmo CreateGizmo()
        {
#if UNITY_EDITOR
            PolygonPointGizmo gizmo = UnityEditor.PrefabUtility.InstantiatePrefab(template) as PolygonPointGizmo;
            gizmo.transform.SetParent(transform, true);
#else
        PolygonPointGizmo gizmo = Instantiate(template, transform, true);
#endif
            return gizmo;
        }
    }
}