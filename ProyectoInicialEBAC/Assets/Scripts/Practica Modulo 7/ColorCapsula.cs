using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCapsula : MonoBehaviour
{
    public bool variable = true;
    public GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {
        //variable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        
        // capsule = this.gameObject;
        // Color color = new Color(Random.value,Random.value,Random.value);
        // capsule.GetComponent<MeshRenderer>().material.color = color;
        if(variable == true) {
            variable = false;
            Debug.Log("La variable era verdadera , ahora es falsa");
            capsule = this.gameObject;
            capsule.GetComponent<MeshRenderer>().material.color = Color.black;
        }

        else if(variable == false){
            variable = true;
            Debug.Log("La variable era falsa , ahora es verdadera");
            capsule = this.gameObject;
            capsule.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
