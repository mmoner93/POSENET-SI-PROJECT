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
    public GameObject light;
    public Material red;
    public Material green;
    public Material black;
    public Material ambar;
    public float counter = 0;   //0 a 10 acumulas cajas cuando esta en maximo avanzas, con el tiempo baja
    public int direction = 0;
    public bool isred = false;

    private Vector3 move = new Vector3(0, 0, -10);
    private Vector3 move1 = new Vector3(-10, 0, 0);
    private Vector3 move2 = new Vector3(0, 0, 10);

    private MeshRenderer lightr1;

    // Start is called before the first frame update
    void Start()
    {
        isred = false;
        lightr1 = light.gameObject.GetComponent<MeshRenderer>();
        GlobalControl.Instance.musica.Play();
    }
    void Awake()
    {
        instanceGoClass = this;
        
    }

    // Update is called once per frame
    void Update()
    {
        counter -= Time.deltaTime;
        if (isred == false)
        {
            if (counter >= 5)
            {
                isMoving();
                Debug.Log("move");
            }
            if (counter < 0)
            {
                counter = 0;
            }
        }
        if (isred)
        {
            if (counter < -10)
            {
                isred = false;
                Material[] mymaterials = lightr1.materials;
                //mymaterials[0] = green;
                mymaterials[1] = black;
                mymaterials[2] = black;
                mymaterials[3] = green;
                lightr1.materials = mymaterials;
            }
            else if (counter < -8) {
                Material[] mymaterials = lightr1.materials;
                //mymaterials[0] = green;
                mymaterials[1] = black;
                mymaterials[2] = ambar;
                mymaterials[3] = black;
                lightr1.materials = mymaterials;

            }
            else if (counter < -2)
            {
                Material[] mymaterials = lightr1.materials;
                //mymaterials[0] = green;
                mymaterials[1] = red;
                mymaterials[2] = black;
                mymaterials[3] = black;
                lightr1.materials = mymaterials;

            }
        }            
        if (counter > 7) {
            counter = 7;
        }
    }
    void isMoving() {
        //move player
        if (direction == 2)
        {
            player.transform.Translate(move);
        }
        else if (direction == 1) {
            player.transform.Translate(move1);
        }
        else if (direction == 0)
        {
            player.transform.Translate(move2);
            Debug.Log(player.transform.position);
        }

    }
}
