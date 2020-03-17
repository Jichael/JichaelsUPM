using System.Collections.Generic;
using System.Globalization;
using ClipperLib;
using Jichaels.Tools2D;
using TMPro;
using Unity.XR.Oculus;
using UnityEngine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem; 
#endif

public class DebugCheckIntersection : MonoBehaviour
{
    public new Camera camera;

    public ShowPolygonCollider checker;
    
    public ShowPolygonCollider toCheck;

    public ShowPolygonCollider intersectionTemplate;

    public Transform intersectionPoints;
    
    private Transform _transform;

    private List<ShowPolygonCollider> _intersections = new List<ShowPolygonCollider>();
    private List<ShowPolygonCollider> _currentIntersections = new List<ShowPolygonCollider>();
    
    private List<Vector2[]> _polyIntersections = new List<Vector2[]>();

    public TextMeshProUGUI areaSubject;
    public TextMeshProUGUI areaCut;
    public TextMeshProUGUI areaIntersection;

    private void Awake()
    {
        areaSubject.text = toCheck.polygon.PolygonArea().ToString(CultureInfo.InvariantCulture);
        areaCut.text = checker.polygon.PolygonArea().ToString(CultureInfo.InvariantCulture);
    }


#if ENABLE_INPUT_SYSTEM
    
    private PolygonExempleAction _polygonExampleAction;
    [SerializeField] private InputActionReference mousePositionReference;    

    private void OnEnable()
    {
        mousePositionReference.action.Enable();
        _polygonExampleAction = new PolygonExempleAction();
        _polygonExampleAction.Enable();
        _polygonExampleAction.Default.GetSnapShot.performed += OnGetSnapShot;
        _polygonExampleAction.Default.ClearSnapShot.performed += OnClearSnapShots;
    }

    private void OnDisable()
    {
        mousePositionReference.action.Disable();
        _polygonExampleAction.Default.GetSnapShot.performed -= OnGetSnapShot;
        _polygonExampleAction.Default.ClearSnapShot.performed -= OnClearSnapShots;
        _polygonExampleAction.Dispose();
    }

    private void OnGetSnapShot(InputAction.CallbackContext ctx)
    {
        GetSnapShot();
    }
    
    private void OnClearSnapShots(InputAction.CallbackContext ctx)
    {
        ClearSnapshots();
    }

#endif

    private void Update()
    {
        
#if ENABLE_INPUT_SYSTEM
        Vector3 mousePosition = mousePositionReference.action.ReadValue<Vector2>();
#else
        Vector3 mousePosition = Input.mousePosition;
#endif

        mousePosition.z = 20;
        mousePosition = camera.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0;
        checker.transform.position = mousePosition;
        
        GetIntersection();
        
#if !ENABLE_INPUT_SYSTEM
        if(Input.GetKeyDown(KeyCode.Mouse0)) GetSnapShot();
        if(Input.GetKeyDown(KeyCode.Mouse1)) ClearSnapshots();
#endif
        float area = 0;
        for (int i = 0; i < _currentIntersections.Count; i++)
        {
            if(_currentIntersections[i].gameObject.activeSelf) area += _currentIntersections[i].polygon.PolygonArea();
        }
        areaIntersection.text = area.ToString(CultureInfo.InvariantCulture);
    }

    private void OnDrawGizmos()
    {
        UpdatePoints();
    }

    private void UpdatePoints()
    {
        Vector2[] points = checker.polygon.points;
        Vector2 offSet = checker.transform.position;

        for (int i = 0; i < points.Length; i++)
        {
            Vector2 point = points[i] + offSet;

            bool isInside = toCheck.polygon.OverlapPoint(point);

            checker.polygonPointGizmos[i].spriteRenderer.color = isInside ? Color.green : Color.red;
        }
    }

    private void GetSnapShot()
    {
        for (int i = 0; i < _polyIntersections.Count; i++)
        {
            ShowPolygonCollider poly = Instantiate(intersectionTemplate, intersectionPoints);
            poly.polygon.points = _polyIntersections[i];
            _intersections.Add(poly);
        }
    }

    private void ClearSnapshots()
    {
        for (int i = 0; i < _intersections.Count; i++)
        {
            Destroy(_intersections[i].gameObject);
        }
        _intersections.Clear();
    }

    private void GetIntersection()
    {
        Vector2[] subjectPoints = PolygonTools.FixTransformBias(toCheck.polygon.points, toCheck.polygon.transform);
        Vector2[] cutPoints = PolygonTools.FixTransformBias(checker.polygon.points, checker.polygon.transform);

        _polyIntersections = PolygonTools.Clip(subjectPoints, cutPoints, ClipType.Intersection);

        for (int i = 0; i < _polyIntersections.Count; i++)
        {
            if(_currentIntersections.Count - 1 < i) _currentIntersections.Add(Instantiate(intersectionTemplate));

            _currentIntersections[i].polygon.points = _polyIntersections[i];
            _currentIntersections[i].gameObject.SetActive(true);
        }

        for (int i = _polyIntersections.Count; i < _currentIntersections.Count; i++)
        {
            _currentIntersections[i].gameObject.SetActive(false);
        }
    }


}