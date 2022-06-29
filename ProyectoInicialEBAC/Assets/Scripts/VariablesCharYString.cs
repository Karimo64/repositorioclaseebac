using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesCharYString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c= '6';
        int valorEntero= 0;
        if(!int.TryParse(c.ToString(), out valorEntero))
        {
            Debug.Log("eso no es un tipo de dato valido");
        }
        Debug.Log(valorEntero);


        /////////////////////////////////////////////////////

        char miCaracter; 
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.ToUpper();
        string miTercerString = miString + " " + miSegundoString;
        //string ejemploEscape = "c:\\Users\\pepek\\Documents";
        miCaracter = miString[13];
        string miNombre = "Karim";
        string misApellidos = "Sosa Perez";
        string primerApellido = misApellidos.Substring(0,4);
        string salidasSuma = "mi nombre es: " + miNombre + "y mis apellidos son " + misApellidos;
        string salida = $"Minombre es: {miNombre} Y mis Apellidos son {misApellidos}";
        int longitud = miString.Lenght;
        Debug.Log(salida);
        Debug.Log(salidaSuma);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
