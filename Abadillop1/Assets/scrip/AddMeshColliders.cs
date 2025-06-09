using UnityEngine;

public class AddMeshColliders : MonoBehaviour
{
    [ContextMenu("Agregar MeshColliders a hijos")]
    void AddCollidersToChildren()
    {
        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        int count = 0;

        foreach (MeshFilter mf in meshFilters)
        {
            GameObject go = mf.gameObject;

            if (!go.GetComponent<MeshCollider>())
            {
                MeshCollider mc = go.AddComponent<MeshCollider>();
                mc.sharedMesh = mf.sharedMesh;
                mc.convex = false;
                count++;
            }
        }

        Debug.Log($"Se agregaron {count} MeshColliders.");
    }
}