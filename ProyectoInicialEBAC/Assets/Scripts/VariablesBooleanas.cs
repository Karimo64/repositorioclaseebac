using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1 = true;
    bool variable2 = false;
    bool variable3 = true;
    int valor1 = 5;
    int limiteInferior = 0;
    int limiteSuperior = 5;

    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    }

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        if((variable1 || variable2) && variable3) // variable con operador "!" antes incializa falso y "sin !" inicializa verdadero
        { 
            Debug.Log("La operacion 1 es verdadero");
        }
        else if((variable1 || variable2) || variable3)
        {
            if(variable1)
            {
                Debug.Log("La variable 1 es verdadera");
            }
            Debug.Log("La operacion 2 es verdadero");
        }
        else if((variable3 && variable2) || variable1)
        {
            Debug.Log("La operacion 3 es verdadera");
        }

        valor1 = Random.Range(limiteInferior,limiteSuperior);
        Debug.Log(valor1);
        /*
        if(valor1 >= 0)
        {
            Debug.Log("El valor es positivo");
        }
        else{
            Debug.Log("El valor es negativo");
        }
        */
        string resultado = (valor1 >= 0) ? "el valor es positivo" : "el valor es negativo";
        Debug.Log(resultado);



        /*
        switch(valor1)
        {
            case (int)SeleccionColor.rojo:
                Debug.Log("El color seleccionado es rojo");
                break;
            case (int)SeleccionColor.verde:
                Debug.Log("El color seleccionado es verde");
                break;
            case (int)SeleccionColor.azul: //when variable1 == true :
                Debug.Log("El color seleccionado es azul");
                break;
            case (int)SeleccionColor.blanco:
                Debug.Log("El color seleccionado es blanco");
                break;
            case (int)SeleccionColor.gris:
                Debug.Log("El color seleccionado es gris");
                break;

            default:
                Debug.Log("Ese valor no existe en la lista");
                break;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
