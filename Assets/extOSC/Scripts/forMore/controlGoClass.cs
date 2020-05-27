using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlGoClass : MonoBehaviour
{
    public static controlGoClass instanceGoClass;
    public GameObject manoIzCube;
    public GameObject manoDerCube;
    public GameObject manoIzCubeDown;
    public GameObject manoDerCubeDown;
    public GameObject player;
    public float counter = 0;   //0 a 10 acumulas cajas cuando esta en maximo avanzas, con el tiempo baja
    public int direction = 0;
    public bool isred = false;

    private Vector3 move;
    
    // Start is called before the first frame update
    void Awake()
    {
        instanceGoClass = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (isred == false)
        if (counter >= 5) {
            isMoving();
            Debug.Log("move");
        }
        counter -= Time.deltaTime;
        if (isred == false)
        {
            if (counter < 0)
            {
                counter = 0;
            }
        }
        else {
            if (counter < -10) {
                isred = true;
            }
        }
            
        if (counter > 7) {
            counter = 7;
        }
    }
    void isMoving() {
        //move player
        if (direction == 0)
        {
            move = new Vector3(0, 0, 10);
            player.transform.Translate(move);
        }
        else if (direction == 1) {
            move = new Vector3(-10, 0, 0);
            player.transform.Translate(move);
        }
        else if (direction == 2)
        {
            move = new Vector3(0, 0, -10);
            player.transform.Translate(move);
        }

    }
}
