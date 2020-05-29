using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class controlRopa : MonoBehaviour
{
    public static controlRopa instance;
    private int counter = 0;
    public GameObject manoIzCube;
    public GameObject manoDerCube;
    public GameObject piernaDerCube;
    public GameObject piernaIzCube;
    public GameObject CajaVisual;

    public GameObject camiseta;
    public GameObject pantalon;
    public GameObject zapatos;

    public Material mat1;
    public Material mat2;
    public Material mat3;


    public Material camisetaOn;
    public Material pantalonOn;
    public Material zapatoOn;

    private bool manoIzqInPosition;
    private bool manoDerInPosition;
    private bool piernaIzqInPosition;
    private bool piernaDerInPosition;

    Vector3 pos1manoIzqJUEGO;
    Vector3 pos1manoDerJUEGO;
    Vector3 pos1piernaIzqJUEGO;
    Vector3 pos1piernaDerJUEGO;


    Vector3 pos2manoIzqJUEGO;
    Vector3 pos2manoDerJUEGO;
    Vector3 pos2piernaIzqJUEGO;
    Vector3 pos2piernaDerJUEGO;


    Vector3 pos3manoIzqJUEGO;
    Vector3 pos3manoDerJUEGO;
    Vector3 pos3piernaIzqJUEGO;
    Vector3 pos3piernaDerJUEGO;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        manoIzqInPosition = false;
        manoDerInPosition = false;
        piernaIzqInPosition = false;
        piernaDerInPosition = false;
        crearSitio();
        counter = 0;

        manoIzCube.transform.position = pos1manoIzqJUEGO;
        manoDerCube.transform.position = pos1manoDerJUEGO;
        CajaVisual.GetComponent<MeshRenderer>().material = mat1;

    }
    


    void crearSitio()
    {
        //1--------------------------------
        pos1manoIzqJUEGO.x = 174f;
        pos1manoIzqJUEGO.y = -0.0f;
        pos1manoIzqJUEGO.z = 1.836f;

        pos1manoDerJUEGO.x = -185f;
        pos1manoDerJUEGO.y = 0.0f;
        pos1manoDerJUEGO.z = 1.836f;



        pos1piernaIzqJUEGO.x=-110f;
        pos1piernaIzqJUEGO.y = -249.0f;
        pos1piernaIzqJUEGO.z = 1.836f;
        pos1piernaDerJUEGO.x = 115.0f;
        pos1piernaDerJUEGO.y = -270.0f;
        pos1piernaDerJUEGO.z = 1.836f;

        

        //2--------------------------------------

        pos2manoIzqJUEGO.x = 174f;
        pos2manoIzqJUEGO.y = -60.0f;
        pos2manoIzqJUEGO.z = 1.836f;

        pos2manoDerJUEGO.x = -185f;
        pos2manoDerJUEGO.y = -60.0f;
        pos2manoDerJUEGO.z = 1.836f;

        pos2piernaIzqJUEGO.x =-110f;
        pos2piernaIzqJUEGO.y  = -249.0f;
        pos2piernaIzqJUEGO.z  = 1.836f;

        pos2piernaDerJUEGO.x  = 115.0f;
        pos2piernaDerJUEGO.y  = -270.0f;
        pos2piernaDerJUEGO.z = 1.836f;

        //3----------------------------------------

        pos3manoIzqJUEGO.x = 174f;
        pos3manoIzqJUEGO.y = -100.0f;
        pos3manoIzqJUEGO.z = 1.836f;

        pos3manoDerJUEGO.x = -185f;
        pos3manoDerJUEGO.y = -100.0f;
        pos3manoDerJUEGO.z = 1.836f;


        pos3piernaIzqJUEGO.x =-110f;
        pos3piernaIzqJUEGO.y  = -249.0f;
        pos3piernaIzqJUEGO.z  = 1.836f;

        pos3piernaDerJUEGO.x  = 115.0f;
        pos3piernaDerJUEGO.y  = -270.0f;
        pos3piernaDerJUEGO.z = 1.836f;


    }

    // Update is called once per frame
    void Update()
    {

        check();
    }

    void check()
    {
        if (manoDerInPosition && manoIzqInPosition & piernaIzqInPosition & piernaDerInPosition)
        {
            Debug.Log("Dos true !!");
            Debug.Log("Antes cube iz  x"+ manoIzCube.transform.position.x + " y"+ manoIzCube.transform.position.y + " z"+ manoIzCube.transform.position.y);
            Debug.Log("Antes cube der  x" + manoDerCube.transform.position.x + " y" + manoDerCube.transform.position.y + " z" + manoDerCube.transform.position.y);
            Vector3 temp=manoIzCube.transform.position;
            // temp.y = temp.y - 10.0f;
            // manoIzCube.transform.position = temp;
            Debug.Log("Counter "+counter);
            switch (counter)
            {
               /* case 0:
                    Debug.Log("Entro a 0");
                    manoIzCube.transform.position = pos1manoIzqJUEGO;
                    manoDerCube.transform.position= pos1manoDerJUEGO;
                    CajaVisual.GetComponent<MeshRenderer>().material = mat1;
                    break;*/
                case 0:
                    camiseta.GetComponent<MeshRenderer>().material = camisetaOn;
                    manoIzCube.transform.position = pos2manoIzqJUEGO;
                    manoDerCube.transform.position= pos2manoDerJUEGO;
                    CajaVisual.GetComponent<MeshRenderer>().material = mat2;
                    break;
                case 1:
                    pantalon.GetComponent<MeshRenderer>().material = pantalonOn;
                    manoIzCube.transform.position= pos3manoIzqJUEGO;
                    manoDerCube.transform.position = pos3manoDerJUEGO;
                    CajaVisual.GetComponent<MeshRenderer>().material = mat3;
                    break;

                case 2:
                    zapatos.GetComponent<MeshRenderer>().material = zapatoOn;
                    SceneManager.LoadScene("GameSelector"); // 1
                    break;
                default: Debug.Log("CACA DEFAULT"); break;
            }

            Debug.Log("Despues cube iz  x" + manoIzCube.transform.position.x + " y" + manoIzCube.transform.position.y + " z" + manoIzCube.transform.position.y);
            Debug.Log("Despues cube der  x" + manoDerCube.transform.position.x + " y" + manoDerCube.transform.position.y + " z" + manoDerCube.transform.position.y);

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


    public void setPiernaDerPosition(bool cual)
    {
        piernaDerInPosition = cual;
    }
    public void setPiernaIzqPosition(bool cual)
    {
        piernaIzqInPosition = cual;
    }

}
