using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    short miShort = 1;
    ushort miShortConSigno = 0;
    int miInt = 0;
    uint miIntConSigno = 0;
    long miLong = long.MaxValue;
    ulong miLongConSigno = 0;
    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        Debug.Log("El valor de miByteConSigno es: " + miByteConSigno);
        Debug.Log("El valor de  miInt es: " + miInt);
        miByte = 200;
        miIntConSigno = miByte;
        miIntConSigno = (uint)miByteConSigno;
        Debug.Log("El valor de miIntConSigno es: " + miIntConSigno);

        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("El valor de miInt es: " + miLong);

        float a, b, c;
        float f;
        a = 5;
        b= 10 ;
        c = a + b;
        Debug.Log(c);
        c = a * b;
        Debug.Log(c);
        c = a - b;
        Debug.Log(c);
        f = a / b;
        Debug.Log(f);

        //miInt = Random.Range(a,b);
        // if(miInt % 2 == 0)
        // {
        //     Debug.Log("el numero " + miInt + "es par");
        // }
        // else
        // {
        //     Debug.Log("el numero" + miInt + "es non");
        // }
        //
    }

    // Update is called once per frame
    void Update()
    {

    }
}
