using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hola_Mundo_P5 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        print("Sucedio un evento!");
        Debug.Log("Se ha generado algo");
        Debug.LogWarning("Algo genera conflictos");
        Debug.LogError("ERROR , algo ha salido mal");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hola me encuentro en update");

    }

    private void FixedUpdate() 
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate() 
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable() 
    {
        Debug.LogWarning("Objeto habilitado");
    }

    private void OnDisable() 
    {
        Debug.LogWarning("Objeto inhabilitado!");
    }
}
