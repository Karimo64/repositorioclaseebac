using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearAwake : MonoBehaviour
{
    GameObject objToSpawn;
    Vector3[] vertices = {
        new Vector3 (0,0,0),
        new Vector3 (1,0,0),
        new Vector3 (1,1,0),
        new Vector3 (0,1,0),
        new Vector3 (0,1,1),
        new Vector3 (1,1,1),
        new Vector3 (1,0,1),
        new Vector3 (0,0,1),
    };

    int[] triangulos = {
        0, 2, 1,
        0, 3, 2,
        2, 3, 4,
        2, 4, 5,
        1, 2, 5,
        1, 5, 6,
        0, 7, 4,
        0, 4, 3,
        5, 4, 7,
        5, 7, 6,
        0, 6, 7,
        0, 1, 6
    };

    private void Awake() {
        objToSpawn = new GameObject("Nuestro Primer Cubo");

        //Agregar MeshFilter 
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();

        //Agregar BoxCollider 3D
        objToSpawn.AddComponent<BoxCollider>();
        var collider = objToSpawn.GetComponent<BoxCollider>();
        collider.center = new Vector3(0.5f, 0.5f, 0.5f);

        //Agregar Meshrenderer
        objToSpawn.AddComponent<MeshRenderer>();
        var materialRend = objToSpawn.GetComponent<MeshRenderer>().material;
        materialRend.color = Color.white;

        //Agreagar Rigidbody
        objToSpawn.AddComponent<Rigidbody>();

        //Posicion donde se genera
        objToSpawn.transform.position = Vector3.one;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
