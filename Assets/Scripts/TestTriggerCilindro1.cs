using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTriggerCilindro1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    /*
    //se activa si hay una colision

    private void OnTriggerEnter(Collider other)
    {
        print("Soy el cilindro1 y algo ha chocado conmigo");
        if (other.gameObject.name == "Actor")
        {
            print("Soy el cilindro1 y el actor ha chocado conmigo");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }
*/

/*
//se activa si se esta colisionando con algo
    private void OnTriggerStay(Collider other)
    {
        print("Soy el cilindro1 y algo esta  chocando conmigo");
        if (other.gameObject.name == "Actor")
        {
            print("Soy el cilindro1 y el actor esta chocando conmigo");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }
*/

    private void OnTriggerExit(Collider other)
    {
        //print("Soy el cilindro1 y algo ha dejado de chocar conmigo");
        if (other.gameObject.name == "Actor")
        {
            //print("Soy el cilindro1 y el actor ha dejado de chocar conmigo");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 10f, Space.World);

    }
}
