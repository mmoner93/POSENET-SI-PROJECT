using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoClassMoveColisions : MonoBehaviour
{
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
        if (other.gameObject.CompareTag("manoIz") && CompareTag("BrazoIzqCube"))
        {
            m_Collider.enabled = !m_Collider.enabled;
            Collider otherCollider = other.GetComponent<Collider>();
            otherCollider.enabled = otherCollider.enabled;
            controlGoClass.instanceGoClass.counter += 1;
        }
    }
}
