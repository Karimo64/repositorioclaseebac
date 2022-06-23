using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCubo : MonoBehaviour
{
    public GameObject cuby;

    private void Awake() {
        cuby = this.gameObject;
        Color color = new Color(Random.value,Random.value,Random.value);
        cuby.GetComponent<MeshRenderer>().material.color = color;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
