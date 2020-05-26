using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateplayer : MonoBehaviour
{
    public GameObject player;
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
        player.gameObject.transform.Rotate(0, 90, 0);
        controlGoClass.instanceGoClass.direction += 1;
    }
}
