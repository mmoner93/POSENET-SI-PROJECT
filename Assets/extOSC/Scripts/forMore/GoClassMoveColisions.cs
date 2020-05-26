using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoClassMoveColisions : MonoBehaviour
{
    public GameObject IU;
    public GameObject ID;
    public GameObject DU;
    public GameObject DD;
    private Collider m_Collider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Soy el object in "+ other.gameObject.tag.ToString());
        Debug.Log("Soy con el que he col in " + tag.ToString());
        //Debug.Log("colision");
        if (other.gameObject.CompareTag("manoIz") && CompareTag("BrazoIzqCube"))
        {
            IU.SetActive(false);
            ID.SetActive(true);

            controlGoClass.instanceGoClass.counter += 1;
            Debug.Log("IU");
        }
        if (other.gameObject.CompareTag("manoDer") && CompareTag("BrazoDerCube"))
        {
            DU.SetActive(false);
            DD.SetActive(true);
            
            controlGoClass.instanceGoClass.counter += 1;
            Debug.Log("DU");
        }
        if (other.gameObject.CompareTag("manoIz") && CompareTag("BrazoIzqCubeDown"))
        {
            ID.SetActive(false);
            IU.SetActive(true);
            
            controlGoClass.instanceGoClass.counter += 1;
            Debug.Log("ID");
        }
        if (other.gameObject.CompareTag("manoDer") && CompareTag("BrazoDerCubeDown"))
        {
            DD.SetActive(false);
            DU.SetActive(true);
           
            controlGoClass.instanceGoClass.counter += 1;
            Debug.Log("DD");
        }

    }
}
