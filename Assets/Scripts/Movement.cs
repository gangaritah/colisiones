using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speedForward = 4;
    public float speedRight = 4;
    public float speedBack = 4;
    public float speedLeft = 4;

    // Start is called before the first frame update
    void Start()
    {
    }

    //se activa si hay una colision
    private void OnTriggerEnter(Collider other)
    {   
        print("Soy el actor y he chocado con algo");
        //si se ha colisionado con el GameObject de nombre cilindro1...
        if (other.gameObject.name == "cilindro1")
        {
            print("Soy el actor y he chocado con el cilindro1");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
        //si se ha colisionado con el GameObject de nombre cilindro2...

        if (other.gameObject.name == "cilindro2")
        {
            print("Soy el actor y he chocado con el cilindro2");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }

/*
    //se activa si se esta colisionando con algo
    private void OnTriggerStay(Collider other)
    {   
        print("Soy el actor y estoy chocando con algo");
        //si se ha colisionado con el GameObject de nombre cilindro1...

        if (other.gameObject.name == "cilindro1")
        {
            print("Soy el actor y estoy chocando con el cilindro1");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
        //si se ha colisionado con el GameObject de nombre cilindro2...

         if (other.gameObject.name == "cilindro2")
        {
            print("Soy el actor y estoy chocando con el cilindro2");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }


    //se activa si se dejo de colisionar
    private void OnTriggerExit(Collider other)
    {   
        print("Soy el actor he dejado de chocar  con algo");
                //si se ha colisionado con el GameObject de nombre cilindro1...

        if (other.gameObject.name == "cilindro1")
        {
            print("Soy el actor y he dejado de chocar con el cilindro1");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
        //si se ha colisionado con el GameObject de nombre cilindro2...

         if (other.gameObject.name == "cilindro2")
        {
            print("Soy el actor y he dejado de chocar con el cilindro2");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }
*/
    // Update is called once per frame
    void Update()
    
    {   
        //si se esta preionando la tecla W...
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * speedForward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speedRight * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speedBack * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speedLeft * Time.deltaTime;
        }

    
    }
}
