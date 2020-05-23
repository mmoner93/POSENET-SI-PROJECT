using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlScript : MonoBehaviour
{
    public static controlScript instance;
    private int counter=0;
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
    

    // Update is called once per frame
    void Update()
    {

        check();
    }

    void check() {
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


        }
        

    }

   

    public void setManoIzqPosition(bool cual) {
        manoIzqInPosition = cual;
    }

    public void setManoDerPosition(bool cual)
    {
        manoDerInPosition = cual;
    }

}
