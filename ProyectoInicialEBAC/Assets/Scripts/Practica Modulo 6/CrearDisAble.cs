using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearDisAble : MonoBehaviour
{
    public GameObject objToSpawn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable() {

    GameObject cuboSpawn = Instantiate<GameObject>(objToSpawn);

        var materialRend = cuboSpawn.GetComponent<MeshRenderer>().material;
        materialRend.color = Color.red;

        cuboSpawn.GetComponent<MeshRenderer>().material.color = materialRend.color;
    
        cuboSpawn.transform.position= new Vector3(1f,1.25f,0f);
    }
    
    private void OnDisable() {
        GameObject cuboSpawn = Instantiate<GameObject>(objToSpawn);

        var materialRend = cuboSpawn.GetComponent<MeshRenderer>().material;
        materialRend.color = Color.blue;

        cuboSpawn.GetComponent<MeshRenderer>().material.color = materialRend.color;
    
        cuboSpawn.transform.position= new Vector3(1f,0f,0f);
    }
}
