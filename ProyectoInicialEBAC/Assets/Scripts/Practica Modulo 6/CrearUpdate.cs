using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearUpdate : MonoBehaviour
{
    public GameObject objToSpawn;
    //public List<GameObject> listaDeCubos;
    //public float factorDeEscalamiento;
    //public int numCubos=0;
    // Start is called before the first frame update
    void Start()
    {
        //listaDeCubos = new List<GameObject>    
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cuboSpawn = Instantiate<GameObject>(objToSpawn);

        var materialRend = objToSpawn.GetComponent<MeshRenderer>().material;
        
        Color color = new Color(Random.value,Random.value,Random.value);
        materialRend.color = color;

        cuboSpawn.GetComponent<MeshRenderer>().material.color = materialRend.color;
    
        cuboSpawn.transform.position= new Vector3(1f,5.25f,0f);
    }
}
