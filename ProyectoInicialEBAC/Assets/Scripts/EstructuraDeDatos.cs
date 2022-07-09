using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EstructuraDeDatos : MonoBehaviour
{

    List<int> listaNumeros = new List<int>();
    List<string> listaStrings = new List<string>();
    HashSet<int> hashSetInts = new HashSet<int>();
    Queue<string> colaStrings= new Queue<string>();
    Stack<string> pilaStrings= new Stack<string>();
    Dictionary<string, float> poderArmas = new Dictionary<string, float>(); 
    // Start is called before the first frame update
    void Start()
    {
        DemoDictionary("escopeta");
        DemoDictionary("espada");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DemoListas()
    {
        ////////////////////////////////////////////////////////////////////////////
        ////////////                        Listas                     /////////////
        ////////////////////////////////////////////////////////////////////////////
        for ( int i = 0 ; i<10 ; i++)
        {
            //listaNumeros.Add(i);
            listaNumeros.Add(Random.Range(0,20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaNumeros.Sort();
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        // listaStrings.Add("Diego");
        // listaStrings.Add("Sofia");
        // listaStrings.Add("Daniel");
        // listaStrings.Add("Javier");
        // listaStrings.Add("Diana");
        // foreach (var nombre in listaStrings)
        // {
        //     Debug.Log(nombre);
        // }
        //listaStrings.Remove("Javier");
        //listaStrings.Remove("Daniel");
        // listaStrings.RemoveAt(2); //Especifica la posicion a eliminar 
        //  foreach (var nombre in listaStrings)
        // {
        //     Debug.Log(nombre);
        // }

        /////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////// Linq //////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////
        var listaOrdenada = listaNumeros.OrderBy(p => p).ToList();
        var listaConValoresGrandes = listaNumeros.Where(p => p > 10).ToList();
        Debug.Log("lista base");
        foreach(var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        Debug.Log("lista de numeros ordenada");
        foreach (var numero in listaOrdenada)
        {
            Debug.Log(numero);
        }
        Debug.Log("lista de numeros grandes");
        foreach(var numero in listaConValoresGrandes)
        {
            Debug.Log(numero);
        }
    }

    public void DemoHashSet()
    {
        ////////////////////////////////////////////////////////////////////////////
        ////////////                        HashSet                    /////////////
        ////////////////////////////////////////////////////////////////////////////
        // No esta ordenado
        // Valores unicos

        for (int i = 0; i < 20 ; i++)
        {
            hashSetInts.Add(i);
        }
        if (hashSetInts.Contains(5))
        {
            hashSetInts.Remove(5);
        }
        else
        {
            Debug.Log("El HashSet no contiene este elemento");
        }
    }

    public void DemoColas()
    {
        ////////////////////////////////////////////////////////////////////////////
        ////////////                        Queue                      /////////////
        ////////////////////////////////////////////////////////////////////////////

        //First In First Out => FIFO

        colaStrings.Enqueue("Proyectil 1");
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
    }

    public void DemoPilas()
    {
        ////////////////////////////////////////////////////////////////////////////
        ////////////                        Pilas                      /////////////
        ////////////////////////////////////////////////////////////////////////////

        
        //First In Last Out => FILO

        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
    }

    public void DemoDictionary(string arma)
    {
        ////////////////////////////////////////////////////////////////////////////
        ////////////                     Diccionario                   /////////////
        ////////////////////////////////////////////////////////////////////////////

        float temporal = 0 ;
        if (!poderArmas.ContainsKey("rifle"))
        {
            poderArmas.Add("rifle", 7.0f);
        }
        if (!poderArmas.ContainsKey("pistola"))
        {
            poderArmas.Add("pistola", 3.0f);
        }
        if (!poderArmas.ContainsKey("escopeta"))
        {
            poderArmas.Add("escopeta", 5.0f);
        }
        if (!poderArmas.ContainsKey("rifleFrancotirador"))
        {
            poderArmas.Add("rifleFrancotirador", 10.0f);
        }
        if (!poderArmas.ContainsKey("cuchillo"))
        {
            poderArmas.Add("cuchillo", 2.0f);
        }
        
        Debug.Log(poderArmas["escopeta"]);
        if (poderArmas.TryGetValue("escopeta", out temporal))
        {
            Debug.Log(poderArmas["escopeta"]);
        }
        else
        {
            Debug.Log("Esa arma no existe");
        }
    }
}
