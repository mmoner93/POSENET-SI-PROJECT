using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class rotateplayer : MonoBehaviour
{
    public GameObject town;
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
        town.gameObject.transform.Rotate(0, 90, 0, Space.World);
        town.gameObject.transform.position = new Vector3(14396, -257 , -11493);
        controlGoClass.instanceGoClass.direction += 1;
        this.gameObject.SetActive(false);
    }
}
