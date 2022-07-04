using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyarreglos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
        int[] arr1 = new int[3];
        int[] arr2 = new int[3];
        int[] sumarr = new int [3];


        Debug.LogWarning("Array 1: ");
        for (int i=0; i<arr1.Length; i++)
        {
            arr1[i]=Random.Range(0,5);
            Debug.Log(arr1[i]);
        }
         Debug.LogWarning("Array 2: ");
        for (int i=0; i<arr2.Length; i++)
        {
            arr2[i]=Random.Range(0,5);
            Debug.Log(arr2[i]);
        }
         Debug.LogWarning("Suma Arrays : ");
        for (int i=0; i<sumarr.Length;i++)
        {
            sumarr[i] = arr1[i] + arr2[i];
            Debug.Log(sumarr[i]);
        }
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        var frase = "";
        string [] oracion = new string[]{"Quiero","jugar","Monster","Hunter","Rise","Sunbreak","pero","no","hay","tiempo"};
        foreach (string palabra in oracion )  
        {
            
            Debug.Log(palabra.ToString());
            frase += palabra + " ";
            
        }
        
        // Debug.Log(frase);

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        const int renglones = 2; 
        const int columnas = 3; 

        int[,] biD= new int [renglones,columnas] { {1,2,3},{4,5,6} };
        int[] uniD = new int[columnas] {7,8,9};
        int[] resultado = new int[renglones];

        for(int i=0 ; i < renglones ; i++)
        {
            for(int j = 0; j<columnas; j++)
            {
                resultado[i] += biD[i,j] * uniD[j];
            }
        }

        for(int i=0; i<resultado.Length;i++)
        {
            Debug.Log(resultado[i]);
        }

        //arreglos 
        //      [1,2,3]                        [ 07 + 16 + 27 ]   => [50] 
        //      [4,5,6]   *    [7,8,9]         [ 28 + 40 + 54 ]   => [122]

    
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
