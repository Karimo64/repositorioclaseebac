using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorEsfera : MonoBehaviour
{
    public GameObject sfer;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        sfer = this.gameObject;
        Color color = new Color(Random.value,Random.value,Random.value);
        sfer.GetComponent<MeshRenderer>().material.color = color;
    }
}
