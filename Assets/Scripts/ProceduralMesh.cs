using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]

public class ProceduralMesh : MonoBehaviour
{
    private Mesh mesh;

    private Vector3[] verticies;
    private int[] triangles;

    private void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    // Start is called before the first frame update
    void Start()
    {
        MakeMeshData();
        CreateMesh();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeMeshData()
    {
        verticies = new Vector3[] { new Vector3(0, YValue.ins.yValue, 0), new Vector3(0, 0, 1), new Vector3(1, 0, 0), new Vector3(1, 0, 1) };
        triangles = new int[] { 0, 1, 2, 2, 1, 3 };
    }

    void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = verticies;
        mesh.triangles = triangles;

        mesh.RecalculateNormals();
    }
}
