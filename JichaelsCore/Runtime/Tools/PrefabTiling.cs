#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class PrefabTiling : MonoBehaviour
{
    
    
    [SerializeField] private Transform tilledObject;
    [SerializeField] private int tileCountX;
    [SerializeField] private int tileCountY;
    [SerializeField] private int tileCountZ;
    [SerializeField] private Vector3 tilingOffSet;

    [Header("Create objects")]
    [SerializeField] private bool create;
    

    [Header("Destroy objects")]
    [SerializeField] private bool clearAll;

    [SerializeField] private List<Transform> spawned = new List<Transform>();
    
    
    private Vector3 _startPosition;

    private Vector3 _scaling;
    
    private void OnValidate()
    {
        
        if (clearAll)
        {
            clearAll = false;
            EditorApplication.delayCall += Clear;
            return;
        }

        if (create)
        {
            create = false;
            EditorApplication.delayCall += Clear;
            EditorApplication.delayCall += Create;
        }
        
    }

    private void Create()
    {
        if (tileCountX * tileCountY * tileCountZ > 10000)
        {
            Debug.LogWarning("You are trying to spawn more than 10.000 prefabs, is this intended ?", this);
            return;
        }
        
        _startPosition = tilledObject.position;
        _scaling = transform.localScale;
        _scaling.x *= tilingOffSet.x;
        _scaling.y *= tilingOffSet.y;
        _scaling.z *= tilingOffSet.z;
        
        Vector3 spawnPos = Vector3.zero;
        
        for (int x = 0; x < tileCountX; x++)
        {
            for (int y = 0; y < tileCountY; y++)
            {
                for (int z = 0; z < tileCountZ; z++)
                {
                    
                    if(x == 0 && y ==0 && z == 0) continue;

                    spawnPos.x = x * _scaling.x;
                    spawnPos.y = y * _scaling.y;
                    spawnPos.z = z * _scaling.z;
                    
                    Transform tilled = ((GameObject) PrefabUtility.InstantiatePrefab(tilledObject)).transform;
                    tilled.position = _startPosition + spawnPos;
                    tilled.rotation = tilledObject.rotation;
                    tilled.parent = transform;
                    spawned.Add(tilled);
                }
            }
        }
    }

    private void Clear()
    {
        for (int i = 0; i < spawned.Count; i++)
        {
            DestroyImmediate(spawned[i].gameObject);
        }
        
        spawned.Clear();
            
    }
    
}

#endif