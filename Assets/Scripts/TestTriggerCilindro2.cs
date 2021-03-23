using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTriggerCilindro2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        //print("Soy el cilindro2 y algo ha chocado conmigo");
        if (other.gameObject.name == "Actor")
        {
            //print("Soy el cilindro2 y el actor ha chocado conmigo");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }
/*    private void OnTriggerStay(Collider other)
    {
        print("Soy el cilindro2 y algo esta  chocando conmigo");
        if (other.gameObject.name == "Actor")
        {
            print("Soy el cilindro2 y el actor esta chocando conmigo");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("Soy el cilindro2 y algo ha dejado de chocar conmigo");
        if (other.gameObject.name == "Actor")
        {
            print("Soy el cilindro2 y el actor ha dejado de chocar conmigo");
            ConstantForce cf = GetComponent<ConstantForce>();
            cf.enabled = true;
        }
    }
*/

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, 10f, Space.World);

    }
}
