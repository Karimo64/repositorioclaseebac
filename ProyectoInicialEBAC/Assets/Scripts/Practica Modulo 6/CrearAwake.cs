using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearAwake : MonoBehaviour
{
    public GameObject objToSpawn;
   

    private void Awake() {
        /*
        Instantiate(objToSpawn);
        objToSpawn = new GameObject("Random Color Cube");
        

        //Agregar MeshFilter 
        objToSpawn.AddComponent<MeshFilter>();
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();
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
        */
        GameObject cuboSpawn = Instantiate<GameObject>(objToSpawn);

        var materialRend = objToSpawn.GetComponent<MeshRenderer>().material;
        materialRend.color = Color.white;

        cuboSpawn.GetComponent<MeshRenderer>().material.color = materialRend.color;
    
        cuboSpawn.transform.position= new Vector3(1f,1.25f,0f);
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
