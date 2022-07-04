using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{

    public GameObject cilindro;

    //int tipoEntero = 0;
    //float tipoFloat = 1;

    float varFloat1 = 5.5f;
    float varFloat2 = 3.4f;
    int explicito;

    int varInt1 = 19;
    int checkParImpar = 0;

    float aString = 1.2345123f;
    string fromFloat ;


    string palabra = "verde" ;

    string numerico1 = "7583";
    string numerico2 = "5421";
    int suma;




    void Start()
    {

    //Valor explicito
        float resultado = 0 ;
        resultado= varFloat1 + varFloat2;
        explicito = (int)resultado;
        Debug.Log($"Valor explicito {explicito}");


    //Modulo y cambio de color segun resultado
        checkParImpar = varInt1 % 2;


    //Cambio color por string
        switch(palabra)
        {
            case "rojo":
                cilindro.GetComponent<MeshRenderer>().material.color = Color.red;
                Debug.Log("El color seleccionado es rojo");
                break;
            case "azul":
                cilindro.GetComponent<MeshRenderer>().material.color = Color.blue;
                Debug.Log("El color seleccionado es azul");
                break;
            case "amarillo" :
                cilindro.GetComponent<MeshRenderer>().material.color = Color.yellow;
                Debug.Log("El color seleccionado es amarillo");
                break;
            case "verde" :
                cilindro.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("El color seleccionado es verde");
                break;

            default:
                Debug.Log("Ese color no es posible mostrar");
                break;
        }


        //Foltante a string
        fromFloat = aString.ToString("0.0000");
        Debug.Log(fromFloat);


        //Metodo substring
        string miNombre = "Karim Sosa Perez";
        string nombre = miNombre.Substring(0,5);
        string primerApellido = miNombre.Substring(miNombre.Length -10,4);//misApellidos.Substring(0,4);
        string segundoApellido = miNombre.Substring(miNombre.Length - 5,5);//misApellidos.Substring(5);
        string salida = $"Mi nombre es: {nombre} Y mis Apellidos son {primerApellido} {segundoApellido}";
        Debug.Log(salida);


        //Metodo split
        string[] boku = miNombre.Split(' ');
        foreach (var omae in boku)
        {
            Debug.Log(omae);
        }

        //String a numerico con Parse
        suma = int.Parse(numerico1) + int.Parse(numerico2);
        Debug.Log($"La suma de los strings es:{suma} ");

        //Caracteres en indice par
        string oracion = "Hola Mundo";
        int mod = 0;
        for (int i = 0; i<oracion.Length; i++)
        {
            mod = i % 2;
            if(mod == 0)
            {
                Debug.Log(oracion[i]);
            }
        }
        // char[] charArray = oracion.ToCharArray();
        // foreach (char ch in charArray)
        // {
        //     if ()
        //     Debug.Log(ch);
        // }
        //Debug.Log("El tamaño del array es " + oracion.Length);

        ////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////

        //Eliminacion primeros 5 caracters
        string str = "Hola buenas tardes";
        string result = str.Substring(5);

        Debug.Log(result);

    }

    // Update is called once per frame
    void Update()
    {
        //tipoEntero += 1;
        //Debug.Log($"Entero  {tipoEntero}");
    }
    private void FixedUpdate() {
        //tipoFloat *= 2;
        //Debug.Log($"Float {tipoFloat}");

        //Checar valor modulo para cambio de color
        if(checkParImpar == 1){
            //cilindro.GetComponent<MeshRenderer>().material.color = Color.red;
            Debug.Log("Es impar");
        }
        else if(checkParImpar == 0){
            //cilindro.GetComponent<MeshRenderer>().material.color = Color.blue;
            Debug.Log("Es par");
        }
    }
}
