using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class VolcanoSIdes : MonoBehaviour
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
        vertices = new Vector3[] { new Vector3(12, 0, 2),    new Vector3(18, 0, 2),   new Vector3(12, 20, 7),
                                   new Vector3(12, 20, 7),   new Vector3(18, 20, 7),   new Vector3(18, 0, 2),

                                   new Vector3(12, 0, 2),    new Vector3(7, 0, 3),     new Vector3(10, 20, 8),
                                   new Vector3(10, 20, 8),    new Vector3(12, 20, 7),   new Vector3(12, 0, 2),

                                   new Vector3(7, 0, 3),     new Vector3(3, 0, 7),     new Vector3(8, 20, 10),
                                   new Vector3(8, 20, 10),    new Vector3(10, 20, 8),    new Vector3(7, 0, 3),

                                   new Vector3(3, 0, 7),     new Vector3(2, 0, 12),    new Vector3(7, 20, 12),
                                   new Vector3(7, 20, 12),   new Vector3(8, 20, 10),    new Vector3(3, 0, 7),

                                   new Vector3(2, 0, 12),    new Vector3(2, 0, 18),    new Vector3(7, 20, 18),
                                   new Vector3(7, 20, 18),   new Vector3(7, 20, 12),   new Vector3(2, 0, 12),

                                   new Vector3(2, 0, 18),    new Vector3(3, 0, 23),    new Vector3(8, 20, 20),
                                   new Vector3(8, 20, 20),   new Vector3(7, 20, 18),   new Vector3(2, 0, 18),

                                   new Vector3(3, 0, 23),    new Vector3(7, 0, 27),    new Vector3(10, 20, 22),
                                   new Vector3(10, 20, 22),   new Vector3(8, 20, 20),   new Vector3(3, 0, 23),

                                   new Vector3(7, 0, 27),    new Vector3(12, 0, 28),   new Vector3(12, 20, 23),
                                   new Vector3(12, 20, 23),  new Vector3(10, 20, 22),   new Vector3(7, 0, 27),

                                   new Vector3(12, 0, 28),   new Vector3(18, 0, 28),   new Vector3(18, 20, 23),
                                   new Vector3(18, 20, 23),  new Vector3(12, 20, 23),  new Vector3(12, 0, 28),

                                   new Vector3(18, 0, 28),   new Vector3(23, 0, 27),   new Vector3(20, 20, 22),
                                   new Vector3(20, 20, 22),  new Vector3(18, 20, 23),  new Vector3(18, 0, 28),

                                   new Vector3(23, 0, 27),   new Vector3(27, 0, 23),   new Vector3(22, 20, 20),
                                   new Vector3(22, 20, 20),  new Vector3(20, 20, 22),  new Vector3(23, 0, 27),

                                   new Vector3(27, 0, 23),   new Vector3(28, 0, 18),   new Vector3(23, 20, 18),
                                   new Vector3(23, 20, 18),  new Vector3(22, 20, 20),  new Vector3(27, 0, 23),

                                   new Vector3(28, 0, 18),   new Vector3(28, 0, 12),   new Vector3(23, 20, 12),
                                   new Vector3(23, 20, 12),  new Vector3(23, 20, 18),  new Vector3(28, 0, 18),

                                   new Vector3(28, 0, 12),   new Vector3(27, 0, 7),    new Vector3(22, 20, 10),
                                   new Vector3(22, 20, 10),   new Vector3(23, 20, 12),  new Vector3(28, 0, 12),

                                   new Vector3(27, 0, 7),    new Vector3(23, 0, 3),    new Vector3(20, 20, 8),
                                   new Vector3(20, 20, 8),   new Vector3(22, 20, 10),   new Vector3(27, 0, 7),

                                   new Vector3(23, 0, 3),    new Vector3(18, 0, 2),    new Vector3(18, 20, 7),
                                   new Vector3(18, 20, 7),   new Vector3(20, 20, 8),   new Vector3(23, 0, 3)};

        triangles = new int[] { 0, 1, 2, 3, 4, 5,
                                5, 4, 3, 2, 1, 0,
                                6, 7, 8, 9, 10, 11,
                                11, 10, 9, 8, 7, 6,
                                12, 13, 14, 15, 16, 17,
                                17, 16, 15, 14, 13, 12,
                                18, 19, 20, 21, 22, 23,
                                23, 22, 21, 20, 19, 18,
                                24, 25, 26, 27, 28, 29,
                                29, 28, 27, 26, 25, 24,
                                30, 31, 32, 33, 34, 35,
                                35, 34, 33, 32, 31, 30,
                                36, 37, 38, 39, 40, 41,
                                41, 40, 39, 38, 37, 36,
                                42, 43, 44, 45, 46, 47,
                                47, 46, 45, 44, 43, 42,
                                48, 49, 50, 51, 52, 53,
                                53, 52, 51, 50, 49, 48,
                                54, 55, 56, 57, 58, 59,
                                59, 58, 57, 56, 55, 54,
                                60, 61, 62, 63, 64, 65,
                                65, 64, 63, 62, 61, 60,
                                66, 67, 68, 69, 70, 71,
                                71, 70, 69, 68, 67, 66,
                                72, 73, 74, 75, 76, 77,
                                77, 76, 75, 74, 73, 72,
                                78, 79, 80, 81, 82, 83,
                                83, 82, 81, 80, 79, 78,
                                84, 85, 86, 87, 88, 89,
                                89, 88, 87, 86, 85, 84,
                                90, 91, 92, 93, 94, 95,
                                95, 94, 93, 92, 91, 90};
    }

    void CreateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
