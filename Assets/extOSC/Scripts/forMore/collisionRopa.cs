using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionRopa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("Soy el object in "+ other.gameObject.tag.ToString());
       // Debug.Log("Soy con el que he col in " + tag.ToString());
        if (other.gameObject.CompareTag("manoIz") && CompareTag("BrazoIzqCube"))
        {

            controlRopa.instance.setManoIzqPosition(true);
          //  Debug.Log("mano izquierda true" );

        }

        if (other.gameObject.CompareTag("manoDer") && CompareTag("BrazoDerCube"))
        {
            controlRopa.instance.setManoDerPosition(true);
        //    Debug.Log("mano derecha true");
        }

        //Debug.Log("Estoy fuera con tag " + other.gameObject.tag);


    }

    void OnTriggerExit(Collider other)
    {


       // Debug.Log("Soy el object out " + other.gameObject.tag.ToString());
       // Debug.Log("Soy con el que he col out " + tag.ToString());

        if (other.gameObject.CompareTag("BrazoIzq") && CompareTag("BrazoIzqCube"))
        {
            controlRopa.instance.setManoIzqPosition(false);
           // Debug.Log("mano izquierda false");
        }
        if (other.gameObject.CompareTag("manoDer") && CompareTag("BrazoDerCube"))
        {
            controlRopa.instance.setManoDerPosition(false);
           // Debug.Log("mano derecha false");

        }

    }

}
