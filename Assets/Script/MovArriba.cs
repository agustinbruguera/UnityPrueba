using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovArriba : MonoBehaviour
{
    float translateVelocity = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moverArriba();
        
    }

    void moverArriba()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * translateVelocity * Time.deltaTime);
        }
        
    }
}
