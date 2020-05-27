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
        controlGoClass.instanceGoClass.counter = 0;
    }
}
