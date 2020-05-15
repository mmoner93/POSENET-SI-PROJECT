using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spehereScript : MonoBehaviour
{

    public GameObject WristR;
    public GameObject WristL;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reScale();
        changeColor();
    }


    void reScale() {

        float distance =  ((WristR.transform.position.x - WristL.transform.position.x)*2.0f)/2.0f;

        transform.localScale = new Vector3(distance, distance, distance);

    }

    void changeColor() {

        MeshRenderer rend = GetComponent<MeshRenderer>();

        if (WristR.transform.position.y < -80 && WristL.transform.position.y < -80) {
            rend.materials[0].color = Color.cyan;
        } else if (WristR.transform.position.y < 60 && WristL.transform.position.y < 60) {
            rend.materials[0].color = Color.red;
        }
        else {
            rend.materials[0].color = Color.green;
        }

    }

}
