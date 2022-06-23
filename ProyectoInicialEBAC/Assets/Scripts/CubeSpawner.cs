using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{

    public GameObject prefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos=0;
    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
        tempGameObject.name = "CuboNumero" + numCubos;
        Color color = new Color(Random.value,Random.value,Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = color;


        //Posicion de spawn
        tempGameObject.transform.position = Random.insideUnitSphere;

        //Agregar prefab a una lista
        listaDeCubos.Add(tempGameObject);
        List<GameObject> objetosAEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            //Condicion if para eliminacion de cubos
            if(scale <= 0.1)
            {
                objetosAEliminar.Add(go);
            }
        }

        //Destruir el objeto 
        foreach (GameObject go in objetosAEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
