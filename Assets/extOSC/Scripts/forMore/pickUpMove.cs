using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpMove : MonoBehaviour
{

    public GameObject whatHand;
    public bool take;

    // Start is called before the first frame update
    void Start()
    {
        take = false;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move() {
        if (take) {
            transform.position = whatHand.transform.position;
        }
    }

    public void takeObject(GameObject hand) {
        take = true;
        whatHand = hand;
    }

}
