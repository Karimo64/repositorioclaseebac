using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEsfera2 : MonoBehaviour
{
    public GameObject sfer;
    // public GameObject one;
    // public GameObject two;
    public ColorEsfera variableSfer1;
    public ColorEsfera1 variablesfer2;

    public bool variable5;
    
    // Start is called before the first frame update
    void Start()
    {
        // var varBool1 = one.GetComponent<ColorCapsula>().capsule;
        // bool varBool2 = two.GetComponent<ColorCubo>().cuby;

        // if(varBool1 == true){
        // Debug.Log("Se logro");
        // }
        // if(varBool1 == false){
        // Debug.Log("Se logro");
        // }
        
        
        //bool variable1.variable;
        
        //bool variable2.variable;


    }

    // Update is called once per frame
    void Update()
    {
        /////////////////////////////////////////////////////
        //Obtencion de los valores de los otros GameObjects
        
        // sfer = this.gameObject;
        // Color color = new Color(Random.value,Random.value,Random.value);
        // sfer.GetComponent<MeshRenderer>().material.color = color;
    }

    private void FixedUpdate() {

        if(variableSfer1.variable3 && !variablesfer2.variable4){
            variable5 = true;
        }
        else{
            variable5 = false;
        }

        if(variable5){
            sfer.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else if(!variable5){
            sfer.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
