using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerSpin : MonoBehaviour
{
    // Start is called before the first frame update
    private float spin = 1000.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, spin * Time.deltaTime);

    }
}
