using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEsfera1 : MonoBehaviour
{
    public GameObject sfer;
    // public GameObject one;
    // public GameObject two;
    public ColorCapsula variable1;
    public ColorCubo variable2;

    public bool variable4;
    
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
        if(variable1.variable == true){
            Debug.LogWarning("Desde el GO 3 te digo que var1 es verdadera");
        }
        else if (variable1.variable == false){
            Debug.LogWarning("Desde el GO3 te digo que var1 es falsa");
        }

        if(variable2.variable == true){
            Debug.LogWarning("Desde el GO 3 te digo que var2 es verdadera");
        }
        else if (variable2.variable == false){
            Debug.LogWarning("Desde el GO3 te digo que var2 es falsa");
        }

        if(variable1.variable || variable2.variable){
            variable4 = true;
        }
        else{
            variable4 = false;
        }

        if(variable4){
            sfer.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else if(!variable4){
            sfer.GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
}
