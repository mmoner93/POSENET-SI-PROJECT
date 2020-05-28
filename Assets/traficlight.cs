using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traficlight : MonoBehaviour
{
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
        Debug.Log("Soy el object in " + other.gameObject.tag.ToString());
        Debug.Log("Soy con el que he col in " + tag.ToString());
        Debug.Log("traffic light");
        controlGoClass.instanceGoClass.counter = 0;
        controlGoClass.instanceGoClass.isred = true;
        this.gameObject.SetActive(false);
    }
}
