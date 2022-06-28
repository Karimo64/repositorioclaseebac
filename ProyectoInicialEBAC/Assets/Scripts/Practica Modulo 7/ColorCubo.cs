using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo : MonoBehaviour
{
    public GameObject cuby;
    public bool variable = true;
    private void Awake() {
        // cuby = this.gameObject;
        // Color color = new Color(Random.value,Random.value,Random.value);
        // cuby.GetComponent<MeshRenderer>().material.color = color;
    }
    // Start is called before the first frame update
    void Start()
    {
        
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
            cuby = this.gameObject;
            cuby.GetComponent<MeshRenderer>().material.color = Color.black;
        }

        else if(variable == false){
            variable = true;
            Debug.Log("La variable era falsa , ahora es verdadera");
            cuby = this.gameObject;
            cuby.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
}
