using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlRopa : MonoBehaviour
{
    public static controlRopa instance;
    private int counter = 0;
    public GameObject manoIz;
    public GameObject manoDer;

    private bool manoIzqInPosition;
    private bool manoDerInPosition;

    Vector3 pos1manoIzqJUEGO;
    Vector3 pos1manoDerJUEGO;
    Vector3 pos2manoIzqJUEGO;
    Vector3 pos2manoDerJUEGO;
    Vector3 pos3manoIzqJUEGO;
    Vector3 pos3manoDerJUEGO;


    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        manoIzqInPosition = false;
        manoDerInPosition = false;

    }


    void crearSitio()
    {
        //1
        pos1manoIzqJUEGO.x = -84.0f;
        pos1manoIzqJUEGO.y = 0.0f;
        pos1manoIzqJUEGO.z = 1.836f;
        pos1manoDerJUEGO.x = -465.0f;
        pos1manoDerJUEGO.y = 0.0f;
        pos1manoDerJUEGO.z = 1.836f;


        //2

        pos2manoIzqJUEGO.x = -20.0f;
        pos2manoIzqJUEGO.y = 0.0f;
        pos2manoIzqJUEGO.z = 1.836f;
        pos2manoDerJUEGO.x = -435.0f;
        pos2manoDerJUEGO.y = 0.0f;
        pos2manoDerJUEGO.z = 1.836f;



        //3

        pos3manoIzqJUEGO.x = -0.0f;
        pos3manoIzqJUEGO.y = 0.0f;
        pos3manoIzqJUEGO.z = 1.836f;
        pos3manoDerJUEGO.x = -10.0f;
        pos3manoDerJUEGO.y = 0.0f;
        pos3manoDerJUEGO.z = 1.836f;
    }

    // Update is called once per frame
    void Update()
    {

        check();
    }

    void check()
    {
        if (manoDerInPosition && manoIzqInPosition)
        {


            switch (counter)
            {
                case 0:
                    manoIz.transform.position = pos1manoIzqJUEGO;
                    manoDer.transform.position = pos1manoDerJUEGO;
                    break;
                case 1:
                    manoIz.transform.position = pos2manoIzqJUEGO;
                    manoDer.transform.position = pos2manoDerJUEGO;
                    break;
                case 2:
                    manoIz.transform.position = pos3manoIzqJUEGO;
                    manoDer.transform.position = pos3manoDerJUEGO;
                    break;
                default: break;
            }

            counter++;
        }


    }



    public void setManoIzqPosition(bool cual)
    {
        manoIzqInPosition = cual;
    }

    public void setManoDerPosition(bool cual)
    {
        manoDerInPosition = cual;
    }
}
