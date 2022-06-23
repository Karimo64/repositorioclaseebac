using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCapsula : MonoBehaviour
{
    public GameObject capsule;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        capsule = this.gameObject;
        Color color = new Color(Random.value,Random.value,Random.value);
        capsule.GetComponent<MeshRenderer>().material.color = color;
    }
}
