using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class VolcanoBase : MonoBehaviour
{
    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    void Start()
    {
        MakeMeshData();
        CreateMesh();
    }

    void MakeMeshData()
    {
        vertices = new Vector3[] { new Vector3(0, 0, 0),    new Vector3(0, 0, 30),   new Vector3(30, 0, 0),
                                   new Vector3(30, 0, 0),   new Vector3(0, 0, 30),   new Vector3(30, 0, 30) };
        triangles = new int[] { 0, 1, 2, 3, 4, 5 };
    }

    void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
