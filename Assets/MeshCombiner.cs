using UnityEngine;
using System.Collections.Generic;

public class MeshCombiner : MonoBehaviour
{
    void Start()
    {
        CombineMeshes();
    }

    void CombineMeshes()
    {
        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        List<CombineInstance> combineList = new List<CombineInstance>();
        Material chosenMaterial = null;

        foreach (MeshFilter mf in meshFilters)
        {
            if (mf == null || mf.sharedMesh == null || mf.transform == transform)
                continue;

            MeshRenderer renderer = mf.GetComponent<MeshRenderer>();
            if (renderer == null)
                continue;

            if (chosenMaterial == null)
                chosenMaterial = renderer.sharedMaterial;

            CombineInstance ci = new CombineInstance();
            ci.mesh = mf.sharedMesh;
            ci.transform = mf.transform.localToWorldMatrix;
            combineList.Add(ci);

            mf.gameObject.SetActive(false); // Disable original after processing
        }

        if (combineList.Count == 0)
        {
            Debug.LogWarning("No valid meshes found to combine.");
            return;
        }

        Mesh combinedMesh = new Mesh();
        combinedMesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32; // If you have lots of vertices
        combinedMesh.CombineMeshes(combineList.ToArray(), true, true);

        MeshFilter mfCombined = gameObject.AddComponent<MeshFilter>();
        mfCombined.mesh = combinedMesh;

        MeshRenderer mrCombined = gameObject.AddComponent<MeshRenderer>();
        mrCombined.sharedMaterial = chosenMaterial;

        gameObject.AddComponent<MeshCollider>(); // Optional, helps you see/interact

        Debug.Log($"Combined {combineList.Count} meshes into one.");
    }
}