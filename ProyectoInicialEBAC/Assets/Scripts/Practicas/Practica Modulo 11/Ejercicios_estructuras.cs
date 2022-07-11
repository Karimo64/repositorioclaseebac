using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicios_estructuras : MonoBehaviour
{

    List<string> listaStrings = new List<string>();

    Stack<string> pilaStrings = new Stack<string>();


    // Start is called before the first frame update
    void Start()
    {
        List<int> Lista1 = Ejercicio1(5,0,5);

        int[] Arreglo1 = Ejercicio2(new int[] {5,9,1,3});

        listaStrings.Add("Rojo");
        listaStrings.Add("Azul");
        listaStrings.Add("Rojo");
        listaStrings.Add("Amarillo");
        listaStrings.Add("Amarillo");
        HashSet<string> HashSet1 =Ejercicio3();

        pilaStrings.Push("Contenido 1");
        pilaStrings.Push("Contenido 2");
        pilaStrings.Push("Contenido 3");
        pilaStrings.Push("Contenido 4");
        pilaStrings.Push("Contenido 5");
        Ejercicio4(pilaStrings);



        foreach(int valor in Lista1)
        {
            Debug.Log(valor);
        }

        foreach(int entero in Arreglo1)
        {
            Debug.Log(entero);
        }

        foreach (var color in HashSet1 )
        {
            Debug.Log(color);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<int> Ejercicio1(int tamano ,int rangoInferior ,int randoSuperior)
    {
        List<int> perro = new List<int>();

         for ( int i = 0 ; i < tamano  ; i++)
         {
             perro.Add(Random.Range(rangoInferior,randoSuperior));
         }


        return perro;
          
    }

    public int[] Ejercicio2(int[] enteros)
    {
        int temp;

        for (int i = 0; i < enteros.Length - 1; i++)
            {
            for (int j = i + 1; j < enteros.Length; j++)
                {
                    if (enteros[i] < enteros[j]) 
                    {
                    temp = enteros[i];
                    enteros[i] = enteros[j];
                    enteros[j] = temp;
                    }
                }
            }
        
        return enteros;

    }

    public HashSet<string> Ejercicio3()
    {
        HashSet<string> colores = new HashSet<string>(listaStrings);
        
        return colores;
    }

    public void Ejercicio4(Stack<string> pilaStrings)
    {
        Queue<string> colaStrings = new Queue<string>() ;

        // foreach (var pila in pilaStrings)
        // {
        // Debug.Log(pila);
        // colaStrings.Enqueue(pila);
        
        // }

        // foreach (var cola in colaStrings)
        // {
        // Debug.Log(cola);
        // colaStrings.Dequeue();
        // }

    

        for (int i = 0; i <= pilaStrings.Count; i++)
        {
            Debug.Log(pilaStrings.Peek());
            colaStrings.Enqueue(pilaStrings.Peek());
            pilaStrings.Pop();
        }

        for (int i = 0; i <= colaStrings.Count; i++)
        {
            Debug.Log(colaStrings.Peek());
            colaStrings.Dequeue();
        }
    }
}
