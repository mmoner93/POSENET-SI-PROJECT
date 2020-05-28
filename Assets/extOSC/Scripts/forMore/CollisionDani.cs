using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDani : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sphere;
    GameObject whatPick;
    bool control;
    float time_on;

    private void Start()
    {
        control = false;
        time_on = 0.0f;
    }


    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pick Up") && control==false)
        {

            //destroyPickUp(Collider other);
            time_on+=Time.deltaTime*1000;
            takeThat(other);
           
        }
        Debug.Log("Estoy fuera con tag " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Basura") && control == true)
        {
            Debug.Log("Estoy entrando en basura");
            GlobalControl.Instance.tirar = false;
            whatPick.SetActive(false);
            whatPick = null;
            control = false;
        }

    }


    void destroyPickUp(Collider other) {
        other.gameObject.SetActive(false);
        controlScript.instance.setCounter();

        Debug.Log("Aqui tengo " + controlScript.instance.getCounter().ToString());
    }

    void takeThat(Collider other) {
        
        if (time_on >= 2.0) {
            // other.gameObject.GetType == pickUpMove
            pickUpMove temp = other.gameObject.GetComponent<pickUpMove>();
            temp.takeObject(this.gameObject);
            Collider tempCol= other.gameObject.GetComponent<Collider>();
            tempCol.enabled = false;
            whatPick = other.gameObject;

            control = true;
        }

    }





}
